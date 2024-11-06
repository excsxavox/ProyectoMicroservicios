using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace gestionItems.Commands
{
    public class CreateItemCommand : IRequest<int>
{
    public string? Descripcion { get; set; }
    public DateTime FechaEntrega { get; set; }
    public string? Relevancia { get; set; }
}

}