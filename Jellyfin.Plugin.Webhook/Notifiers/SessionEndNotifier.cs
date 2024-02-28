using System.Threading.Tasks;
using Jellyfin.Plugin.Webhook.Destinations;
using Jellyfin.Plugin.Webhook.Helpers;
using MediaBrowser.Controller;
using MediaBrowser.Controller.Events;
using MediaBrowser.Controller.Events.Session;

namespace Jellyfin.Plugin.Webhook.Notifiers;

/// <summary>
/// Session end notifier.
/// </summary>
public class SessionEndNotifier : IEventConsumer<SessionEndedEventArgs>
{
    private readonly IServerApplicationHost _applicationHost;
    private readonly IWebhookSender _webhookSender;

    /// <summary>
    /// Initializes a new instance of the <see cref="SessionEndNotifier"/> class.
    /// </summary>
    /// <param name="applicationHost">Instance of the <see cref="IServerApplicationHost"/> interface.</param>
    /// <param name="webhookSender">Instance of the <see cref="IWebhookSender"/> interface.</param>
    public SessionEndNotifier(
        IServerApplicationHost applicationHost,
        IWebhookSender webhookSender)
    {
        _applicationHost = applicationHost;
        _webhookSender = webhookSender;
    }

    /// <inheritdoc />
    public async Task OnEvent(SessionEndedEventArgs eventArgs)
    {
        if (eventArgs.Argument is null)
        {
            return;
        }

        var dataObject = DataObjectHelpers
            .GetBaseDataObject(_applicationHost, NotificationType.SessionEnd)
            .AddSessionInfoData(eventArgs.Argument)
            .AddBaseItemData(eventArgs.Argument.FullNowPlayingItem);

        await _webhookSender.SendNotification(NotificationType.SessionEnd, dataObject)
            .ConfigureAwait(false);
    }
}
