using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryTeller.Data
{

    public class World
    {
        public World() {}
        //Full Constructor
        public World(string name, List<string> levels) 
        {
            Name = name;
            Levels = levels;
        }
        public int ID { get; set; }
        public string Name { get; set; } 
        public List<string> Levels { get; set; } = new List<string> ();

    }
}