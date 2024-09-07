using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class KeyboardButtonRequestChatDto
{
    [JsonPropertyName("request_id")]
    public int RequestId { get; set; }

    [JsonPropertyName("chat_is_channel")]
    public bool ChatIsChannel { get; set; }

    [JsonPropertyName("chat_is_forum")]
    public bool? ChatIsForum { get; set; }

    [JsonPropertyName("chat_has_username")]
    public bool? ChatHasUsername { get; set; }

    [JsonPropertyName("chat_is_created")]
    public bool? ChatIsCreated { get; set; }

    [JsonPropertyName("user_administrator_rights")]
    public ChatAdministratorRightsDto? UserAdministratorRights { get; set; }

    [JsonPropertyName("bot_administrator_rights")]
    public ChatAdministratorRightsDto? BotAdministratorRights { get; set; }

    [JsonPropertyName("bot_is_member")]
    public bool? BotIsMember { get; set; }

    [JsonPropertyName("request_title")]
    public bool? RequestTitle { get; set; }

    [JsonPropertyName("request_username")]
    public bool? RequestUsername { get; set; }

    [JsonPropertyName("request_photo")]
    public bool? RequestPhoto { get; set; }
}
