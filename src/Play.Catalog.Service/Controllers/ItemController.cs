using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using Microsoft.AspNetCore.Mvc;
using Play.Catalog.Service.Dtos;

namespace Play.Catalog.Service.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        private static readonly List<Item> _items = new()
        {
            new Item(Guid.NewGuid(), "Potion", "Restores a small amount of HP", 5, DateTimeOffset.UtcNow),
            new Item(Guid.NewGuid(), "Antidote", "Cures posion", 7, DateTimeOffset.UtcNow),
            new Item(Guid.NewGuid(), "Bronze sword", "Deals a small amount of damage", 20, DateTimeOffset.UtcNow)
        };

        // GET /items
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _items;
        }

        // GET /items/{id}
        [HttpGet("{id}")]
        public Item GetById(Guid id)
        {
            return _items.SingleOrDefault(x => x.Id == id);
        }

        // POST /items
        [HttpPost]
        public ActionResult<Item> Post(CreateItem createItem)
        {
            var item = new Item(Guid.NewGuid(), createItem.Name, createItem.Description, createItem.Price, DateTimeOffset.UtcNow);
            _items.Add(item);

            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        // PUT /items/{id}
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, UpdateItem updateItem)
        {
            var existingItem = _items.SingleOrDefault(x => x.Id == id);

            var updatedItem = existingItem with
            {
                Name = updateItem.Name,
                Description = updateItem.Description,
                Price = updateItem.Price
            };

            var idx = _items.IndexOf(existingItem);
            _items[idx] = updatedItem;
            
            return NoContent();
        }


    }
}