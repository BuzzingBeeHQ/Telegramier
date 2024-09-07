using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class StickerDto
{
    [JsonPropertyName("file_id")]
    public string FileId { get; set; }

    [JsonPropertyName("file_unique_id")]
    public string FileUniqueId { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("is_animated")]
    public bool IsAnimated { get; set; }

    [JsonPropertyName("is_video")]
    public bool IsVideo { get; set; }

    [JsonPropertyName("thumbnail")]
    public PhotoSizeDto? Thumbnail { get; set; }

    [JsonPropertyName("emoji")]
    public string? Emoji { get; set; }

    [JsonPropertyName("set_name")]
    public string? SetName { get; set; }

    [JsonPropertyName("premium_animation")]
    public FileDto? PremiumAnimation { get; set; }

    [JsonPropertyName("mask_position")]
    public MaskPositionDto? MaskPosition { get; set; }

    [JsonPropertyName("custom_emoji_id")]
    public string? CustomEmojiId { get; set; }

    [JsonPropertyName("needs_repainting")]
    public bool? NeedsRepainting { get; set; }

    [JsonPropertyName("file_size")]
    public int? FileSize { get; set; }
}
