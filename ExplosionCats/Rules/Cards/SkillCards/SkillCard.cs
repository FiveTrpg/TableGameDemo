using TableGame.Core.Game;
using TableGame.Resource.Cards;

namespace ExplosionCats.Rules.Cards.SkillCards
{
    public class SkillCard<TAction, TParam, TResult> : ActionCard<ExplosionCatGameSet, TAction, TParam, TResult>, ISkillCard
        where TAction : GameAction<TAction, ExplosionCatGameSet, TParam, TResult>
    {
        public SkillCard(ExplosionCatGameSet gameSet) : base(gameSet)
        {
        }
    }
}
