namespace Infra.BaseRepository;

public interface IRepositoryBase<T> where T : class
{
    Task CreateAsync(T model);
    Task<IList<T>> GetAllAsync();
}