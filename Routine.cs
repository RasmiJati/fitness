using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Routine
    {
        public int id { get; set; }
        public User user { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string sets { get; set; }
        public string reps { get; set; }

        public Routine()
        {

        }

        public Routine(int id, User user, DateTime startTime, DateTime endTime, string sets, string reps)
        {
            this.id = id;
            this.user = user;
            this.startTime = startTime;
            this.endTime = endTime;
            this.sets = sets;
            this.reps = reps;
        }

        public override string ToString()
        {
            return "\n Id : " + id + "\n User : " + user + " \n Start Time : " + startTime + " \n End Time :" + endTime + " \n Sets : " + sets + " \n Reps : " + reps;
        }
    }
}
