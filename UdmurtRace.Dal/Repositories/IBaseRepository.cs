using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3C_
{
    public interface IBaseRepository<T>
    {
        public bool Add(T Item);
        public bool Remove(int id);
        public List<T> GetAll();
        public T? Get(int id);
        public bool Update(T Item);

    }
}
