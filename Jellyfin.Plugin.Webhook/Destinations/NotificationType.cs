namespace Jellyfin.Plugin.Webhook.Destinations;

/// <summary>
/// The type of notification.
/// </summary>
public enum NotificationType
{
    /// <summary>
    /// No notification type.
    /// </summary>
    None = 0,

    /// <summary>
    /// Item added notification.
    /// </summary>
    ItemAdded = 1,

    /// <summary>
    /// Generic notification.
    /// </summary>
    Generic = 2,

    /// <summary>
    /// Playback start notification.
    /// </summary>
    PlaybackStart = 3,

    /// <summary>
    /// Playback progress notification.
    /// </summary>
    PlaybackProgress = 4,

    /// <summary>
    /// Playback stop notification.
    /// </summary>
    PlaybackStop = 5,

    /// <summary>
    /// Subtitle download failure.
    /// </summary>
    SubtitleDownloadFailure = 6,

    /// <summary>
    /// Authentication failure.
    /// </summary>
    AuthenticationFailure = 7,

    /// <summary>
    /// Authentication success.
    /// </summary>
    AuthenticationSuccess = 8,

    /// <summary>
    /// Session ended.
    /// </summary>
    SessionEnd = 9,

    /// <summary>
    /// Session started.
    /// </summary>
    SessionStart = 10,

    /// <summary>
    /// Server pending restart.
    /// </summary>
    PendingRestart = 11,

    /// <summary>
    /// Task completed.
    /// </summary>
    TaskCompleted = 12,

    /// <summary>
    /// Plugin installation cancelled.
    /// </summary>
    PluginInstallationCancelled = 13,

    /// <summary>
    /// Plugin installation failed.
    /// </summary>
    PluginInstallationFailed = 14,

    /// <summary>
    /// Plugin installed.
    /// </summary>
    PluginInstalled = 15,

    /// <summary>
    /// Plugin installing.
    /// </summary>
    PluginInstalling = 16,

    /// <summary>
    /// Plugin uninstalled.
    /// </summary>
    PluginUninstalled = 17,

    /// <summary>
    /// Plugin updated.
    /// </summary>
    PluginUpdated = 18,

    /// <summary>
    /// User created.
    /// </summary>
    UserCreated = 19,

    /// <summary>
    /// User deleted.
    /// </summary>
    UserDeleted = 20,

    /// <summary>
    /// User locked out.
    /// </summary>
    UserLockedOut = 21,

    /// <summary>
    /// User password changed.
    /// </summary>
    UserPasswordChanged = 22,

    /// <summary>
    /// User updated.
    /// </summary>
    UserUpdated = 23,

    /// <summary>
    /// User data saved.
    /// </summary>
    UserDataSaved = 24
}
