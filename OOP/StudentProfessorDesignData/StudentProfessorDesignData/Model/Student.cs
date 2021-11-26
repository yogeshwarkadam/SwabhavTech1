using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDesignData.Model
{
    class Student : Person
    {
        private int _id;
        private string _address;
        private string _DateOfBirth;
        private string _branch;

        public Student(int id, string address, string dateofbirth, string branch) : base(id, address, dateofbirth)
        {
            this._id = id;
            this._address = address;
            this._DateOfBirth = dateofbirth;
            this._branch = branch;
        }
        public int id
        {
            get
            {
                return _id;
            }
        }
        public string address
        {
            get
            {
                return _address;
            }
        }
        public string dateofbirth
        {
            get
            {
                return _DateOfBirth;
            }
        }
        public string branch
        {
            get
            {
                return _branch;
            }
        }
        public override string ExtraThings()
        {
            Console.WriteLine("Branch: "+branch);
            return string.Empty;
        }
    }

}
