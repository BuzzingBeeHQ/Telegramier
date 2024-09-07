namespace Telegramier.CodeGenerator.Services;

public class TelegramBotApiHttpService(HttpClient httpClient)
{
    public async Task<string> GetDocumentationAsHtmlAsync(string telegramDocumentationUrl)
    {
        return await httpClient.GetStringAsync(telegramDocumentationUrl);
    }
}