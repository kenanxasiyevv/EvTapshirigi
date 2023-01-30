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
                    var teacher1 = new Teacher
                    {
                        Id = 1239,
                        FirstName = "Ayxan",
                        LastName = "Memmedov",
                        Subject = "Fizika",
                        Groups = new Group[]
                        {
                                new Group {Id=324, Name = "P213"},
                                new Group {Id=321, Name = "P462"},
                                new Group {Id=354, Name = "P634"},
                                new Group {Id=644, Name = "P943"},
                                new Group {Id=924, Name = "P374"}
                        }

                    };
                    teacherManager.Add(teacher);
                    teacherManager.Add(teacher1);
                    Console.WriteLine("Muellim ugurla elave edildi!");

                }
                else if (command.ToLower().Equals("print teacher"))
                {
                    teacherManager.Print();
                }

                else if ((command.ToLower().Equals("delete teacher")))
                {
                    Console.Write("ID daxil edin : ");
                    var id =int.Parse(Console.ReadLine());

                    teacherManager.Delete(id);

                }
                else if ((command.ToLower().Equals("get teacher")))
                {
                    Console.Write("ID daxil edin: ");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Get(id);
                }
                else if ((command.ToLower().Equals("update teacher")))
                {
                    Console.Write("Id daxil edin: ");
                    var id = int.Parse(Console.ReadLine());

                    var existTeacher = teacherManager.Get(id);

                    var teacher3 = new Teacher
                    {
                        Id = 2335,
                        FirstName = "Kerim",
                        LastName = "Xelilov",
                        Subject = "Informatika",

                        Groups = new Group[]
                        {
                            new Group{Id=853, Name ="P397"},
                            new Group{Id=886, Name ="P235"},
                            new Group{Id=743, Name ="P745"},
                            new Group{Id=346, Name ="P134"}
                        },
                    };
                    teacherManager.Update(id, teacher3);
                }
            } while (!command.ToLower().Equals("quit"));
        }
    }

}
