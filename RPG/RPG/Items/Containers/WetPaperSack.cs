namespace RPG.Items.Containers
{
    public class WetPaperSack : WeightRestrictedContainer
    {
        public WetPaperSack() : base(8, 3)
        {
            Name = "Wet Paper Sack";
            Description = "Damp and flimsy";
            Weight = 1;

            Type = ItemType.Container;
        }
    }
}
