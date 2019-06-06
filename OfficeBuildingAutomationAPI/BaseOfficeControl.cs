using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeBuildingAutomationAPI
{
    public class BaseOfficeControl
    {
        protected internal Office[] Offices = null;

        public BaseOfficeControl(Office[] offices)
        {
            Offices = offices;
        }

        public virtual void LightToggleButton_Press()
        {
            foreach (Office office in Offices)
            {
                office.ToggleLights();
            }
        }

        public virtual void SecuritySystemToggleButton_Press()
        {
            foreach (Office office in Offices)
            {
                office.ToggleSecuritySystem();
            }
        }

        private protected void LogInfo(string line)
        {
            Console.WriteLine(line);
        }

    }
}
