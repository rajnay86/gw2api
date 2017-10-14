using System.Collections.Generic;
using System.Threading.Tasks;

namespace GW2API.Common.Interfaces
{
    interface IIdRepository<IdType>
    {
        Task<List<IdType>> GetIds();
    }
}
