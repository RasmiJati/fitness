using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class RoutineRepository
    {
        List<Routine> list;

        public RoutineRepository()
        {
            list = new List<Routine>();
        }

        public void Create(Routine routine)
        {
            list.Add(routine);
        }

        public List<Routine> ShowAll()
        {
            return this.list;
        }

        public Routine ShowById(int id)
        {
            foreach(Routine r in list)
            {
                if(r.id == id)
                {
                    return r;
                }
            }
            return null;
        }

        public void Delete(Routine routine)
        {
            list.Remove(routine);
        }

        public void Edit(Routine routine)
        {
            foreach(Routine r in list)
            {
                r.user = routine.user;
                r.startTime = routine.startTime;
                r.endTime = routine.endTime;
                r.sets = routine.sets;
                r.reps = routine.reps;
            }
        }

    }
}
