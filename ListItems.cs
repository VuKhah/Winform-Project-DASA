using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project_DASA
{
    public class ListItems
    {
        private static ListItems shop;

        public static ListItems Shop 
        { 
            get 
            { 
                if (shop == null) 
                    shop = new ListItems(); 
                return shop; 
            } 
            set => shop = value; 
        }

        internal List<Item> List_Item { get => list_Item; set => list_Item = value; }

        List<Item> list_Item;     

        private ListItems()     
        {
            List_Item = new List<Item>();
            Item item = new Item("Apple",null, new DateTime(2023, 12, 1), new DateTime(2023, 12, 31), new DateTime(2023, 12, 20), 100, 32, "red apple");
            List_Item.Add(item);
            List_Item.Add(item);
            List_Item.Add(item);
            List_Item.Add(item);
            List_Item.Add(item);
            List_Item.Add(item);
        }
    }
}
