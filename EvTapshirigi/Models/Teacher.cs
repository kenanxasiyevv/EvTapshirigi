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
                groups += $"\n{group.Id} {group.Name}";
            }

            return $"{Id} {FirstName} {LastName} {Subject}\n Groups:\n{groups}";
        }
    }
}

