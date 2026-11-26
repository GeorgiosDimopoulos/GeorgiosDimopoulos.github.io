namespace MyPortfolio.Models;

public record Study(
    string Title,
    string University,
    string Department,
    string Location,
    IReadOnlyList<string> Lessons,
    IReadOnlyList<string> ProgrammingLanguages,
    int startYear,
    int endtYear,    
    IReadOnlyList<string> Projects,
    string? Badge = null,    
    string? Description = null);