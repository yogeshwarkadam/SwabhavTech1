using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    public class Inventory
    {
        private IList<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }
        public void addGuitar(string serialnumber, string builder, string model, string type, string backwood, string topwood, double price)
        {
            Guitar guitar = new Guitar(serialnumber, builder, model, type, backwood, topwood, price);
            guitars.Add(guitar);
        }
        public Guitar GetGuitar(string serialnumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.GetSerialNumber().Equals(serialnumber))
                {
                    return guitar;
                }
            }
            return null;
        }
        public Guitar Search(Guitar searchGuitar)
        {
            foreach (var guitar in guitars)
            {
                string serialnumber = searchGuitar.GetSerialNumber();
                if ((serialnumber != null) && (!serialnumber.Equals("")) && (!serialnumber.Equals(guitar.GetSerialNumber()))) ;

                String builder = searchGuitar.GetBuilder();
                if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(guitar.GetBuilder())))
                    continue;

                string model = searchGuitar.GetModel();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.GetModel())))
                    continue;

                string type = searchGuitar.GetType();
                if ((type != null) && (!searchGuitar.Equals("")) &&
                 (!type.Equals(guitar.GetType())))
                    continue;

                string backWood = searchGuitar.GetBackWood();
                if ((backWood != null) && (!backWood.Equals("")) && (!backWood.Equals(guitar.GetBackWood())))
                    continue;

                String topWood = searchGuitar.GetTopWood();
                if ((topWood != null) && (!topWood.Equals("")) && (!topWood.Equals(guitar.GetTopWood())))
                    continue;



                return guitar;

            }
            return null;
        }

        internal string GetSerialNumber()
        {
            throw new NotImplementedException();
        }

        internal string GetBuilder()
        {
            throw new NotImplementedException();
        }

        internal string GetModel()
        {
            throw new NotImplementedException();
        }
    }
}
