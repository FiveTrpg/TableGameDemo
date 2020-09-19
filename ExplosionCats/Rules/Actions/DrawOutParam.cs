using ExplosionCats.Rules.Cards;
using System.Collections.Generic;

namespace ExplosionCats.Rules.Actions
{
    public struct DrawOutParam
    {
        public ExplosionCatCharacter Character { get; set; }
        public List<ExplosionCard> Cards { get; set; }
    }
}
