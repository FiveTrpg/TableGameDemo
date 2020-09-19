using ExplosionCats.Rules.Cards;
using System;
using System.Collections.Generic;
using System.Text;
using TableGame.Core.Game;
using TableGame.Core.Game.Object;

namespace ExplosionCats.Rules
{
    public class ExplosionCatCharactor : Character<ExplosionCatGameSet>,
        IInventoryHolder<ExplosionCatGameSet, ExplosionCard>
    {
        public Inventory<ExplosionCatGameSet, ExplosionCard> Inventory { get; set; }
        public bool IsDead { get; set; }
    }
}
