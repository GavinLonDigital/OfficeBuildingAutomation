using System;
using System.Collections.Generic;
using System.Text;
using OfficeBuildingAutomationAPI;

namespace OfficeBuildingAutomation
{
    public class AppOfficeControl : BaseOfficeControl
    {

        public AppOfficeControl(Office[] offices) : base(offices)
        {
            LogLightingStatus();
            LogSecurityStatus();
        }

        public override void LightToggleButton_Press()
        {
            base.LightToggleButton_Press();
            LogLightingStatus();
            LogSecurityStatus();
        }

        public override void SecuritySystemToggleButton_Press()
        {
            base.SecuritySystemToggleButton_Press();
            LogLightingStatus();
            LogSecurityStatus();
        }
        private void LogLightingStatus()
        {
            string status = String.Empty;

            foreach (Office office in base.Offices)
            {
                status = (office.IsLightOn) ? "on" : "off";
                Console.WriteLine($"App: Lights for office:{office.OfficeId} is switched {status}.");
            }

            Console.WriteLine();

        }
        private void LogSecurityStatus()
        {
            string status = String.Empty;

            foreach (Office office in base.Offices)
            {
                status = (office.IsSecuritySystemArmed) ? "armed" : "disarmed";
                Console.WriteLine($"App: Security for office:{office.OfficeId} is {status}.");
            }

            Console.WriteLine();

        }
    }
}
