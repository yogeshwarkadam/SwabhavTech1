using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp
{
    class FixedDeposite
    {
        private string _name;
        private double _amount;
        private int _duration;
        private FestivalType _festival;
        private double _rate;
        private double _SimpleInterest;

        public FixedDeposite(string name,double amount,int duration,FestivalType festival)
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
        public FestivalType Festival
        {
            get
            {
                return _festival;
            }
        }

        public double SimpleInterest()
        {
            _SimpleInterest = (_amount * CalculateRate() * _duration) / 100;
            return _SimpleInterest;
        }

        public double CalculateRate()
        {
            float interestRate = 7f;
            if (_festival == FestivalType.NEW_YEAR)
            {
                interestRate = 9f;
                return interestRate;
            }
            else if(_festival == FestivalType.EID)
            {
                interestRate = 8.5f;
                return interestRate;
            }
            else if (_festival == FestivalType.DIWALI)
            {
                interestRate = 8f;
                return interestRate;
            }
            else
            {
                return interestRate;
            }

        }

    }
}
