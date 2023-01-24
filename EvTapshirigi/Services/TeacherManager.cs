using EvTapshirigi.Models;
using EvTapshirigi.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvTapshirigi.Services
{
    internal class TeacherManager : ICrudService, IPrintService
    {
        private Teacher[] _teachers = new Teacher[50];
        private int _currentIndex;
        public void Add(Entity entity)
        {
            if (_currentIndex > 50)
            {
                Console.WriteLine("Limiti kecdiniz max 50 muellim elave etmek olar");
                return;
            }
            _teachers[_currentIndex++] = (Teacher)entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Entity[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            foreach (var item in _teachers)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item.ToString());

            }
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
