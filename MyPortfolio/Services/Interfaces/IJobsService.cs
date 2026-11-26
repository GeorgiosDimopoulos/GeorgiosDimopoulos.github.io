using MyPortfolio.Models;

namespace MyPortfolio.Services;

public interface IJobsService
{
    Task<IReadOnlyList<Job>> GetJobsAsync();
}
