using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class ProgressRepository : AbstractRepository<Progress>
    {
        public void Edit(Progress progress)
        {
            foreach(Progress p in ShowAll())
            {
                if(p.id == progress.id)
                {
                    p.user = progress.user;
                    p.bodyPart = progress.bodyPart;
                    p.measurementType = progress.measurementType;
                    p.measurementValue = progress.measurementValue;
                }
            }
        }
    }
}
