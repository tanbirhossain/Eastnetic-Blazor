using Eastnetic.BLL.DTO;

namespace Eastnetic.BLL.Services.Interfaces
{
    public interface IWindowService
    {
        Task<bool> DeleteById(long id);
        public Task<List<WindowDto>> GetWindows();
        Task<WindowDto> SaveWindow(WindowDto dto);
    }
}
