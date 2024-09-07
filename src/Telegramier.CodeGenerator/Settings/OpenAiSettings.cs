namespace Telegramier.CodeGenerator.Settings;

public class OpenAiSettings
{
    public string ModelId { get; set; } = string.Empty;
    public string ApiKey { get; set; } = string.Empty;
    public double Temperature { get; set; } = 1d;
    public int MaxTokenCount { get; set; } = 1000;
}