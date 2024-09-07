using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class DeleteStickerSetDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
