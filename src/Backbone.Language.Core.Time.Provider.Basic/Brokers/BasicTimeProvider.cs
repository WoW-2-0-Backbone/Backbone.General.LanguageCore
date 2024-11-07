using Backbone.Language.Core.Time.Provider.Abstractions.Brokers;

namespace Backbone.Language.Core.Time.Provider.Basic.Brokers;

/// <summary>
/// Provides basic time provider functionality using the underlying <see cref="TimeProvider"/>.
/// </summary>
public class BasicTimeProvider(TimeProvider timeProvider) : ITimeProvider
{
    /// <summary>
    /// Gets the current date and time in UTC.
    /// </summary>
    /// <returns>Current date and time in UTC.</returns>
    public DateTimeOffset GetUtcNow() => timeProvider.GetUtcNow();

    /// <summary>
    /// Gets the current date and time in the local time zone.
    /// </summary>
    /// <returns>Current date and time in the local time zone.</returns>
    public DateTimeOffset GetLocalNow() => timeProvider.GetLocalNow();

    /// <summary>
    /// Gets the time zone of the local system.
    /// </summary>
    /// <returns>The local time zone information.</returns>
    public TimeZoneInfo LocalTimeZone => timeProvider.LocalTimeZone;

    /// <summary>
    /// Gets the current system timestamp.
    /// </summary>
    /// <returns>A long representing the current timestamp.</returns>
    public long GetTimestamp() => timeProvider.GetTimestamp();
}