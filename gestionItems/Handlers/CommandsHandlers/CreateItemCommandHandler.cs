using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestionItems.Commands;
using gestionItems.Models;
using MediatR;

namespace gestionItems.Handlers.CommandsHandlers
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, int>
    {
        private readonly IItemRepository _repository;

        public CreateItemCommandHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var item = new ItemTrabajo
            {
                Descripcion = request.Descripcion,
                FechaEntrega = request.FechaEntrega,
                Relevancia = request.Relevancia,
                Estado = "Pendiente"
            };

            return await _repository.AddItemAsync(item);
        }
    }


}