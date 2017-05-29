namespace RPG.Items.Potions
{
    public class HealthPotion : Item
    {
        public HealthPotion()
        {
            Name = "A health potion";
            Description = "Red fizzy liquid";
            Weight = 1;
            Type = ItemType.Potion;
        }
    }
}
