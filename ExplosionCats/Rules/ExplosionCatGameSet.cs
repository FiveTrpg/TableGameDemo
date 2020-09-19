using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TableGame.Core.Game;

namespace ExplosionCats.Rules
{
    public class ExplosionCatGameSet
        : GameSet<ExplosionCatGameSet>
    {

        public ExplosionCatGameSet()
            : base("爆炸猫咪", "Unknown", "Draw card and let other player draw the explosion cat!")
        {

        }

        public void ShuffleCards()
        {
            throw new NotImplementedException();
        }

        public override ValueTask LoadResources()
        {

            return default;
        }
    }
}
