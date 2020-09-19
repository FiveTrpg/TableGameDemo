using System;
using System.Collections.Generic;
using System.Text;

namespace ExplosionCats.Rules.Actions
{
    public struct FavorParam
    {
        public ExplosionCatCharacter OriginalCharactor { get; set; }
        public ExplosionCatCharacter TargetCharactor { get; set; }
        public int Index { get; set; }
    }
}
