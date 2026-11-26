using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class StudiesService : IStudiesService
{
    public Task<IReadOnlyList<Study>> GetStduiesAsync() => throw new NotImplementedException();

    public Task<IReadOnlyList<Language>> GetLanguagesAsync() => throw new NotImplementedException();
}
