using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class WorkoutRepository : AbstractRepository<Workout>
    {
        public void Edit(Workout workout)
        {
            foreach(Workout w in ShowAll())
            {
                if(w.id == workout.id)
                {
                    w.routine = workout.routine;
                    w.name = workout.name;
                    w.type = workout.type;
                }
            }
        }
    }
}
