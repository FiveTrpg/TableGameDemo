using System;
using System.Collections.Generic;
using System.Text;

namespace TableGame.Core.Game.Object
{
    public class Inventory<TGameSet, TGameObject> : List<GameObject<TGameSet>>
        where TGameSet : GameSet<TGameSet>
        where TGameObject : GameObject<TGameSet>
    {
        
    }
}
