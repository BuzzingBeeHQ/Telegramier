using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetChatPhotoDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("photo")]
    public InputFileDto Photo { get; set; }
}
