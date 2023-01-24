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
                groups += $"{group.Id} {group.Name}\n";
            }

            return $"Id:{Id}\nAd Soyad Fenn:{FirstName} {LastName} {Subject}\nGrouplar:\n{groups}";
        }
    }
}

