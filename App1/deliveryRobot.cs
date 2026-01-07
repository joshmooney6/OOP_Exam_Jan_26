using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App1.MainWindow;

namespace App1
{
    public class DeliveryRobot
    {
        public string ModeOfDelivery = Enum DeliveryMode {Walking, Driving, Flying};

        public double MaxLoadKG = 100.00;

        override public string DescribeRobot()
        {
            return "I am a Delivery Robot\n\nI specialise in delivery by flying\nThe maximum load i can carry is" + MaxLoadKG + "KG\n\n" + Robot.DisplayBatteryInformation();
        }
    }
}

