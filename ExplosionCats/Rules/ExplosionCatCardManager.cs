using ExplosionCats.Rules.Cards;
using ExplosionCats.Rules.Cards.CatCards;
using System.Collections.Generic;
using TableGame.Resource.Cards;

namespace ExplosionCats.Rules
{
    public class ExplosionCatCardManager : CardManager<ExplosionCatGameSet>
    {
        public static IEnumerable<ExplosionCard> CreateCards(ExplosionCatGameSet gameSet)
        {
            for (int i = 0; i < 4; i++)
            {
                yield return new BeardCat(gameSet);
                yield return new PotatoCat(gameSet);
                yield return new RainbowCat(gameSet);
                yield return new TaccoCat(gameSet);
                yield return new WatermelonCat(gameSet);
                yield return new ExplosionCat(gameSet);
            }
        }
    }
}
