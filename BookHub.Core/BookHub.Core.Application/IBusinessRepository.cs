namespace BookHub.Core.Application;

public interface IBusinessRepository
{
    public Task<List<Business>> GetBusinesses();
}