using MyPortfolio.Models;

namespace MyPortfolio.Services;

public interface ILifeService
{
    Task<IReadOnlyList<LifeChapter>> GetLifeChaptersAsync();
}
