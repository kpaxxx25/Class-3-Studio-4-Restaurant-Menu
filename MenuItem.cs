using System;
using System.Collections.Generic;
using System.Text;

namespace Class_3_Studio_4_Restaurant_Menu
{
    class MenuItem
    {
        public decimal Price { get; set; }
        private String[] Category = new String[3] { "appetizer", "main course", "dessert" };
        public String Description { get; set; }
        private bool NewItem = false;
    }
}

/*

menuItems (int price, string, description)
    price = decimal
    description = string
    category (app, main, dessert) = array
    new = bool
*/