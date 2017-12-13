using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Template
{
    public class TemplateAutoRun : DesignPaternAutoRun.IAutoRun
    {
        public void Run()
        {
            Template.AutomotiveRobot automotiveRobot = new AutomotiveRobot("Automotive Robot");
            Console.WriteLine("Name's robot: " + automotiveRobot.GetName());
            automotiveRobot.Go();
            Template.CookieRobot cookieRobot  = new CookieRobot("Cookie Robot");
            Console.WriteLine("Name's robot: " + cookieRobot.GetName());
            cookieRobot.Go();
            Console.ReadLine();
        }
    }
}
