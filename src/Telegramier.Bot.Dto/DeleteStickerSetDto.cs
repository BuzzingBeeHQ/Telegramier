using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class DeleteStickerSetDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
