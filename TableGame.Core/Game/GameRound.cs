using System.Threading.Tasks;

namespace TableGame.Core.Game
{
    public abstract class GameRound<TGameSet, TGameRule>
        where TGameSet : GameSet<TGameSet>
        where TGameRule : Rule<TGameSet>
    {
        public TGameSet GameSet { get; set; }
        public GameRound(TGameSet gameSet)
        {
            this.GameSet = gameSet;
        }

        public abstract ValueTask PreStart();
        public abstract ValueTask Start();
        public abstract ValueTask PostStart();

    }
}
