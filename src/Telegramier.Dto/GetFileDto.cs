using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetFileDto
{
    [JsonPropertyName("file_id")]
    public string FileId { get; set; }
}
