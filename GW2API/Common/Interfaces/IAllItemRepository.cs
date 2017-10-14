using System.Collections.Generic;
using System.Threading.Tasks;

namespace GW2API.Common.Interfaces
{
    interface IAllItemRepository<Model>
    {
        Task<List<Model>> GetAllItems();
    }
}
