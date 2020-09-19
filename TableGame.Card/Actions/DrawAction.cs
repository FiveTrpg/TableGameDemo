using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TableGame.Core.Game;

namespace TableGame.Resource.Actions
{
    public class DrawAction<TGameSet> : GameAction<DrawAction<TGameSet>, TGameSet, EmptyParam, EmptyResult>
    {
        public override bool PreRunValidation(EmptyParam param)
        {
            throw new NotImplementedException();
        }

        public override ValueTask<EmptyResult> Run(EmptyParam param)
        {
            throw new NotImplementedException();
        }
    }
}
