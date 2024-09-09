using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetStickerSetDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
