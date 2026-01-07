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
                return Robot.robottype;
            }
            set
            {
                Robot.robottype = "Household Robot";
            }

        }

        public string Skill
        {
            get
            {
                return enum HouseholdSkill { Cooking, Cleaning, Laundry, Gardening, ChildCare }
            }
            set
            {
                enum HouseholdSkill = value;
            }
        }

        override public string DescribeRobot()
        {
            return "I am a Household Robot\nI can help with chores around the house \n\nHousehold Robot Skills: \n" + Skill + "\n\n" + Robot.DisplayBatteryInformation();
        }
    }
}
