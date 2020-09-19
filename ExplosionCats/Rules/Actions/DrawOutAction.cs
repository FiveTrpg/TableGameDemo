using ExplosionCats.Rules.Cards;
using System;
using System.Threading.Tasks;
using TableGame.Core.Game;
using TableGame.Resource.Actions;

namespace ExplosionCats.Rules.Actions
{
    public class DrawOutAction : GameAction<DrawOutAction, ExplosionCatGameSet, DrawOutParam, EmptyResult>
    {
        public DrawOutAction(ExplosionCatGameSet gameSet) : base(gameSet)
        {
        }

        private static readonly Type CatCardType = typeof(ICatCard);
        private static readonly Type SkillCardType = typeof(ISkillCard);
        public override bool PreRunValidation(DrawOutParam param)
        {
            // default base type is null
            Type baseType = null;
            foreach (var item in param.Cards)
            {
                if (!param.Character.Inventory.Contains(item))
                {
                    return false;
                }
                if (baseType == null)
                {
                    baseType = item is ICatCard ? CatCardType : SkillCardType;
                }
                else
                {
                    if ((item is ICatCard ? CatCardType : SkillCardType) != baseType)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override ValueTask<EmptyResult> Run(DrawOutParam param)
        {

        }
    }
}
