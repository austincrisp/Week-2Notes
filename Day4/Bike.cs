using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Bike
{
    public class Bike
    {
        public int speed = 0;
        public double speedModifier = 1;
        private int speedLimit = 12;
        public int location = 0;

        public Bike() { }

        public Bike(double _speedModifier, int _speedLimit)
        {
            speedModifier = _speedModifier;
            speedLimit = _speedLimit;
        }

        public int GetSpeed()
        {
            return (int)(speed * speedModifier);
        }

        public double GetSpeedModifier()
        {
            return speedModifier;
        }

        public int GetSpeedLimit()
        {
            return speedLimit;
        }

        public void Accelerate()
        {
            if (speed < speedLimit)
            {
                speed++;
            }
        }

        public void MoveForward()
        {
            location += speed;
        }
    }
}
