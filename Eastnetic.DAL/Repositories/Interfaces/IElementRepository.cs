using Eastnetic.DAL.Domain.Entities;

namespace Eastnetic.DAL.Repositories.Interfaces
{
    public interface IElementRepository
    {
        Task<SubElement> DeleteById(long id);
        Task<List<SubElement>> GetElements();
        Task<SubElement> SaveElement(SubElement element);
    }
}
