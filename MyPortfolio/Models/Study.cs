namespace MyPortfolio.Models;

public record Study(
    string Title,
    string University,
    string Department,
    string Location,
    List<string> Lessons,
    List<string> ProgrammingLanguages,
    int startYear,
    int endtYear,
    string? Badge = null,
    List<Project> projects);