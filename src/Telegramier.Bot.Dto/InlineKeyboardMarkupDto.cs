using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class InlineKeyboardMarkupDto
{
    [JsonPropertyName("inline_keyboard")]
    public InlineKeyboardButtonDto[][] InlineKeyboard { get; set; }
}
