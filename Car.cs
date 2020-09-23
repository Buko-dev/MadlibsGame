using System;
using System.Collections.Generic;
using System.Text;

namespace MadlibsGame
{
    class Car
    {
        //state of car
        public string petName;
        public int currSpeed;
        public string currColor;
        /*To preserve the intergity of your class state, field data should never be public*/

        //constructors
        public Car()
        {
            petName = "Mitchel";
            currSpeed = 10;
            currColor = "Blue";
        }
        public Car(string p)
        {
            petName = p;
        }
        public Car (string p, int speed)
        {
            petName = p;
            currSpeed = speed;
        }

        //the functionality of the car
        public void PrintState()
            => Console.WriteLine("{0} is going {1} mph.", petName, currSpeed);

        public void SpeedUp(int delta)
            => currSpeed += delta;

    }
}
