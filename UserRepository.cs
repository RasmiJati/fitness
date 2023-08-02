using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class UserRepository
    {
        private List<User> list;
        public UserRepository()
        {
            list = new List<User>();
        }

        public void Create(User user)
        {
            list.Add(user);
        }

        public List<User> ShowAll()
        {
            return this.list;

        }

        public User ShowById(int id)
        {
            foreach(User u in list)
            {
                if(u.id == id)
                {
                    return u;
                }
            }
            return null;
        }

        public void Delete(User user)
        {
            list.Remove(user);
        }        
    }
}
