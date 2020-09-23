using System;

namespace MadlibsGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.petName = "Bingo";
            myCar.currSpeed = 56;

            Car myCar2 = new Car();
            myCar2.PrintState();
            Console.ReadLine();

            Car myCar3 = new Car("Heather");
            myCar3.PrintState();

            Car mycar4 = new Car("Heather-2");
            myCar3.PrintState();



            //Speedup the car a few times and print out the new state
            for (int i=0; i<10; i++) 
            {
                myCar.SpeedUp(6);
                myCar.PrintState();
            }
            //Console.WriteLine("Hello World!");
            Console.ReadLine();

            Console.WriteLine("Hello World!");

        }
    }
}
