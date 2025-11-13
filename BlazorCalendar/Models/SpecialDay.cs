namespace BlazorCalendar.Models;

/// <summary>
/// Represents a special day with custom background color (e.g., holidays)
/// </summary>
public class SpecialDay
{
    /// <summary>
    /// The date of the special day
    /// </summary>
    public required DateTime Date { get; init; }
    
    /// <summary>
    /// Background color for the special day (hex format, e.g., "#FFD700")
    /// </summary>
    public required string BackgroundColor { get; init; }
    
    /// <summary>
    /// Optional name/description of the special day
    /// </summary>
    public required string? Name { get; set; }
}

