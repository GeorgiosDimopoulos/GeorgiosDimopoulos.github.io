using MyPortfolio.Models;

namespace MyPortfolio.Services;

public interface IPortfolioService
{
    Task<IReadOnlyList<Project>> GetProjectsAsync();
    Task<IReadOnlyList<TechEvent>> GetTechEventsAsync();
    // Task<Project> GetProjectByIdAsync();
    // Task<bool> CreateProject(Project project);
    // Task<bool> DeleteProject(int id);
    // Task<bool> UpdateProject(int id, Project project);
}
