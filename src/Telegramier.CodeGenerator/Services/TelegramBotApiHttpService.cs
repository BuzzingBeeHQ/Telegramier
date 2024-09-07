namespace Telegramier.CodeGenerator.Services;

public class TelegramBotApiHttpService(HttpClient httpClient)
{
    public async Task<string> GetDocumentationHtmlAsync(string url)
    {
        return await httpClient.GetStringAsync(url);
    }
}