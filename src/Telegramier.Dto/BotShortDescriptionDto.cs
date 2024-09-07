using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BotShortDescriptionDto
{
    [JsonPropertyName("short_description")]
    public string ShortDescription { get; set; }
}
