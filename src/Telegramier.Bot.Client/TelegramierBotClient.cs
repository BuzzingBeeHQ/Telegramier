using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using Telegramier.Bot.Client.Interfaces;
using Telegramier.Bot.Client.Models;
using Telegramier.Bot.Dto;

namespace Telegramier.Bot.Client;

public class TelegramierBotClient(string botToken) : ITelegramierBotClient
{
    private readonly HttpClient _httpClient = new();

    public TelegramierBotClient(string botToken, HttpClient httpClient) : this(botToken)
    {
        _httpClient = httpClient;
    }

    public async Task<ResponseDto<WebhookInfoDto>> GetWebhookInfoAsync()
    {
        return await SendBaseAsync<WebhookInfoDto>().ConfigureAwait(false);
    }

    public async Task<ResponseDto<bool>> SetWebhookAsync(SetWebhookDto setWebhook)
    {
        return await SendBaseAsync<bool>(setWebhook).ConfigureAwait(false);
    }

    public async Task<ResponseDto<bool>> DeleteWebhookAsync(DeleteWebhookDto deleteWebhook)
    {
        return await SendBaseAsync<bool>(deleteWebhook).ConfigureAwait(false);
    }

    public async Task<ResponseDto<MessageDto>> SendMessageAsync(SendMessageDto sendMessage)
    {
        return await SendBaseAsync<MessageDto>(sendMessage).ConfigureAwait(false);
    }

    private async Task<ResponseDto<TResult>> SendBaseAsync<TResult>(object? requestDto = null, [CallerMemberName] string methodName = "")
    {
        var telegramRequest = TelegramBotRequestBuilder.Create(HttpMethod.Post, methodName.Replace("Async", string.Empty))
            .AddBotToken(botToken)
            .AddJsonContent(requestDto)
            .Build();

        var response = await _httpClient.SendAsync(telegramRequest).ConfigureAwait(false);
        var responseResult = await response.Content.ReadFromJsonAsync<ResponseDto<TResult>>().ConfigureAwait(false);
        return responseResult ?? throw new InvalidOperationException("The response content was null or invalid.");
    }
}