using Telegramier.Bot.Dto;

namespace Telegramier.Bot.Client.Interfaces;

public interface ITelegramierBotClient
{
    public Task<ResponseDto<bool>> SetWebhookAsync(SetWebhookDto setWebhook);
    public Task<ResponseDto<MessageDto>> SendMessageAsync(SendMessageDto sendMessage);
}