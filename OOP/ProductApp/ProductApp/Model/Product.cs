using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    class Product
    {
        int _id;
        string _name;
        double _price;
        float _discountpercent;
        double _finalprice;
       static int _instancecount=0;
       
        public Product (int pid, string pname, double pprice)
        {
            _id = pid;
            _name = pname;
            _price = pprice;
            _instancecount += 1;

        }

        public Product (int pid, string pname,double pprice,float pdiscountpercent)
        {
            _id = pid;
            _name = pname;
            _price = pprice;
            _discountpercent = pdiscountpercent;
            _instancecount += 1;

        }
        public int GetProductId()
        {
            return _id;
        }
        public string GetProductName()
        {
            return _name;
        }
        public double GetProductPrice()
        {
            return _price;
        }
        public float GetProductDiscountPercent()
        {

            return _discountpercent;
        }
        public double GetFinalPrice()
        {
            double discount = _price * _discountpercent / 100;
            _finalprice = _price - discount;
            return _finalprice;
            
        }
        public int GetInstanceCount()
        {
            return _instancecount;
        }
    }
}
