using System;
using System.Collections.Generic;
using System.Text;

namespace eCommercePlatform
{
    class Product
    {

        //member variables

        int uniqueIdentifier;
        string name;
        string category;
        double price;
        double averageRating;
        List<Review> review;

        public Product()
        {

        }
    }
}
