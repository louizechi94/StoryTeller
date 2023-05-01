using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoryTeller.Data;

namespace StoryTeller.Repository
{
    public class itemRepository
    {
      private List<Item> _itemDB = new List<Item>();
        private int _count =0;

        // C.R

        //Create
        public bool AddItem(Item item)
        {
            if(item is null)
            {
                return false;
            }
            else 
            {
                _count++;
                item.ID = _count;
                _itemDB.Add(item);
                return true;
            }
            
        }
        //Read GetAll
            public List<Item> GetItems()
            {
                return _itemDB;

            }
            // Read Get by Id
            public Item GetItem(int id)
            {
                return _itemDB.SingleOrDefault(i => i.ID == id)!;
            }
    }
}