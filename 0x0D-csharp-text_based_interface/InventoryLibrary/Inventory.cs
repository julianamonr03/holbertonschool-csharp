using System;

namespace InventoryLibrary
{
    /// <summary>
    /// This is the Inventary for the inventory management.
    /// </summary>
    public class Inventory : BaseClass
    {
        string user_id;
        string item_id;
        int quantity;

        /// <summary>
        /// Class Constructor.
        /// </summary>
        public Inventory(string user_id = "User_Id", string item_id = "Item_Id", int quantity = 1)
        {
            if (quantity < 0)
                quantity = 1;

            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
        }
    }
}
