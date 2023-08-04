using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class User : IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string profileInfo { get; set; }

        public User()
        {

        }

        public User(int id, string name , string email , string password , string profileInfo)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.profileInfo = profileInfo;
        }

        public override string ToString()
        {
            return "\n ID : " + id + "\n Name : " + name + "\n Email :  " + email + "\n Password : " + password + "\n Profile Info :  " + profileInfo;
        }
    }
}
