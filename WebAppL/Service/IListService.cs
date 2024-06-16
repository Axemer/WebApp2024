using WebAppL.Models;

namespace WebAppL.Service
{
    public interface IListService
    {
        List<PersonModel> GetAll();
        void Add(PersonModel item);
        void Save();
    }
}
