using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    public class Car:Vehical
    {
        protected string townFrom;
        protected string townTo;
        public Car(double maxSpeed1, double curSpeed1, string from, string to) : base(maxSpeed1, curSpeed1)
        {
            townFrom = from;
            townTo = to;
        }

        public override void SpeedUp()
        {
            if (curSpeed + 5 < maxSpeed)
            {
                curSpeed +=5;
            }
            else curSpeed = maxSpeed;
        }
        public override void SpeedDown()
        {
            if (curSpeed - 5 >=0)
            {
                curSpeed -= 5; ;
            }
            else curSpeed = 0;
        }

        public override string ToString()
        {
            return $"Машина,едет из {townFrom}  в {townTo}, макс скорость {maxSpeed}, текущая скорость {curSpeed}";
        }
    }
}
