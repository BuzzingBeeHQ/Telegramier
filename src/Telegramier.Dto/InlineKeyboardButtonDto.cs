using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InlineKeyboardButtonDto
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("callback_data")]
    public string? CallbackData { get; set; }

    [JsonPropertyName("web_app")]
    public WebAppInfoDto? WebApp { get; set; }

    [JsonPropertyName("login_url")]
    public LoginUrlDto? LoginUrl { get; set; }

    [JsonPropertyName("switch_inline_query")]
    public string? SwitchInlineQuery { get; set; }

    [JsonPropertyName("switch_inline_query_current_chat")]
    public string? SwitchInlineQueryCurrentChat { get; set; }

    [JsonPropertyName("switch_inline_query_chosen_chat")]
    public SwitchInlineQueryChosenChatDto? SwitchInlineQueryChosenChat { get; set; }

    [JsonPropertyName("callback_game")]
    public CallbackGameDto? CallbackGame { get; set; }

    [JsonPropertyName("pay")]
    public bool? Pay { get; set; }
}
