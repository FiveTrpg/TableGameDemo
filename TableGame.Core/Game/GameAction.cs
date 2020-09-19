using System.Threading.Tasks;

namespace TableGame.Core.Game
{
    public abstract class GameAction<TAction, TGameSet, TParam, TResult>
        where TGameSet : GameSet<TGameSet>
        where TAction : GameAction<TAction, TGameSet, TParam, TResult>
    {
        public abstract bool PreRunValidation(TParam param);
        public abstract ValueTask<TResult> Run(TParam param);

        public TGameSet GameSet { get; }
        public GameAction(TGameSet gameSet)
        {
            this.GameSet = gameSet;
        }
    }
}
