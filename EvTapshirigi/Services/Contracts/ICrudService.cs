using EvTapshirigi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvTapshirigi.Services.Contracts
{
    internal interface ICrudService
    {
        void Add(Entity entity,Entity entity1);
        void Update(int id, Entity entity);
        void Delete(int id);
        Entity Get(int id);
    }
}
