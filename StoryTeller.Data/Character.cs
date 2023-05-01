using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryTeller.Data
{
    public class Character
    {
       public Character() {}
       public Character(string name, List<Item> items) 
       {
        Name = name;
        Items = Items;
       }
       public int ID { get; set; } 
       public string Name { get; set; } = string.Empty;
       public List<Item> Items { get; set; } = new List<Item>();
    }
}