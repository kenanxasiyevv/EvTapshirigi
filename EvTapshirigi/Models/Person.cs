using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvTapshirigi.Models
{
    internal class Person : Entity
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string FatherName { get; set; }
        internal int Age { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {FatherName}";
        }

    }
    internal class Department : Person
    {
        Teacher[] Teachers { get; set; } = new Teacher[50];
        internal string Leader { get; set; }

        public override string ToString()
        {
            string printInfo = "";

            foreach (var item in Teachers)
            {
                if (item == null)
                    continue;

                printInfo += item.ToString() + "\n";
            }
            return $"{Leader} \n Teachers:\n{printInfo}";
        }
    }
}

