using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TableGame.Core.Game
{
    public abstract class Rule<T> where T : GameSet<T>
    {
        public T GameSet { get; set; }
        public abstract ValueTask StartGame();
        public abstract ValueTask EndGame();
    }
}
