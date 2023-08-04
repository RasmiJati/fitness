using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Exercise : IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        public Exercise()
        {

        }

        public Exercise(int id, string name, string type)
        {
            this.id = id;
            this.name = name;
            this.type = type;
        }

        public override string ToString()
        {
            return "\n Id :" + id + "\n Name : " + name + "\n Type : " + type;
        }
    }
}
