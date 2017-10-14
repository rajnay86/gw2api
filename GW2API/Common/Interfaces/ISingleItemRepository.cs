using System.Threading.Tasks;

namespace GW2API.Common.Interfaces
{
    interface ISingleItemRepository<Model,IdType>
    {
        Task<Model> GetSingleItem(IdType id);
    }
}
