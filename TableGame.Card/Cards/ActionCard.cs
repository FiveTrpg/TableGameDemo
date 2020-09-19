using System;
using System.Collections.Generic;
using System.Text;
using TableGame.Core.Game;

namespace TableGame.Resource.Cards
{
    public abstract class ActionCard<TGameSet, TAction, TParam, TResult> : Card<TGameSet>
        where TGameSet : GameSet<TGameSet>
        where TAction : GameAction<TAction, TGameSet, TParam, TResult>
    {
        public TAction Action { get; set; }
        public ActionCard(TGameSet gameSet) : base(gameSet)
        {
            this.Action = Activator.CreateInstance(typeof(TAction), gameSet) as TAction;
        }
    }
}
