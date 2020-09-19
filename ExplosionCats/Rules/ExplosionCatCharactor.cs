using ExplosionCats.Rules.Cards;
using TableGame.Core.Game;
using TableGame.Core.Game.Object;

namespace ExplosionCats.Rules
{
    public class ExplosionCatCharacter : Character<ExplosionCatGameSet>,
        IInventoryHolder<ExplosionCatGameSet, ExplosionCard>
    {
        public Inventory<ExplosionCatGameSet, ExplosionCard> Inventory { get; set; }
        public bool IsDead { get; set; }
    }
}
