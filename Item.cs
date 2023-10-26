using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project_DASA
{
    internal class Item
    {
        private string name_Item;
        private Image image_Item;
        private DateTime nsx;
        private DateTime hsd;
        private DateTime nnk;
        private int quantity;
        private decimal price;
        private string info;

        public Item(string name, Image image, int quantity, decimal price, string info)
        {
            Name_Item = name;
            Image_Item = image;
            Quantity = quantity;
            Price = price;
            Info = info;
        }
        public Item(string name, Image image, DateTime nsx, DateTime hsd, DateTime nnk, int quantity, decimal price, string info)
        {
            Name_Item = name;
            Image_Item = image;
            Nsx = nsx;
            Hsd = hsd;
            Nnk = nnk;
            Quantity = quantity;
            Price = price;
            Info = info;
        }
        public Item(string name, DateTime nsx, DateTime hsd, DateTime nnk, int quantity, decimal price, string info)
        {
            Name_Item = name;
            Nsx = nsx;
            Hsd = hsd;
            Nnk = nnk;
            Quantity = quantity;
            Price = price;
            Info = info;
        }

        public string Name_Item { get => name_Item; set => name_Item = value; }
        public Image Image_Item { get => image_Item; set => image_Item = value; }
        public DateTime Nsx { get => nsx; set => nsx = value; }
        public DateTime Hsd { get => hsd; set => hsd = value; }
        public DateTime Nnk { get => nnk; set => nnk = value; }
        public int Quantity { get => quantity; set { if (value >= 0) quantity = value; } }
        public string Info { get => info; set => info = value; }
        public decimal Price { get => price; set => price = value; }
    }
}
