using System;
using System.Collections.Generic;
using System.Text;

namespace MadlibsGame
{
    class MotorCycle
    {
        public int driverIntensity;
        public string name;

        public MotorCycle(int intensity)
        {
            driverIntensity = intensity;
        }

        public void SetDriverName(string name)
        {
            this.name = name;
        }
    }
}
