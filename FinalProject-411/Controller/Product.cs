using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_411.Controller
{
    public class Product
    {
        string _productType;
        int _productID;
        string _title;
        double _price;

        public string ProductType
        {
            get
            {
                return _productType;
            }

            set
            {
                _productType = value;
            }
        }

        public int ProductID
        {
            get
            {
                return _productID;
            }
            set
            {
                _productID = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        
        public double CalcDiscountPercentage (int quantity)
        {
            double discount;

            if (quantity < 2)
            {
                discount = 0;
            }
            else if (quantity >= 2 && quantity <= 4)
            {
                discount = .02;
            }
            else
                discount = .05;

            return discount;
        }

    }
}