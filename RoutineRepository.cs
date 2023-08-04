using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class RoutineRepository :AbstractRepository<Routine>
    {
        
        public void Edit(Routine routine)
        {
            foreach(Routine r in ShowAll())
            {
                if (r.id == routine.id)
                {
                    r.user = routine.user;
                    r.startTime = routine.startTime;
                    r.endTime = routine.endTime;
                    r.sets = routine.sets;
                    r.reps = routine.reps;
                    break;
                }
            }
        }

    }
}
