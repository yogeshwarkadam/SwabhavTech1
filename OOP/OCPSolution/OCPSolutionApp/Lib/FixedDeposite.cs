using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp.Lib
{
    class FixedDeposite
    {
        private string _name;
        private double _amount;
        private int _duration;
        private IFestivalPolicy _festival;
        private double _rate;
        private double _SimpleInterest;

        public FixedDeposite(string name, double amount, int duration, IFestivalPolicy festival)
        {
            this._name = name;
            this._amount = amount;
            this._duration = duration;
            this._festival = festival;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double amount
        {
            get
            {
                return _amount;
            }
        }
        public int duration
        {
            get
            {
                return _duration;
            }
        }
        public IFestivalPolicy Festival
        {
            get
            {
                return _festival;
            }
        }

        public double SimpleInterest()
        {
            return _amount * _duration * _festival.CalculateRate();
        }
    }
}
