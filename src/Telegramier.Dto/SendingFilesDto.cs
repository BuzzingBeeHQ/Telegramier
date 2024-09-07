using System.Text.Json.Serialization;

namespace Telegramier.Dto
{
    public class SendingFilesDto
    {
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
