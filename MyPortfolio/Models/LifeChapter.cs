namespace MyPortfolio.Models;

public record LifeChapter(
    string Title,
    string Duration,
    string? Place,
    string Icon,
    string? Description = null);