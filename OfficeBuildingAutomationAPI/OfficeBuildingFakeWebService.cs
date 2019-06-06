using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeBuildingAutomationAPI
{
    internal class OfficeBuildingFakeWebService
    {
        private static int _securityToken = 0;

        internal OfficeBuildingFakeWebService()
        {
            _securityToken++;
        }

        internal int Login(int officeId,string userName, string password)
        {
            return _securityToken;
        }

        internal bool IsLightOn(int securityToken)
        {
            return false;
        }

        internal bool IsSecuritySystemArmed(int securityToken)
        {
            return false;
        }

        internal void SwitchLightsOn(int securityToken)
        {
            //Code to switch the lights on goes here
        }

        internal void SwitchLightsOff(int securityToken)
        {
            //Code to switch the lights off goes here
        }

        internal void ArmSecuritySystem(int securityToken)
        {
            //Code to arm the security system goes here
        }

        internal void DisarmSecuritySystem(int securityToken)
        {
            //Code to disarm the security system goes here
        }
    }
}
