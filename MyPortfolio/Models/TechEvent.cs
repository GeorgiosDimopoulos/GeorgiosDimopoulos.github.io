namespace MyPortfolio.Models;

public record TechEvent(
    string Title,
    string Location,
    string Description,
    IReadOnlyList<string> Tags,
    string? Years = null,
    string? Award = null);