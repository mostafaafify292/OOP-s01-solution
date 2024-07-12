using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s01
{
    internal struct person
    {
        private string name;
        private int age;

        public person(string _name, int _Age)
        {
            name = _name;
            age = _Age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        public override string ToString()
        {
            return $"[ Name : {Name} , Age : {Age} ]";
        }

    }
}
