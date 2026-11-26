using System.Net.Http.Json;
using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class PortfolioService (HttpClient httpClient): IPortfolioService
{
    public async Task<IReadOnlyList<Project>> GetProjectsAsync()
    {
        return await httpClient.GetFromJsonAsync<List<Project>>("data/projects") ?? [];
    }

    public async Task<IReadOnlyList<TechEvent>> GetTechEventsAsync()
    {
        return await httpClient.GetFromJsonAsync<List<TechEvent>>("data/events") ?? [];
    }
}
