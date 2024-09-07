using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class DeleteChatPhotoDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }
}
