using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ExternalReplyInfoDto
{
    [JsonPropertyName("origin")]
    public MessageOriginDto Origin { get; set; }

    [JsonPropertyName("chat")]
    public ChatDto? Chat { get; set; }

    [JsonPropertyName("message_id")]
    public int? MessageId { get; set; }

    [JsonPropertyName("link_preview_options")]
    public LinkPreviewOptionsDto? LinkPreviewOptions { get; set; }

    [JsonPropertyName("animation")]
    public AnimationDto? Animation { get; set; }

    [JsonPropertyName("audio")]
    public AudioDto? Audio { get; set; }

    [JsonPropertyName("document")]
    public DocumentDto? Document { get; set; }

    [JsonPropertyName("paid_media")]
    public PaidMediaInfoDto? PaidMedia { get; set; }

    [JsonPropertyName("photo")]
    public PhotoSizeDto[]? Photo { get; set; }

    [JsonPropertyName("sticker")]
    public StickerDto? Sticker { get; set; }

    [JsonPropertyName("story")]
    public StoryDto? Story { get; set; }

    [JsonPropertyName("video")]
    public VideoDto? Video { get; set; }

    [JsonPropertyName("video_note")]
    public VideoNoteDto? VideoNote { get; set; }

    [JsonPropertyName("voice")]
    public VoiceDto? Voice { get; set; }

    [JsonPropertyName("has_media_spoiler")]
    public bool? HasMediaSpoiler { get; set; }

    [JsonPropertyName("contact")]
    public ContactDto? Contact { get; set; }

    [JsonPropertyName("dice")]
    public DiceDto? Dice { get; set; }

    [JsonPropertyName("game")]
    public GameDto? Game { get; set; }

    [JsonPropertyName("giveaway")]
    public GiveawayDto? Giveaway { get; set; }

    [JsonPropertyName("giveaway_winners")]
    public GiveawayWinnersDto? GiveawayWinners { get; set; }

    [JsonPropertyName("invoice")]
    public InvoiceDto? Invoice { get; set; }

    [JsonPropertyName("location")]
    public LocationDto? Location { get; set; }

    [JsonPropertyName("poll")]
    public PollDto? Poll { get; set; }

    [JsonPropertyName("venue")]
    public VenueDto? Venue { get; set; }
}
