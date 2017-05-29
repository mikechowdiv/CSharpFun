namespace RPG.Items.Containers
{
    public class PotionSatchel : SpecificContainer
    {
        public PotionSatchel() : base(4, ItemType.Potion)
        {

        }

        //public override bool AddItem(Item itemToAdd)
        //{
        //    if(itemToAdd.Type == "Potion")
        //    {
        //        return base.AddItem(itemToAdd);
        //    }

        //    return false;
        //}
    }
}
