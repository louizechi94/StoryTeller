using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoryTeller.Data;

namespace StoryTeller.Repository
{
    //When we create an instance of CharacterRepository
    // we want to loas a collection of "Characters" data
    public class characterRepository
    {
        public characterRepository()
        {
            Seed();
        }
        // this is the collection of characters: List<Character>
        private List<Character> _characterDB = new List<Character>();
        private int _count = 0;

        //C.R.U.D

        //C => CREATE
        public bool addCharacter(Character character)
        {
            if (character is null)
            {
                return false;
            }
            else
            {
                _count++;
                character.ID = _count;
                //add charcter to _characterDb (database) 
                _characterDB.Add(character);
                return true;
            }
        }

        // R -> Read All
        public List<Character> GetCharacters()
        {
            return _characterDB;
        }

        // R -> Read By ID
        public Character? GetCharacterByID(int id)
        {
            // loop through all the characters
            foreach (Character c in _characterDB)
            {
                // if we find a charcter with the neede id
                if (c.ID == id)
                {
                    //we will return the character for future use 
                    return c;
                }
                // otherwise we will return "null or nothing"
            }
                return null;

        }
        // UI -> Update
        public bool UpdateCharacterData(int id, Character newCharacterData)
        {
            // find a character in the data base
            Character oldCharacterData = GetCharacterByID(id);
            if (oldCharacterData != null)
            {
                oldCharacterData.Name = newCharacterData.Name;
                if (newCharacterData.Items.Count() > 0)
                {
                    oldCharacterData.Items = newCharacterData.Items;
                }
                return true;

            }
            //
            return false;
        }

        // D -> Delete
        public bool DeleteCharacterData(int id)
        {
            Character oldCharacterData = GetCharacterByID(id);
            if (oldCharacterData != null)
            {
                _characterDB.Remove(oldCharacterData);
                return true;
            }
            return false;
        }

    private void Seed()
    {
        Character humpty = new Character
        {
            Name = "Humpty"
        };
        Character wizzard = new Character
        {
            Name = "Wizzard"
        };
        Character king = new Character
        {
            Name = "King"
        };
        Character princess = new Character
        {
            Name = "Princess"
        };

        Character speckledHen = new Character
        {
           Name = "Speckeled Hen"
        };
        addCharacter(humpty);
        addCharacter(wizzard);
        addCharacter(king);
        addCharacter(princess);
        addCharacter( speckledHen);

    }
    }
}