using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanEnumApp.Model
{
    public class Human
    {
        private string _name;
        private float _height;
        private float _weight;
        private GenderType _gender;

        public Human(string name, float height, float weight, GenderType gender)
        {
            _name = name;
            _height = height;
            _weight = weight;
            _gender = gender;
        }

        public void Eat()
        {

            _weight += _weight * 20 / 100;


        }


        public void Workout()
        {
            _weight -= _weight * 10 / 100;
            _height += _height * 5 / 100;

        }

        public string GetHumanName()
        {
            return _name;
        }
        public float GetHumanHeight()
        {
            return _height;
        }
        public float GetHumanWeight()
        {
            return _weight;
        }
        public GenderType GetHumanGender()
        {
            return _gender;
        }
    }
}
