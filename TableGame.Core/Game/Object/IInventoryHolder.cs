namespace TableGame.Core.Game.Object
{
    public interface IInventoryHolder<TGameSet, TGameObject>
        where TGameSet : GameSet<TGameSet>
        where TGameObject : GameObject<TGameSet>
    {
        public Inventory<TGameSet, TGameObject> Inventory { get; set; }
    }
}
