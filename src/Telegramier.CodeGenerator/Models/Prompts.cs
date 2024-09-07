namespace Telegramier.CodeGenerator.Models;

public static class Prompts
{
    public const string PromptName = "Telegram_API_Documentation_Chat_Prompt";

    public const string SystemPromptTemplate =
        """
        system:
        You are a helpful AI assistant. As the assistant, you take the role of a Software Engineer.
        
        Given an user input containing part of the file in HTML format with Telegram Bot API documentation, output entity definition in the form of C# class.
        There is some rules to perform this task:
        - Please, write only C# file content without any extra explanations.
        - Add [JsonPropertyName] attribute to every C# property with a name that corresponds to the documentation in HTML format. Do not forget to include 'using System.Text.Json.Serialization;' instruction.
        - Add 'Dto' part to the end of every class name.
        - Add file-scoped namespace with the name from user input after usings section, but before the class definition.
        - If there is specific field with 'Optional' modifier, make C# property nullable.
        - If you can not parse given definition, please asnwer with empty response.
        
        {% for item in history %}
        {{item.role}}:
        {{item.content}}
        {% endfor %}
        """;

    public static string GetUserPrompt(string namespaceName, string documentationEntry)
    {
        return $"""
                User wants this namespace: '{namespaceName}'
                Part of the file in HTML format with Telegram Bot API documentation:
                {documentationEntry}
                """;
    }
}