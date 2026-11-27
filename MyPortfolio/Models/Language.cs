namespace MyPortfolio.Models;

public record Language(
    string Name,
    string Certificate,
    string Level,
    IReadOnlyList<string> Experiences);
