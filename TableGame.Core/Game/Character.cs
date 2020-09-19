﻿namespace TableGame.Core.Game
{
    public abstract class Character<TGameSet>
        where TGameSet : GameSet<TGameSet>
    {
        public string Name { get; set; }
    }
}
