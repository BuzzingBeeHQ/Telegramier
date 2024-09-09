using Telegramier.Bot.Dto;

namespace Telegramier.Bot.Client.Interfaces;

public interface ITelegramierBotClient
{
    public Task<ResponseDto<WebhookInfoDto>> GetWebhookInfoAsync();
    public Task<ResponseDto<bool>> SetWebhookAsync(SetWebhookDto setWebhook);
    public Task<ResponseDto<bool>> DeleteWebhookAsync(DeleteWebhookDto deleteWebhook);

    public Task<ResponseDto<MessageDto>> SendMessageAsync(SendMessageDto sendMessage);
}