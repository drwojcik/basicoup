using basicoup.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace basicoup.Services
{
    public interface IItemService
    {
        Task<List<Item>> GetAll();

    }

    public sealed class ItemService : IItemService
    {
        public async Task<List<Item>> GetAll()
        {
            await Task.Delay(2000);

            return new List<Item>
            {
                Item.Create("Cachaça","Brasil","https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Bouteille.jpg/1200px-Bouteille.jpg"),
                Item.Create("Vodka","Russia","https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Bouteille.jpg/1200px-Bouteille.jpg"),
                Item.Create("Rum","Caribe","https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Bouteille.jpg/1200px-Bouteille.jpg"),
                Item.Create("Moonshine","EUA","https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Bouteille.jpg/1200px-Bouteille.jpg"),
            };
                
        }
    }
}

