namespace TableGame.Core.Game.Object
{
    public abstract class GameObject<T> where T : GameSet<T>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public T GameSet { get; set; }

        public GameObject(T gameSet)
        {
            this.GameSet = gameSet;
        }
    }
}
