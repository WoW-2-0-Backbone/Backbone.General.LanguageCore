namespace Backbone.Language.Core.Time.Provider.Abstractions.Brokers;

/// <summary>
/// Defines an abstract time provider with basic time-related functionality.
/// </summary>
public interface ITimeProvider
{
    /// <summary>
    /// Gets the current date and time in UTC.
    /// </summary>
    /// <returns>Current date and time in UTC.</returns>
    DateTimeOffset GetUtcNow();

    /// <summary>
    /// Gets the current date and time in the local time zone.
    /// </summary>
    /// <returns>Current date and time in the local time zone.</returns>
    DateTimeOffset GetLocalNow();

    /// <summary>
    /// Gets the time zone of the local system.
    /// </summary>
    /// <returns>The local time zone information.</returns>
    TimeZoneInfo LocalTimeZone { get; }

    /// <summary>
    /// Gets the current system timestamp.
    /// </summary>
    /// <returns>A long representing the current timestamp.</returns>
    long GetTimestamp();
}