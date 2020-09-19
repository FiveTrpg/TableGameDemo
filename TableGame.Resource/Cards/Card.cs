using TableGame.Core.Game;
using TableGame.Core.Game.Object;

namespace TableGame.Resource.Cards
{
    public abstract class Card<TGameSet> : GameObject<TGameSet>
        where TGameSet : GameSet<TGameSet>
    {
        public Card(TGameSet gameSet) : base(gameSet)
        {
        }

    }
}
