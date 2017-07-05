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
    class SpaceShip
    {
        //Attributes
        private string wingSpan, rocketType, missileType, help;

        //Methods

        public string takeOff()
        {
            return getRocketType() +" with wingspan: " + getWingSpan() + " has taken off.";
        }

        public string land()
        {
            return getRocketType() + " with wingspan: " + getWingSpan() + " has landed.";
        }
        
        public string fire()
        {
            return getMissileType() + " were fired.";
        }


        public string takeDamage()
        {
            return getHelp();
        }
        
        //Gets
        public string getWingSpan()
        {
            return wingSpan;
        }

        public string getRocketType()
        {
            return rocketType;
        }

        public string getMissileType()
        {
            return missileType;
        }

        public string getHelp()
        {
            return help;
        }

        //Sets
        public void setWingSpan(string aWingSpan)
        {
            wingSpan = aWingSpan;
        }

        public void setRocketType(string aRocketType)
        {
            rocketType = aRocketType;
        }

        public void setMissileType(string aMissileType)
        {
            missileType = aMissileType;
        }

        public void setHelp(string ahelp)
        {
            help = ahelp;
        }
    }
}
