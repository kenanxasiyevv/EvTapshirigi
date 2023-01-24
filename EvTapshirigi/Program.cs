using EvTapshirigi.Models;
using EvTapshirigi.Services;

namespace EvTapshirigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teacherManager = new TeacherManager();
            string command = "";
            do
            {
                Console.Write("Enter Command: ");
                command = Console.ReadLine();

                if (command.ToLower().Equals("add teacher"))
                {
                    var teacher = new Teacher
                    {
                        Id = 1294,
                        FirstName = "Fariz",
                        LastName = "Bayramov",
                        Subject = "Riyaziyyat",
                        Groups = new Group[]
                        {
                            new Group { Id = 324, Name = "P213" },
                            new Group { Id = 334, Name = "P256" },
                            new Group { Id = 352, Name = "P274" },
                            new Group { Id = 336, Name = "P245" },
                            new Group { Id = 425, Name = "P754" }
                        }
                    };

                    teacherManager.Add(teacher);
                    Console.WriteLine("Muellim ugurla elave edildi!");

                }
                else if (command.ToLower().Equals("print teacher"))
                {
                    teacherManager.Print();
                }
            } while (!command.ToLower().Equals("quit"));
        }
    }
    
}