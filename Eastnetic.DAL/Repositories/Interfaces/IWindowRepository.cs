using Eastnetic.DAL.Domain.Entities;

namespace Eastnetic.DAL.Repositories.Interfaces
{
    public interface IWindowRepository
    {
        Task<Window> DeleteById(long id);
        public Task<List<Window>> GetWindows();
        Task<Window> SaveWindow(Window window);
    }
}
