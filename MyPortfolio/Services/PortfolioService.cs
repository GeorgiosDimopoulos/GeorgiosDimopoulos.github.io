using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class PortfolioService : IPortfolioService
{
    public Task<IReadOnlyList<Project>> GetProjectsAsync() => throw new NotImplementedException();

    public Task<IReadOnlyList<TechEvent>> GetTechEventsAsync(int id) => throw new NotImplementedException();
}
