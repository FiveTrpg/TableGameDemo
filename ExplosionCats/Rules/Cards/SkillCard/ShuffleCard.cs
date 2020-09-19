using ExplosionCats.Rules.Actions;
using System;
using System.Collections.Generic;
using System.Text;
using TableGame.Resource.Actions;
using TableGame.Resource.Cards;

namespace ExplosionCats.Rules.Cards.SkillCard
{
    public class ShuffleCard : ActionCard<ExplosionCatGameSet, Shuffle, EmptyParam, EmptyResult>
    {
        public ShuffleCard(ExplosionCatGameSet gameSet) : base(gameSet)
        {
        }
    }
}
