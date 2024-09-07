using Microsoft.Extensions.Options;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.PromptTemplates.Liquid;
using Telegramier.CodeGenerator.Models;
using Telegramier.CodeGenerator.Settings;

namespace Telegramier.CodeGenerator.Services;

public class LlmClientService(Kernel kernel, IOptions<ApplicationSettings> options)
{
    public Task<string?> GenerateDtoContentAsync(string documentationEntry)
    {
        var kernelFunction = CreateKernelFunction();
        var kernelArguments = CreateKernelArguments(documentationEntry);
        return kernel.InvokeAsync<string>(kernelFunction, kernelArguments);
    }

    private KernelFunction CreateKernelFunction()
    {
        var openAiPromptExecutionSettings = new OpenAIPromptExecutionSettings
        {
            Temperature = options.Value.OpenAiSettings.Temperature,
            MaxTokens = options.Value.OpenAiSettings.MaxTokenCount
        };

        var promptTemplateConfig = new PromptTemplateConfig
        {
            Template = Prompts.SystemPromptTemplate,
            TemplateFormat = "liquid",
            Name = Prompts.PromptName
        };
        promptTemplateConfig.AddExecutionSettings(openAiPromptExecutionSettings);

        #pragma warning disable SKEXP0040
        var templateFactory = new LiquidPromptTemplateFactory();
        return kernel.CreateFunctionFromPrompt(promptTemplateConfig, templateFactory);
    }

    private KernelArguments CreateKernelArguments(string documentationEntry)
    {
        ChatHistory chatHistory =
        [
            new ChatMessageContent { Role = AuthorRole.User, Content = Prompts.GetUserPrompt(options.Value.NamespaceName, documentationEntry) }
        ];

        return new KernelArguments { { "history", chatHistory } };
    }
}