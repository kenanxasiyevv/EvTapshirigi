using System.Text.RegularExpressions;

namespace EvTapshirigi.Models
{
    internal class Teacher : Person
    {
        internal Group[] Groups { get; set; } = new Group[10];

        internal string Subject { get; set; }

        public override string ToString()
        {
            string groups = "";
            foreach (var group in Groups)
            {
<<<<<<< HEAD
                groups += $"{group.Id} {group.Name}\n";
=======
               groups += $"{group.Id} {group.Name}\n";
>>>>>>> 4a33638a3d7aef43b256ff5c22fb9987c25faece
            }

            return $"Id:{Id}\nAd Soyad Fenn:{FirstName} {LastName} {Subject}\nGrouplar:\n{groups}";
        }
    }
}

