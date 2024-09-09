using Telegramier.Bot.Client.Interfaces;
using Telegramier.Bot.Dto;
using Telegramier.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTelegramierBotClientWithConfiguration(builder.Configuration);

var app = builder.Build();

app.MapGet("/set-webhook", async (ITelegramierBotClient telegramierBotClient) =>
{
    var webhookDto = new SetWebhookDto
    {
        Url = string.Empty,
        DropPendingUpdates = true
    };

    var response = await telegramierBotClient.SetWebhookAsync(webhookDto);
    return Results.Json(response);
});

app.MapPost("/receive", async (ITelegramierBotClient telegramierBotClient) =>
{
    var messageDto = new SendMessageDto
    {
        ChatId = 0,
        Text = string.Empty
    };

    var response = await telegramierBotClient.SendMessageAsync(messageDto);
    return Results.Json(response);
});

await app.RunAsync();