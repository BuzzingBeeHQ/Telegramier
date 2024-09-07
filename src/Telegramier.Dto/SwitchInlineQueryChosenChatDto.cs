using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SwitchInlineQueryChosenChatDto
{
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("allow_user_chats")]
    public bool? AllowUserChats { get; set; }

    [JsonPropertyName("allow_bot_chats")]
    public bool? AllowBotChats { get; set; }

    [JsonPropertyName("allow_group_chats")]
    public bool? AllowGroupChats { get; set; }

    [JsonPropertyName("allow_channel_chats")]
    public bool? AllowChannelChats { get; set; }
}
