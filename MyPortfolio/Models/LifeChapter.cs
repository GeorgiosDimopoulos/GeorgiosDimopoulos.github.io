namespace MyPortfolio.Models;

public record LifeChapter(
    string Title,
    string Country,
    string Duration,
    string Icon,
    string? Place = null,
    string? Description = null);
