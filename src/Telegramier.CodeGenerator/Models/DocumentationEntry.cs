using AngleSharp.Dom;

namespace Telegramier.CodeGenerator.Models;

public class DocumentationEntry
{
    public IElement? NextNode { get; private set; }
    public string Documentation { get; private set; }

    private DocumentationEntry(IElement? nextNode, string documentation)
    {
        NextNode = nextNode;
        Documentation = documentation;
    }

    public static DocumentationEntry Create(IElement? nextNode, string documentation)
    {
        return new DocumentationEntry(nextNode, documentation);
    }
}