using MyPortfolio.Models;

namespace MyPortfolio.Services;

public interface IStudiesService
{
    Task<IReadOnlyList<Study>> GetStduiesAsync();
    Task<IReadOnlyList<Language>> GetLanguagesAsync();
}
