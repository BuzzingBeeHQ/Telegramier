using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Telegramier.Bot.Client;
using Telegramier.Bot.Client.Interfaces;
using Telegramier.Bot.Client.Settings;

namespace Telegramier.Extensions;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddTelegramierBotClientWithConfiguration(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        return serviceCollection
            .AddTelegramierSettings(configuration)
            .AddHttpClient<ITelegramierBotClient, TelegramierBotClient>((httpClient, serviceProvider) =>
            {
                var botSettings = serviceProvider.GetRequiredService<IOptions<TelegramierBotSettings>>();
                return new TelegramierBotClient(botSettings.Value.BotToken, httpClient);
            })
            .Services;
    }

    public static IServiceCollection AddTelegramierBotClientWithToken(this IServiceCollection serviceCollection, string botToken)
    {
        return serviceCollection
            .AddHttpClient<ITelegramierBotClient, TelegramierBotClient>(httpClient => new TelegramierBotClient(botToken, httpClient))
            .Services;
    }

    private static IServiceCollection AddTelegramierSettings(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        return serviceCollection.Configure<TelegramierBotSettings>(configuration.GetSection(TelegramierBotSettings.SectionKey));
    }
}