using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeBuildingAutomationAPI
{
    public class TestOfficeControl
    {
        private BaseOfficeControl _officeControl = null;

        public TestOfficeControl(BaseOfficeControl officeControl)
        {
            _officeControl = officeControl;
        }

        public void LightToggleButton_Press()
        {
            Console.WriteLine("Testing light toggle button...\n");

            _officeControl.LightToggleButton_Press();
            LogLightingTestStatus();
        }
        public void SecuritySystemToggleButton_Press()
        {
            Console.WriteLine("Testing security toggle button...\n");

            _officeControl.SecuritySystemToggleButton_Press();
            LogSecurityTestStatus();
        }

        private void LogLightingTestStatus()
        {
            Console.WriteLine("Test Offices: " + GetTestOfficesAsString());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Light toggle test passed");
            Console.ResetColor();

        }

        private void LogSecurityTestStatus()
        {
            Console.WriteLine("Test Offices: " + GetTestOfficesAsString());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Security toggle test passed");
            Console.ResetColor();
        }

        private string GetTestOfficesAsString()
        {
            string officeIds = String.Empty;

            foreach (Office office in _officeControl.Offices)
            {
                officeIds += office.OfficeId.ToString() + ",";
            }

            return officeIds.TrimEnd(',');

        }

    }
}
