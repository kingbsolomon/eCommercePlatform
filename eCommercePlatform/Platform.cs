using System;
using System.Collections.Generic;
using System.Text;

namespace eCommercePlatform
{
    class Platform
    {
        //member variables

        List<Product> inventory;

        //constructor

        public Platform()
        {
            inventory = new List<Product>();
        }

        private Product CreateProduct(int uniqueIdentifier, string name, string category, double price)
        {
            Product product = new Product(uniqueIdentifier, name, category, price);
            return product;
        }

        private void PopulateInventory(Product product)
        {
            inventory.Add(product);
        }

        //member methods

    }
}
