using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_411.Controller
{
    public class CartObject
    {
        int _quantity;
        Product _obj;

        public CartObject(int quantity, Product obj)
        {
            _quantity = quantity;
            _obj = obj;
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
   
        }

        public Product Object
        {
            get
            {
                return _obj;
            }
        }
    }
}