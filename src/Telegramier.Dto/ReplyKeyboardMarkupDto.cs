using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ReplyKeyboardMarkupDto
{
    [JsonPropertyName("keyboard")]
    public KeyboardButtonDto[][] Keyboard { get; set; }

    [JsonPropertyName("is_persistent")]
    public bool? IsPersistent { get; set; }

    [JsonPropertyName("resize_keyboard")]
    public bool? ResizeKeyboard { get; set; }

    [JsonPropertyName("one_time_keyboard")]
    public bool? OneTimeKeyboard { get; set; }

    [JsonPropertyName("input_field_placeholder")]
    public string? InputFieldPlaceholder { get; set; }

    [JsonPropertyName("selective")]
    public bool? Selective { get; set; }
}
