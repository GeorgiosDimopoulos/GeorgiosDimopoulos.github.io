using System.Net.Http.Json;
using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class LifeService (HttpClient http): ILifeService
{
    public async Task<IReadOnlyList<LifeChapter>> GetLifeChaptersAsync()
    {
        return await http.GetFromJsonAsync<List<LifeChapter>>("data/life") ?? [];
    }
}
