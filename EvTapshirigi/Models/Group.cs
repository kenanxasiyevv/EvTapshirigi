namespace EvTapshirigi.Models
{
    internal class Group
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}

