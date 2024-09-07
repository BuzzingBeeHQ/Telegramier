using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetChatStickerSetDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("sticker_set_name")]
    public string StickerSetName { get; set; }
}
