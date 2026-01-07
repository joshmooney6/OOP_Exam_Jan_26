using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class HouseholdRobot
    {
        public string household;

        public int RobotType
        {
            get
            {
                return ro.robottype;
            }
            set
            {
                this._employeeNumber = value;
            }

        }

        override public string DescribeRobot()
        {
            return { "I am a Household Robot\n"}
            ;
        }
    }
}
