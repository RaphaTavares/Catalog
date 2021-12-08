using System.Collections.Generic;
using Catalog.Entities;
using System;
using System.Linq;

namespace Catalog.Repositories
{
    public class InMemItemsRepository : IInMemItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = System.Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = System.Guid.NewGuid(), Name = "Sword", Price = 20, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = System.Guid.NewGuid(), Name = "Shield", Price = 18, CreatedDate = DateTimeOffset.UtcNow },
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }
    }
}