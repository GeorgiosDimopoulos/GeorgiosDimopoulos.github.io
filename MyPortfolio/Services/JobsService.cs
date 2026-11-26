using System.Net.Http.Json;
using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class JobsService(HttpClient httpClient) : IJobsService
{
    public async Task<IReadOnlyList<Job>> GetJobsAsync()
    {
        return await httpClient.GetFromJsonAsync<List<Job>>("data/jobs") ?? [];
    }
}
