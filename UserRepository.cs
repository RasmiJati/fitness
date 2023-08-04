using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class UserRepository : AbstractRepository<User>
    {

        public void Edit(User user)
        {
            foreach(User u in ShowAll())
            {
                if (u.id == user.id)
                {
                    u.name = user.name;
                    u.email = user.email;
                    u.password = user.password;
                    u.profileInfo = user.profileInfo;
                    break;
                }
            }
        }
    }
}
