# BlazorCalendar.Special

A feature-rich Blazor calendar component with support for monthly, weekly, and annual views.

## New in v2.8.0: SpecialDays Feature

Highlight holidays, birthdays, deadlines, or any special dates with custom background colors.

```csharp
specialDays = new SpecialDay[]
{
    new SpecialDay 
    { 
        Date = new DateTime(2024, 12, 25), 
        BackgroundColor = "#FFE4E1", 
        Name = "Christmas" 
    },
    new SpecialDay 
    { 
        Date = new DateTime(2024, 1, 1), 
        BackgroundColor = "#FFD700", 
        Name = "New Year" 
    }
};
```

```razor
<MonthlyView SpecialDays="@specialDays" ... />
```

## Features

- **Multiple Views**: Monthly, Weekly, and Annual calendar views
- **SpecialDays Support**: Highlight specific dates with custom background colors
- **Drag & Drop**: Move tasks between days (optional)
- **Multi-day Events**: Tasks can span multiple days
- **Customizable Styling**: Configure colors, styles, and appearance
- **Event Callbacks**: React to clicks, drag/drop, and navigation
- **Priority Labels**: Display tasks by code or caption
- **Time Support**: Show timed events with hour/minute precision
- **Fill Patterns**: Various fill styles for visual distinction

## Installation

```bash
dotnet add package BlazorCalendar.Special
```

## Quick Start

### 1. Add to _Imports.razor

```razor
@using BlazorCalendar
@using BlazorCalendar.Models
```

### 2. Include CSS

In your `App.razor` or `MainLayout.razor`:

```razor
<link href="_content/BlazorCalendar/BlazorCalendar.css" rel="stylesheet" />
```

### 3. Use the Component

```razor
@page "/calendar"

<CalendarContainer FirstDate="@today" 
                   TasksList="@tasks.ToArray()" 
                   DisplayedView="DisplayedView.Monthly">
    <MonthlyView 
        TaskClick="OnTaskClick" 
        DayClick="OnDayClick" 
        HighlightToday="true"
        SpecialDays="@specialDays" />
</CalendarContainer>

@code {
    private DateTime today = DateTime.Today;
    private List<Tasks> tasks = new();
    private SpecialDay[] specialDays;

    protected override void OnInitialized()
    {
        // Add your tasks
        tasks.Add(new Tasks
        {
            ID = 1,
            DateStart = today.AddDays(5),
            DateEnd = today.AddDays(7),
            Code = "MEETING",
            Caption = "Project Review",
            Color = "#19C319"
        });

        // Define special days (holidays, etc.)
        specialDays = new SpecialDay[]
        {
            new SpecialDay 
            { 
                Date = today.AddDays(10), 
                BackgroundColor = "#FFE4E1", 
                Name = "Holiday" 
            }
        };
    }

    private void OnTaskClick(ClickTaskParameter param)
    {
        // Handle task click
    }

    private void OnDayClick(ClickEmptyDayParameter param)
    {
        // Handle day click
    }
}
```

## 📖 SpecialDay Properties

| Property | Type | Description |
|----------|------|-------------|
| `Date` | `DateTime` | The date to highlight |
| `BackgroundColor` | `string` | Hex color code (e.g., "#FFD700") |
| `Name` | `string?` | Optional description of the special day |

## Customization

### Custom Colors

```razor
<MonthlyView 
    WeekDaysColor="#FFFFFF"
    SaturdayColor="#ECF4FD"
    SundayColor="#DBE7F8"
    SpecialDays="@specialDays" />
```

### Drag & Drop

```razor
<MonthlyView 
    Draggable="true"
    DragStart="OnDragStart"
    DropTask="OnDropTask" />
```

### Priority Display

```razor
<MonthlyView PriorityDisplay="PriorityLabel.Caption" />
```

## Links

- **GitHub**: https://github.com/fiendie/Blazor-Calendar
- **Documentation**: See repository README
- **License**: MIT

## Credits

- **Original Author**: Christophe Peugnet
- **Fork Maintainer**: Andreas Tacke (added SpecialDays feature)

## License

MIT License - see the LICENSE file in the repository for details.

