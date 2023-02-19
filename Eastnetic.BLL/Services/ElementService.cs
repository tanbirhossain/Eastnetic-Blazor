using Eastnetic.BLL.DTO;
using Eastnetic.BLL.Services.Interfaces;
using Eastnetic.DAL.Domain.Entities;
using Eastnetic.DAL.Repositories.Interfaces;

namespace Eastnetic.BLL.Services
{
    public class ElementService : IElementService
    {
        private readonly IElementRepository _elementRepository;

        public ElementService(IElementRepository elementRepository)
        {
            _elementRepository = elementRepository;
        }
        public async Task<List<SubElementDto>> GetElements()
        {
            var result = await _elementRepository.GetElements();
            var list = result.Select(x => new SubElementDto()
            {
                Id = x.Id,
                WindowId = x.WindowId,
                WindowName = x.Window.Name,
                Element = x.Element,
                Type = x.Type,
                Width = x.Width,
                Height = x.Height,

            }).ToList();
            return list;
        }
        public async Task<SubElementDto> SaveElement(SubElementDto dto)
        {
            var subElement = new SubElement
            {
                Id = dto.Id,
                WindowId = dto.WindowId,
                Element = dto.Element,
                Type = dto.Type,
                Width = dto.Width,
                Height = dto.Height,
            };
            var result = await _elementRepository.SaveElement(subElement);
            return dto;
        }
        public async Task<bool> DeleteById(long id)
        {
            var result = await _elementRepository.DeleteById(id);
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
