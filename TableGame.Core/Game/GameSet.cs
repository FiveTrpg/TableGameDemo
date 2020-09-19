using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TableGame.Core.Game
{
    public abstract class GameSet<T> where T : GameSet<T>
    {
        public string Name { get; protected set; }
        public string Author { get; protected set; }
        public string Description { get; protected set; }
        public List<Character<T>> Characters { get; set; }
        public GameSet(string Name, string Author, string Description)
        {
            this.Name = Name;
            this.Author = Author;
            this.Description = Description;
            this.Characters = new List<Character<T>>();
        }

        public abstract ValueTask LoadResources();
    }
}
