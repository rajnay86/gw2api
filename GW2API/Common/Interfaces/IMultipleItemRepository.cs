using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2API.Common.Interfaces
{
    interface IMultipleItemRepository<Model, IdType>
    {
        Task<List<Model>> GetMultipleItems(List<IdType> ids);
    }
}
