using System.Threading.Tasks;
using TableGame.Core.Game;
using TableGame.Resource.Actions;

namespace ExplosionCats.Rules.Actions
{
    public class Favor : GameAction<Favor, ExplosionCatGameSet, FavorParam, EmptyResult>
    {
        public Favor(ExplosionCatGameSet gameSet) : base(gameSet)
        {
        }

        public override bool PreRunValidation(FavorParam param)
        {
            return !param.OriginalCharactor.IsDead &&
                !param.TargetCharactor.IsDead &&
                param.OriginalCharactor.Inventory.Count - 1 > param.Index;
        }

        public override ValueTask<EmptyResult> Run(FavorParam param)
        {
            var card = param.OriginalCharactor.Inventory[param.Index];
            param.OriginalCharactor.Inventory.RemoveAt(param.Index);
            param.TargetCharactor.Inventory.Add(card);
            return default;
        }
    }
}
