using System.Net.Http.Json;
using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class JobsService(HttpClient http) : IJobsService
{
    public async Task<IReadOnlyList<Job>> GetJobsAsync() =>
        await http.GetFromJsonAsync<List<Job>>("data/jobs.json") ?? [];
}
