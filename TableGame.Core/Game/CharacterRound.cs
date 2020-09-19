using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TableGame.Core.Game
{
    public abstract class CharacterRound<TGameSet, TGameRule, TCharactor>
        where TGameSet : GameSet<TGameSet>
        where TGameRule : Rule<TGameSet>
        where TCharactor : Character<TGameSet>
    {
        public TGameSet GameSet { get; set; }
        public CharacterRound(TGameSet gameSet)
        {
            this.GameSet = gameSet;
        }

        public abstract ValueTask PreStart();
        public abstract ValueTask Start();
        public abstract ValueTask PostStart();

    }
}
