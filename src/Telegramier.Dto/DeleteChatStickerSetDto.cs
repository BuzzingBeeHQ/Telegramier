using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class DeleteChatStickerSetDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }
}
