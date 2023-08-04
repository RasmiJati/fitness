using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    abstract class AbstractRepository <T> where T : IEntity
    {
       private List<T> list;

            public AbstractRepository()
            {
                list = new List<T>();
            }

            public void Create(T t)
            {
                list.Add(t);
            }

            public List<T> ShowAll()
            {
                return this.list;
            }

            public T ShowById(int id)
            {
                return list.Find(t => t.id == id);
            }

            public void Delete(T t)
            {
                list.Remove(t);
            }

            public void Edit(T t)
            {

            }

        }
    }

