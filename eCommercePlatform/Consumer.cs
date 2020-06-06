using System;
using System.Collections.Generic;
using System.Text;

namespace eCommercePlatform
{
    class Consumer
    {

        //member variables

        string firstName;
        string lastName;
        ShoppingCart shoppingCart;

        public Consumer()
        {
            shoppingCart = new ShoppingCart();
        }

        void SetfirstName (string firstName)
        {
            this.firstName = firstName;
        }

        void SetLastName (string lastName)
        {
            this.lastName = lastName;
        }

        void SearchProduct(Product name)
        {
            //
        }

        void PrintProduct()
        {

        }
    }
}
