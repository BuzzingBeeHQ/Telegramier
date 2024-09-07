using Microsoft.Extensions.DependencyInjection;
using Telegramier.CodeGenerator.Extensions;
using Telegramier.CodeGenerator.Services;

var serviceProvider = DependencyInjectionExtensions.CreateRequiredServices();

var codeGenerator = serviceProvider.GetRequiredService<CodeGenerationService>();
await codeGenerator.GenerateTelegramBotApiDefinitionsAsync();
