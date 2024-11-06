using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestionItems.Models;

namespace gestionItems.Repositories
{
    public class ItemRepository:IItemRepository
    {
        private readonly List<ItemTrabajo> _items = new List<ItemTrabajo>();

        public Task<int> AddItemAsync(ItemTrabajo item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);

            return Task.FromResult(item.Id);
        }

        public Task<List<ItemTrabajo>> GetPendingItemAsync(){
            return Task.FromResult(_items.Where(i => i.Estado == "Pendiente").ToList());
        }
    }
}