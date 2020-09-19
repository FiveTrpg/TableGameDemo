using System;
using System.Collections.Generic;
using System.Text;

namespace ExplosionCats.Rules.Actions
{
    public struct FavorParam
    {
        public ExplosionCatCharactor OriginalCharactor { get; set; }
        public ExplosionCatCharactor TargetCharactor { get; set; }
        public int Index { get; set; }
    }
}
