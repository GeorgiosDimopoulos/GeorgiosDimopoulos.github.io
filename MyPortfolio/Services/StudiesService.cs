using System.Net.Http.Json;
using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class StudiesService (HttpClient httpClient): IStudiesService
{
    public async Task<IReadOnlyList<Study>> GetStudiesAsync()
    {
        return await httpClient.GetFromJsonAsync<List<Study>>("data/events") ?? [];
    }

    public async Task<IReadOnlyList<Language>> GetLanguagesAsync()
    {
        return await httpClient.GetFromJsonAsync<List<Language>>("data/languages") ?? [];
    }   
}
