using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeBuildingAutomationAPI
{
    public class RemoteDeviceOfficeControl:BaseOfficeControl
    {

        public RemoteDeviceOfficeControl(Office[] offices) : base(offices)
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
                base.LogInfo($"Remote Control Device: Lights for office:{office.OfficeId} is switched {status}.");
            }

            Console.WriteLine();

        }
        private void LogSecurityStatus()
        {
            string status = String.Empty;

            foreach (Office office in base.Offices)
            {
                status = (office.IsSecuritySystemArmed) ? "armed" : "disarmed";
                base.LogInfo($"Remote Control Device: Security for office:{office.OfficeId} is {status}.");
            }

            Console.WriteLine();

        }
    }
}
