using ExplosionCats.Rules.Actions;
using TableGame.Resource.Actions;

namespace ExplosionCats.Rules.Cards.SkillCards
{
    public class ShuffleCard : SkillCard<Shuffle, EmptyParam, EmptyResult>
    {
        public ShuffleCard(ExplosionCatGameSet gameSet) : base(gameSet)
        {
        }
    }
}
