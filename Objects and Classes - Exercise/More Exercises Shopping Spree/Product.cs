namespace More_Exercises_Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class Product
    {
        private string productName;
        private double price;


        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
