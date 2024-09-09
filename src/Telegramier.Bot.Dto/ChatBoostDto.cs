using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatBoostDto
{
    [JsonPropertyName("boost_id")]
    public string BoostId { get; set; }

    [JsonPropertyName("add_date")]
    public int AddDate { get; set; }

    [JsonPropertyName("expiration_date")]
    public int ExpirationDate { get; set; }

    [JsonPropertyName("source")]
    public ChatBoostSourceDto Source { get; set; }
}
