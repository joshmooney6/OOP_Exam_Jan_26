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
    // class is abstract so the abstract method below stops shooting errors
    public abstract class Class1
    {


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
    }
}
