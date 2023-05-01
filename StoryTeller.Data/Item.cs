using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryTeller.Data
{
    public class Item
    {
       public Item(){}
       public Item(string name)
       {
        Name = name;
        }
       public int ID { get; set; } 
       public string Name { get; set; }
    }
}