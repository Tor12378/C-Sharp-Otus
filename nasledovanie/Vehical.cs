using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    public class Vehical
    {
        protected double maxSpeed = 0;
        protected double curSpeed = 0;
        public virtual void SpeedUp()
        {
            Console.WriteLine("Ускорение");
        }
        public virtual void SpeedDown()
        {
            Console.WriteLine("Торможение");
        }
        public Vehical(double maxSpeed1, double curSpeed1)
        {
            maxSpeed = maxSpeed1;
            curSpeed = curSpeed1;
        }
    }
}
