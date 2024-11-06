using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestionItems.Models;
using MediatR;

namespace gestionItems.Commands
{
    public class GetPendingItemsQuery: IRequest<List<ItemTrabajo>>
    {
        
    }
}