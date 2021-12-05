using Catalog.Entities;
using System;
using System.Collections.Generic;

namespace Catalog.Repositories
{
    public interface IInMemItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}