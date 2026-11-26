namespace MyPortfolio.Models;

public record Language(string Name, string Institute, string Level, IReadOnlyList<string> experiences);