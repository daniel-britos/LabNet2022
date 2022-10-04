using EntityFramework.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic
{
    public interface ILogicABM<T>
    {
        List<T> GetAll();
        void Add(T newParameter);
        void Update(T parameter);
        void Delete(int id);
        void Search(int id);
    }
}
