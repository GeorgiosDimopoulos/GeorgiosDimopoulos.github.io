using MyPortfolio.Models;

namespace MyPortfolio.Services;

public interface IPortfolioService
{
    Task<IReadOnlyList<Project>> GetProjectsAsync();
    Task<IReadOnlyList<TechEvent>> GetTechEventsAsync();
}
