using Eastnetic.BLL.DTO;

namespace Eastnetic.BLL.Services.Interfaces
{
    public interface IElementService
    {
        Task<bool> DeleteById(long id);
        public Task<List<SubElementDto>> GetElements();
        Task<SubElementDto> SaveElement(SubElementDto dto);
    }
}
