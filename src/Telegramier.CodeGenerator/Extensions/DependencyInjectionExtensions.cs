using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;
using Telegramier.CodeGenerator.Services;
using Telegramier.CodeGenerator.Settings;

namespace Telegramier.CodeGenerator.Extensions;

public static class DependencyInjectionExtensions
{
    public static ServiceProvider CreateRequiredServices()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        var settings = configuration.GetSettingsInstance();
        return new ServiceCollection()
            .AddSettings(configuration)
            .AddTransient<CodeGenerationService>()
            .AddTransient<LlmClientService>()
            .AddHttpClient<TelegramBotApiHttpService>()
            .Services
            .AddKernel()
            .AddOpenAIChatCompletion(settings.OpenAiSettings.ModelId, settings.OpenAiSettings.ApiKey)
            .Services
            .BuildServiceProvider();
    }

    private static ApplicationSettings GetSettingsInstance(this IConfiguration configuration)
    {
        var llmSettings = new ApplicationSettings();
        configuration.Bind(ApplicationSettings.SettingsKey, llmSettings);
        return llmSettings;
    }

    private static IServiceCollection AddSettings(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        return serviceCollection.Configure<ApplicationSettings>(configuration.GetSection(ApplicationSettings.SettingsKey));
    }
}