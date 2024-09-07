using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class KeyboardButtonDto
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("request_users")]
    public KeyboardButtonRequestUsersDto? RequestUsers { get; set; }

    [JsonPropertyName("request_chat")]
    public KeyboardButtonRequestChatDto? RequestChat { get; set; }

    [JsonPropertyName("request_contact")]
    public bool? RequestContact { get; set; }

    [JsonPropertyName("request_location")]
    public bool? RequestLocation { get; set; }

    [JsonPropertyName("request_poll")]
    public KeyboardButtonPollTypeDto? RequestPoll { get; set; }

    [JsonPropertyName("web_app")]
    public WebAppInfoDto? WebApp { get; set; }
}
