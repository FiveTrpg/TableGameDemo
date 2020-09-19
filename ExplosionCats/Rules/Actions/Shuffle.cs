using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TableGame.Core.Game;
using TableGame.Resource.Actions;

namespace ExplosionCats.Rules.Actions
{
    public class Shuffle : GameAction<Shuffle, ExplosionCatGameSet, EmptyParam, EmptyResult>
    {
        public Shuffle(ExplosionCatGameSet gameSet) : base(gameSet)
        {
        }

        public override bool PreRunValidation(EmptyParam param)
        {
            return true;
        }

        public override ValueTask<EmptyResult> Run(EmptyParam param)
        {
            this.GameSet.ShuffleCards();
            return default;
        }
    }
}
