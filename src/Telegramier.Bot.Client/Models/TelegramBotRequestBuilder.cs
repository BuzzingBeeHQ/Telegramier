using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Telegramier.Bot.Client.Models;

internal class TelegramBotRequestBuilder
{
    private readonly HttpMethod _httpMethod;
    private readonly string _methodName;
    private string? _botToken;
    private HttpContent? _httpContent;

    private TelegramBotRequestBuilder(HttpMethod httpMethod, string methodName)
    {
        _httpMethod = httpMethod ?? throw new ArgumentNullException(nameof(httpMethod));
        _methodName = methodName ?? throw new ArgumentNullException(nameof(methodName));
    }

    internal TelegramBotRequestBuilder AddBotToken(string botToken)
    {
        if (string.IsNullOrEmpty(botToken))
        {
            throw new ArgumentException("Telegram bot token cannot be null or empty.", nameof(botToken));
        }

        _botToken = botToken;
        return this;
    }

    internal TelegramBotRequestBuilder AddJsonContent(object? body, JsonSerializerOptions? jsonSerializerOptions = null)
    {
        jsonSerializerOptions = ValidateJsonSerializerOptions(jsonSerializerOptions);
        _httpContent = JsonContent.Create(body, new MediaTypeHeaderValue("application/json"), jsonSerializerOptions);
        return this;
    }

    internal static TelegramBotRequestBuilder Create(HttpMethod httpMethod, string methodName)
    {
        return new TelegramBotRequestBuilder(httpMethod, methodName);
    }

    internal HttpRequestMessage Build()
    {
        return new HttpRequestMessage
        {
            Method = _httpMethod,
            RequestUri = new Uri($"{Constants.BaseApiUrl}{_botToken}/{_methodName}", UriKind.Absolute),
            Content = _httpContent
        };
    }

    private static JsonSerializerOptions ValidateJsonSerializerOptions(JsonSerializerOptions? jsonSerializerOptions)
    {
        jsonSerializerOptions ??= new JsonSerializerOptions();
        jsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;

        return jsonSerializerOptions;
    }
}