using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class PassportFileDto
{
    [JsonPropertyName("file_id")]
    public string FileId { get; set; }

    [JsonPropertyName("file_unique_id")]
    public string FileUniqueId { get; set; }

    [JsonPropertyName("file_size")]
    public int FileSize { get; set; }

    [JsonPropertyName("file_date")]
    public int FileDate { get; set; }
}
