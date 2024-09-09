using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using Telegramier.Bot.Client.Interfaces;
using Telegramier.Bot.Dto;

namespace Telegramier.Bot.Client;

public class TelegramierBotClient(string botToken) : ITelegramierBotClient
{
    private readonly HttpClient _httpClient = new();

    public TelegramierBotClient(string botToken, HttpClient httpClient) : this(botToken)
    {
        _httpClient = httpClient;
    }

    public Task<ResponseDto<bool>> SetWebhookAsync(SetWebhookDto setWebhook)
    {
        return SendBaseAsync<bool>(setWebhook);
    }

    public Task<ResponseDto<MessageDto>> SendMessageAsync(SendMessageDto sendMessage)
    {
        return SendBaseAsync<MessageDto>(sendMessage);
    }

    private async Task<ResponseDto<TResult>> SendBaseAsync<TResult>(object requestDto, [CallerMemberName] string methodName = "")
    {
        var telegramRequest = TelegramBotRequestBuilder.CreateNew(HttpMethod.Post, methodName.Replace("Async", string.Empty))
            .AddBotToken(botToken)
            .AddJsonContent(requestDto)
            .Build();

        var response = await _httpClient.SendAsync(telegramRequest).ConfigureAwait(false);
        var responseResult = await response.Content.ReadFromJsonAsync<ResponseDto<TResult>>().ConfigureAwait(false);
        return responseResult!;
    }
}