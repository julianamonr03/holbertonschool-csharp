using System;

namespace InventoryLibrary
{
    /// <summary>
    /// This is the Item for the inventory management.
    /// </summary>
    public class Item : BaseClass
    {
        string name;
        string description;
        float price;
        list<string> tags = new list<string>("Item");

        /// <summary>
        /// Class Constructor.
        /// </summary>
        public Item(string name = "Item_Name", string description = "Item_Description", float price = 0.0f)
        {
            this.name = name;
            this.description = description;
            this.price = Math.Round(price, 2);
        }
    }
}
