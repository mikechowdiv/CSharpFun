namespace RPG.Items.Containers
{
    public class Backpack : Container
    {
        public Backpack() : base(4)
        {
            Name = "A leather backpack";
            Description = "A rugged leather backpack";
            Weight = 1;
            Type = ItemType.Container;
        }
    }
}
