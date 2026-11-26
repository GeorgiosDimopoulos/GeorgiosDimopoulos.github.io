using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class JobsService : IJobsService
{
    public Task<IReadOnlyList<Job>> GetJobsAsync() => throw new NotImplementedException();

    public Task<Job> GetJobAsync(int id) => throw new NotImplementedException();
}
