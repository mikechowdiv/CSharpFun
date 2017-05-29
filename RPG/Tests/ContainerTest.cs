using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPG.Items.Containers;
using RPG.Items.Potions;
using RPG.Items;
using RPG.Items.Weapons;

namespace Tests
{
    [TestFixture]
    public class ContainerTest
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            AddItemStatus actual = b.AddItem(p);
            Assert.AreEqual(AddItemStatus.Success, actual);
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            Backpack b = new Backpack();
            GreatAxes axe = new GreatAxes();
            b.AddItem(axe);
            b.AddItem(axe);
            b.AddItem(axe);
            b.AddItem(axe);

            AddItemStatus actual = b.AddItem(axe);
            Assert.AreEqual(AddItemStatus.BagIsFull, actual);
        }

        [Test]
        public void CanRemoveItemFromBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            b.AddItem(p);
            Item actual = b.RemoveItem();

            //do these two variables reference the same object?
            Assert.AreEqual(p, actual);
        }

        [Test]
        public void EmptyBagReturnsNull()
        {
            Backpack b = new Backpack();
            Item item = b.RemoveItem();
            Assert.IsNull(item);
        }

        [Test]
        public void PotionSatchelOnlyAllowPotion()
        {
            PotionSatchel ps = new PotionSatchel();
            GreatAxes axe = new GreatAxes();

           AddItemStatus result = ps.AddItem(axe);
            Assert.AreEqual(AddItemStatus.ItemNotRgihtType, result);

            HealthPotion potion = new HealthPotion();
            result = ps.AddItem(potion);
            Assert.AreEqual(AddItemStatus.Success, result);
        }

        [Test]
        public void WeightRestrictedBag()
        {
            WetPaperSack wps = new WetPaperSack();
            HealthPotion hp = new HealthPotion();

            Assert.AreEqual(AddItemStatus.Success, wps.AddItem(hp));

            GreatAxes axe = new GreatAxes();
            Assert.AreEqual(AddItemStatus.ItemTooHeavy, wps.AddItem(axe));

            Item item = wps.RemoveItem();
            Assert.AreEqual(AddItemStatus.Success, wps.AddItem(axe));
        }
    }
}
