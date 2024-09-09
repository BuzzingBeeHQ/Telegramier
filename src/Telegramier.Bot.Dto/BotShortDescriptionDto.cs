using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BotShortDescriptionDto
{
    [JsonPropertyName("short_description")]
    public string ShortDescription { get; set; }
}
