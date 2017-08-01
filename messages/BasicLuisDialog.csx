using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(Utils.GetAppSetting("LuisAppId"), Utils.GetAppSetting("LuisAPIKey"))))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Verzekering.Declareren")]
    public async Task Declareren(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Verzekering.Declareren intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Verzekering.Dekking")]
    public async Task Dekking(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Verzekering.Dekking intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Verzekering.PolisInformatie")]
    public async Task PolisInformatie(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Verzekering.PolisInformatie intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Verzekering.Typen")]
    public async Task Typen(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Verzekering.Typen intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
}