using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BusinessOpeningHoursDto
{
    [JsonPropertyName("time_zone_name")]
    public string TimeZoneName { get; set; }

    [JsonPropertyName("opening_hours")]
    public List<BusinessOpeningHoursIntervalDto> OpeningHours { get; set; }
}
