using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class LineItem
    {
        string _productname;
        double _price;
        int _quantity;

        public LineItem(string pproductname, double pprice, int pquantity)
        {
            _productname = pproductname;
            _price = pprice;
            _quantity = pquantity;
        }

        public string GetName
        {
            get
            {
                return _productname;
            }
        }


        public double GetPrice
        {
            get
            {
                return _price;
            }
        }


        public int GetQuantity
        {
            get
            {
                return _quantity;
            }
        }

        public double TotalPrice()
        {
            double totalPrice = _quantity * _price;
            return totalPrice;
        }
        





    }
}
