using gestionItems.Models;

public interface IItemRepository
{
    Task<int> AddItemAsync(ItemTrabajo item);

    Task<List<ItemTrabajo>> GetPendingItemAsync();
}