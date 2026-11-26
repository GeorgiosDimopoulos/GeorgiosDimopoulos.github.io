using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class LifeService : ILifeService
{
    public Task<IReadOnlyList<LifeChapter>> GetLifeChaptersAsync() => throw new NotImplementedException();
}
