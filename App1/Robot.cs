using Microsoft.UI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.System;

namespace App1
{
    class Class1
    {
        public enum HouseholdSkill { Cooking, Cleaning, Laundry, Gardening, ChildCare }
        public enum DeliveryMode { Walking, Driving, Flying }

        //properties
        public string robotname { get; set; }
        public double powercapacityKWH { get; set; }
        public double currentpowerKWH { get; set; }
        public string robottype { get; set; }

        //methods
        public double GetBatteryPercentage()
        {
            int batteryLevel = 100;
            return batteryLevel;
        }
        public string DisplayBatteryInformation()
        {
            return "Capacity: " + powercapacityKWH + "Current Power: " + currentpowerKWH + "Battery Level: " + GetBatteryPercentage() + "%";
        }
        public abstract string DescribeRobot();


        public override string ToString()
        {
            return robotname + " - [" + robottype + "]";
        }

        public class HouseholdRobot
        {
            public string household;

            public int RobotType
            {
                get
                {
                    return Rob.robottype;
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

        class DeliveryRobot
        {


        }
    }

    class HouseholdRobot
    {
        public string household;

        public int RobotType
        {
            get
            {
                return .robottype;
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
