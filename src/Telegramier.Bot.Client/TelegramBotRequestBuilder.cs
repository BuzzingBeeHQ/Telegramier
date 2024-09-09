using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Telegramier.Bot.Client;

internal class TelegramBotRequestBuilder
{
    private const string BaseUrl = "https://api.telegram.org/bot";

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
        _botToken = botToken;
        return this;
    }

    internal TelegramBotRequestBuilder AddJsonContent(object body, JsonSerializerOptions? jsonSerializerOptions = null)
    {
        jsonSerializerOptions ??= new JsonSerializerOptions();
        jsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;

        _httpContent = JsonContent.Create(body, new MediaTypeHeaderValue("application/json"), jsonSerializerOptions);
        return this;
    }

    internal static TelegramBotRequestBuilder CreateNew(HttpMethod httpMethod, string methodName)
    {
        return new TelegramBotRequestBuilder(httpMethod, methodName);
    }

    internal HttpRequestMessage Build()
    {
        ValidateRequestParametersOrThrow();

        return new HttpRequestMessage
        {
            Method = _httpMethod,
            RequestUri = new Uri($"{BaseUrl}{_botToken}/{_methodName}", UriKind.Absolute),
            Content = _httpContent
        };
    }

    private void ValidateRequestParametersOrThrow()
    {
        ArgumentException.ThrowIfNullOrEmpty(_botToken);
    }
}