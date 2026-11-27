namespace MyPortfolio.Models;

public record Job(
    string Company,
    string Location,
    string Summary,
    DateOnly StartDate,
    DateOnly? EndDate,
    IReadOnlyList<Role> Positions);

public record Role(
    string Title,
    IReadOnlyList<string> Points,
    IReadOnlyList<string> Tags,
    int? DurationMonths = null);
