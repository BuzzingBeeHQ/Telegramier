using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetStickerSetDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
