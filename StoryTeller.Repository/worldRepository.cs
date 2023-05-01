using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoryTeller.Data;

namespace StoryTeller.UI
{
    public class worldRepository
    {
        private List<World> _worldDb = new List<World>();
        private int _count = 0;

        // C.R.U.D

        //Create
        public bool AddWorld(World world)
        {
            if (world is null)
            {
                return false;
            }
            else
            {
                _count++;
                world.ID = _count;
                _worldDb.Add(world);
                return true;
            }
        }
        // R -> Read All
        public List<World> GetWorlds()
        {
            return _worldDb;

        }
        // R -> Read by Id
        public World GetWorld(int id)
        {
            return _worldDb.FirstOrDefault(w => w.ID == id)!;
        }

        // U -> Update

        public bool UpdateWorld(int id, World newWorldData)
        {
            World oldWorldData = GetWorld(id);
            if (oldWorldData != null)
            {
                oldWorldData.Name = newWorldData.Name;
                if (newWorldData.Levels.Count() > 0)
                {
                    oldWorldData.Levels = newWorldData.Levels;
                }
                return true;
            }
            return false;
        }

        // delete 
        public bool DeleteWorld(int id)
        {
            World oldWorldData = GetWorld(id);
            if (oldWorldData != null)
            {
                _worldDb.Remove(oldWorldData);
                return true;
            }
            return false;
        }
        private void Seed()
        {
            World world = new World
            {
                Name = "World 1"
            };

            AddWorld(world);
            
        }
        
    }
}