using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    internal class Plane:Vehical
    {
        protected string cityFrom;
        protected string cityTo;

        public Plane(double maxSpeed1, double curSpeed1, string from,string to) : base(maxSpeed1, curSpeed1)
        {
            cityFrom = from;
            cityTo = to;
        }

        public override void SpeedUp()
        {
            if (curSpeed + 40 < maxSpeed)
            {
                curSpeed += 40;
            }
            else curSpeed = maxSpeed;
        }
        public override void SpeedDown()
        {
            if (curSpeed - 40 >= 0)
            {
                curSpeed -= 40; ;
            }
            else curSpeed = 0;
        }
        
        public override string ToString()
        {
            return $"Самолет летит из {cityFrom}  в {cityTo}, макс. скорость {maxSpeed}, текущая скорость {curSpeed}";
        }
    }
}
