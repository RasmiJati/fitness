using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Progress : IEntity
    {
        public int id { get; set; }
        public User user { get; set; }
        public string bodyPart { get; set; }
        public string measurementType { get; set; }
        public string measurementValue { get; set; }

        public Progress()
        {

        }

        public Progress(int id, User user, string bodypart, string measurementType, string measurementValue)
        {
            this.id = id;
            this.user = user;
            this.bodyPart = bodyPart;
            this.measurementType = measurementType;
            this.measurementValue = measurementValue;
        }

        public override string ToString()
        {
            return "\n Id : " + id + "\n User : "+ user + "\n Body Part :" + bodyPart + "\n Measurement Type : " + measurementType + "\n Measurement Value " + measurementValue;
        }
    }
}
