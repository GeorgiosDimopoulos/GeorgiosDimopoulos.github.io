using MyPortfolio.Models;

namespace MyPortfolio.Services;

public interface IStudiesService
{
    Task<IReadOnlyList<Study>> GetStudiesAsync();
    Task<IReadOnlyList<Language>> GetLanguagesAsync();
    // Task<Study> GetStudyAsync(int id);
    // Task<Language> GetLanguageAsync(int id);

}
