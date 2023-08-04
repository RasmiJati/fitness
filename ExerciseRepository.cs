using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class ExerciseRepository : AbstractRepository<Exercise>
    {
        public void Edit(Exercise exercise)
        {
            foreach(Exercise e in ShowAll())
            {
                if(e.id == exercise.id)
                {
                    e.name = exercise.name;
                    e.type = exercise.type;
                }
            }
        }
    }
}
