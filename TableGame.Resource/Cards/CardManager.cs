using System;
using System.Collections.Generic;
using TableGame.Core.Game;

namespace TableGame.Resource.Cards
{
    public class CardManager<TGameSet> : List<Card<TGameSet>>
        where TGameSet : GameSet<TGameSet>
    {
        public static IEnumerable<Type> EnumerateAllCardTypes()
        {
            var aimCards = typeof(Card<TGameSet>);
            foreach (var type in typeof(TGameSet).Assembly.ExportedTypes)
            {
                if (aimCards.IsAssignableFrom(type))
                {
                    yield return type;
                }
            }
        }
    }
}
