using System.Text;
using System.Text.RegularExpressions;
using AngleSharp;
using AngleSharp.Dom;
using Microsoft.Extensions.Options;
using ShellProgressBar;
using Telegramier.CodeGenerator.Models;
using Telegramier.CodeGenerator.Settings;

namespace Telegramier.CodeGenerator.Services;

public partial class CodeGenerationService(TelegramBotApiHttpService telegramBotApiHttpService, LlmClientService llmClientService, IOptions<ApplicationSettings> options)
{
    private static readonly IConfiguration BrowsingConfiguration = Configuration.Default;
    private static readonly ProgressBarOptions ProgressBarOptions = new()
    {
        ForegroundColor = ConsoleColor.Magenta,
        ProgressCharacter = '─'
    };

    public async Task GenerateTelegramBotApiDefinitionsAsync()
    {
        string htmlDocumentation = await telegramBotApiHttpService.GetDocumentationHtmlAsync(options.Value.TelegramBotApiDocumentationUrl);

        var context = BrowsingContext.New(BrowsingConfiguration);
        var htmlDocument = await context.OpenAsync(request => request.Content(htmlDocumentation));

        var devContentContainer = PreprocessDocumentationNodes(htmlDocument);

        List<string> documentationEntries = [];
        var currentNode = devContentContainer.FirstElementChild;

        while (currentNode is not null)
        {
            if (currentNode is { LocalName: "h4" })
            {
                var documentationEntry = ConvertToDocumentationEntry(currentNode);
                documentationEntries.Add(documentationEntry.Documentation);
                currentNode = documentationEntry.NextNode;
            }
            else
            {
                currentNode = currentNode.NextElementSibling;
            }
        }

        await GenerateDtoFilesAsync(documentationEntries);
    }

    private async Task GenerateDtoFilesAsync(List<string> entries)
    {
        using var progressBar = new ProgressBar(entries.Count, "Processing Telegram Bot API documentation entries...", ProgressBarOptions);

        foreach (var documentationEntry in entries)
        {
            var dtoFileContent = await llmClientService.GenerateDtoContentAsync(documentationEntry);
            if (!string.IsNullOrWhiteSpace(dtoFileContent))
            {
                await ProcessContentAndSaveAsync(dtoFileContent);
            }

            progressBar.Tick();
        }
    }

    private Task ProcessContentAndSaveAsync(string dtoFileContent)
    {
        dtoFileContent = dtoFileContent.Replace("```csharp\n", string.Empty);
        dtoFileContent = dtoFileContent.Replace("```", string.Empty);

        string fileNameWithoutExtension = Guid.NewGuid().ToString();
        Match classNameMatch = ClassNameRegex().Match(dtoFileContent);

        if (classNameMatch.Success)
        {
            fileNameWithoutExtension = classNameMatch.Groups[1].Value;
        }

        var dtoFilePath = Path.Combine(options.Value.OutputDirectoryPath, $"{fileNameWithoutExtension}.cs");
        return File.WriteAllTextAsync(dtoFilePath, dtoFileContent);
    }

    private static IElement PreprocessDocumentationNodes(IDocument htmlDocument)
    {
        var devContentContainer = htmlDocument.QuerySelector("#dev_page_content");
        if (devContentContainer is null)
        {
            throw new ArgumentException("The HTML document does not contain an element with the id 'dev_page_content'.");
        }

        var nodeToRemove = devContentContainer.FirstElementChild;
        while (nodeToRemove is not null)
        {
            if (nodeToRemove is { LocalName: "h3", TextContent: "Getting updates" })
            {
                break;
            }

            var nextNode = nodeToRemove.NextElementSibling;
            nodeToRemove.Remove();
            nodeToRemove = nextNode;
        }

        return devContentContainer;
    }

    private static DocumentationEntry ConvertToDocumentationEntry(IElement currentNode)
    {
        var representation = new StringBuilder();
        representation.AppendLine(currentNode.OuterHtml);

        var nextNode = currentNode.NextElementSibling;
        while (nextNode is not null && nextNode is not { LocalName: "h3" or "h4" })
        {
            representation.AppendLine(nextNode.OuterHtml);
            nextNode = nextNode.NextElementSibling;
        }

        return DocumentationEntry.Create(nextNode, representation.ToString());
    }

    [GeneratedRegex(@"class\s+(\w+)")]
    private static partial Regex ClassNameRegex();
}