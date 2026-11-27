namespace MyPortfolio.Models;

public record Study(
    string Title,
    string University,
    string Location,
    int StartYear,
    int EndYear,
    IReadOnlyList<string> Lessons,
    IReadOnlyList<string> ProgrammingLanguages,
    IReadOnlyList<string> Projects,
    string? Department = null,
    string? Badge = null,
    string? Description = null,
    string? Note = null);
