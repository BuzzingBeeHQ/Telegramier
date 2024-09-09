using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatBoostRemovedDto
{
    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("boost_id")]
    public string BoostId { get; set; }

    [JsonPropertyName("remove_date")]
    public int RemoveDate { get; set; }

    [JsonPropertyName("source")]
    public ChatBoostSourceDto Source { get; set; }
}
