using Eastnetic.BLL.DTO;
using Eastnetic.BLL.Services.Interfaces;
using Eastnetic.DAL.Domain.Entities;
using Eastnetic.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.BLL.Services
{
    public class WindowService : IWindowService
    {
        private readonly IWindowRepository _windowRepository;

        public WindowService(IWindowRepository windowRepository)
        {
            _windowRepository = windowRepository;
        }
        public async Task<List<WindowDto>> GetWindows()
        {
            var result = await _windowRepository.GetWindows();
            var list = result.Select(x => new WindowDto()
            {
                Id = x.Id,
                OrderId = x.OrderId,
                Name = x.Name,
                TotalSubElements = x.TotalSubElements,
                QuantityOfWindows = x.QuantityOfWindows

            }).ToList();
            return list;
        }
        public async Task<WindowDto> SaveWindow(WindowDto dto)
        {
            var window = new Window
            {
                Id = dto.Id,
                OrderId = dto.OrderId,
                Name = dto.Name,
                TotalSubElements = dto.TotalSubElements,
                QuantityOfWindows = dto.QuantityOfWindows
            };
            var result = await _windowRepository.SaveWindow(window);
            return dto;
        }
        public async Task<bool> DeleteById(long id)
        {
            var result = await _windowRepository.DeleteById(id);
            if (result != null)
            {
                return true;
            }
            return false;
        }
    } 
}
