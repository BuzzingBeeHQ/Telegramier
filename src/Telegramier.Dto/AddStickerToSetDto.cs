using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class AddStickerToSetDto
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("sticker")]
    public InputStickerDto Sticker { get; set; }
}
