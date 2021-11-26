using GuitarApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    public class Guitar
    {
        private string _serialNumber;
        private string _builder;
        private string _model;
        private string _type;
        private string _backWood;
        private string _topWood;
        private double _price;


        public Guitar(string serialnumber, string builder, string model, string type, string backwood, string topwood, double price)
        {
            this._serialNumber = serialnumber;
            this._builder = builder;
            this._model = model;
            this._type = type;
            this._backWood = backwood;
            this._topWood = topwood;
            this._price = price;
        }



        public String GetSerialNumber()
        {
            return _serialNumber;
        }
        public double GetPrice()
        {
            return _price;
        }
        public string GetBuilder()
        {
            return _builder;
        }
        public string GetModel()
        {
            return _model;
        }
        public new string GetType()
        {
            return _type;
        }
        public string GetBackWood()
        {
            return _backWood;
        }
        public string GetTopWood()
        {
            return _topWood;
        }
        public void setPrice(float newPrice)
        {
            this._price = newPrice;
        }
    }
}
