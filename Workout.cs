using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Workout : IEntity
    {
        public int id { get; set; }
        public Routine routine { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        public Workout()
        {

        }

        public Workout(int id, Routine routine,string name,string type)
        {
            this.id = id;
            this.routine = routine;
            this.name = name;
            this.type = type;
        }

        public override string ToString()
        {
            return "\n Id : " + id + " \n Routine : " + routine + "\n Name : " + name + "\n Type : " + type;
        }
    }
}
