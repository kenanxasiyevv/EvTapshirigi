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
        public void Add(Entity entity,Entity entity1)
        {
            if (_currentIndex > 49)
            {
                Console.WriteLine("Limiti kecdiniz max 50 muellim elave etmek olar");
                return;
            }
            _teachers[_currentIndex++] = (Teacher)entity;
            _teachers[_currentIndex++] = (Teacher)entity1;
        }

        public void Delete(int id)
        {
            bool find = false;
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null)
                    continue;

                if (id == _teachers[i].Id)
                {
                    find = true;

                    for (int j = i; j < _teachers.Length - 1; j++)
                    {
                        _teachers[j] = _teachers[j + 1];
                    }
                    _currentIndex--;
                    Console.WriteLine($"{id} id-li muellim silindi!!");
                    return;
                }
            }
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null)
                    continue;

                if (id == _teachers[i].Id)
                {
                   Console.WriteLine(_teachers[i]);
                    return _teachers[i];
                }
            }
            Console.WriteLine("Not Found!!");
            return null;
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
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null)
                    continue;

                if (_teachers[i].Id == id)
                {
                    _teachers[i] = (Teacher)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");
                    return;
                }
            }
            Console.WriteLine("Not Found!!");
        }
    }
}
