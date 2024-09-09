using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class InlineQueryResultGameDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("game_short_name")]
    public string GameShortName { get; set; }

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }
}
