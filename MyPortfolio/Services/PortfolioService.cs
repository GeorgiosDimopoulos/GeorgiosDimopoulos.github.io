using System.Net.Http.Json;
using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class PortfolioService(HttpClient http) : IPortfolioService
{
    public async Task<IReadOnlyList<Project>> GetProjectsAsync() =>
        await http.GetFromJsonAsync<List<Project>>("data/projects.json") ?? [];

    public async Task<IReadOnlyList<TechEvent>> GetTechEventsAsync() =>
        await http.GetFromJsonAsync<List<TechEvent>>("data/events.json") ?? [];
}
