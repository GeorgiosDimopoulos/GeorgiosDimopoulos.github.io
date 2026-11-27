using System.Net.Http.Json;
using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class StudiesService(HttpClient http) : IStudiesService
{
    public async Task<IReadOnlyList<Study>> GetStudiesAsync() =>
        await http.GetFromJsonAsync<List<Study>>("data/studies.json") ?? [];

    public async Task<IReadOnlyList<Language>> GetLanguagesAsync() =>
        await http.GetFromJsonAsync<List<Language>>("data/languages.json") ?? [];
}
