using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**************************************
 * Name: Elisabeth Feeley
 * Date: 7/7/2012
 * Assignment: HW2-2_EKF
 * Resources: N/A
 * ***********************************/

namespace HW2_2_EKF
{
    class TestSpaceShip
    {
        static void Main(string[] args)
        {

            SpaceShip ss1 = new SpaceShip();

            ss1.setRocketType("Starship Enterprise");
            ss1.setWingSpan("75 Feet");
            ss1.setMissileType("Blasters");
            ss1.setHelp("They don't need help, they are that awesome.");

            Console.WriteLine(ss1.takeOff());

            Console.ReadLine();

            Console.WriteLine(ss1.land());

            Console.ReadLine();

            Console.WriteLine(ss1.fire());

            Console.ReadLine();

            Console.WriteLine(ss1.takeDamage());

            Console.ReadLine();
        }
    }
}
