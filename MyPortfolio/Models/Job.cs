namespace MyPortfolio.Models;

public record Job(
    string Company,
    string RepoUrl,
    string Tech,
    DateOnly StartDate,
    DateOnly? EndDate,
    IReadOnlyList<Language> Languages,
    IReadOnlyList<Role> Positions);

public record Role(
    string Title,
    IReadOnlyList<string> Points,
    IReadOnlyList<string> Tags,
    int? DurationMonths = null);

public record Language(
    string Name,
    string Certificate,
    string Level,
    IReadOnlyList<string> Experiences);