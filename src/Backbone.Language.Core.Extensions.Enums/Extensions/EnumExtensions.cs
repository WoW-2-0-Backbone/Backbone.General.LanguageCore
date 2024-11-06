using System.ComponentModel;
using System.Reflection;

namespace Backbone.Language.Core.Extensions.Enums.Extensions;

/// <summary>
/// Contains extensions for enums.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Gets the description of the enum value.
    /// </summary>
    /// <param name="value">The enum value.</param>
    /// <returns>The description if available, otherwise the name of the enum value.</returns>
    public static string GetDescription(this System.Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = field?.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description ?? value.ToString();
    }

    /// <summary>
    /// Gets all values of the enum and description as a list of key-value pairs.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <returns>A key-value pair list of enum value and description.</returns>
    public static List<KeyValuePair<T, string>> GetAllValuesAndDescriptions<T>() where T : System.Enum
    {
        return Enum.GetValues(typeof(T))
            .Cast<T>()
            .Select(e => new KeyValuePair<T, string>(e, e.GetDescription()))
            .ToList();
    }

    /// <summary>
    /// Gets the value of a specific attribute on an enum value.
    /// </summary>
    /// <typeparam name="TAttribute">The attribute type to retrieve.</typeparam>
    /// <param name="value">The enum value.</param>
    /// <returns>The attribute value if found; otherwise, null.</returns>
    public static TAttribute? GetAttributeValue<TAttribute>(this Enum value) where TAttribute : Attribute
    {
        var field = value.GetType().GetField(value.ToString());
        return field?.GetCustomAttribute<TAttribute>();
    }

    /// <summary>
    /// Gets all values of the enum along with a specified attribute's value as a list of key-value pairs.
    /// </summary>
    /// <typeparam name="TEnum">The enum type.</typeparam>
    /// <typeparam name="TAttribute">The attribute type.</typeparam>
    /// <returns>A list of key-value pairs where the key is the enum value and the value is the specified attribute's value.</returns>
    public static List<KeyValuePair<TEnum, TAttribute?>> GetAllValuesAndAttributeValues<TEnum, TAttribute>()
        where TEnum : Enum
        where TAttribute : Attribute
    {
        return Enum.GetValues(typeof(TEnum))
            .Cast<TEnum>()
            .Select(e => new KeyValuePair<TEnum, TAttribute?>(e, e.GetAttributeValue<TAttribute>()))
            .ToList();
    }
}