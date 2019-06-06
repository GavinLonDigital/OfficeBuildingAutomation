using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeBuildingAutomationAPI
{
    public class Office
    {
        //In comments below the IsLightOn, IsSecuritySystemArmed and OfficeId
        //public fields are their private member variable counterparts
        //followed by a readonly public property implementation.
        //These readonly public properties can be  
        //implemented to encapsulate these private member variables.

        public bool IsLightOn = false;
        //private bool _isLightOn = false;
        //public bool IsLightOn
        //{
        //    get
        //    {
        //        return _isLightOn;
        //    }
        //}

        public bool IsSecuritySystemArmed = false;
        //private bool _isSecuritySystemArmed = false;
        //public bool IsSecuritySystemArmed
        //{
        //    get
        //    {
        //        return _isSecuritySystemArmed;
        //    }
        //}

        public int OfficeId = 0;
        //private bool _officeId = false;
        //public bool OfficeId
        //{
        //    get
        //    {
        //        return _officeId;
        //    }
        //}

        private OfficeBuildingFakeWebService _officeBuildingFakeWebService = null;
        private int _securityToken = 0;

        public Office()
        {
            _officeBuildingFakeWebService = new OfficeBuildingFakeWebService();
        }

        public void Login(int officeId, string userName, string password)
        {
            _securityToken = _officeBuildingFakeWebService.Login(officeId,userName,password);

            if (_securityToken > 0)
            {
                IsLightOn = _officeBuildingFakeWebService.IsLightOn(_securityToken);
                IsSecuritySystemArmed = _officeBuildingFakeWebService.IsSecuritySystemArmed(_securityToken);
                OfficeId = officeId;
            }
        }

        internal void ToggleLights()
        {
            if (IsLightOn)
            {
                _officeBuildingFakeWebService.SwitchLightsOff(_securityToken);
                IsLightOn = false;
            }
            else
            {
                _officeBuildingFakeWebService.SwitchLightsOn(_securityToken);
                IsLightOn = true;
            }
        }

        internal void ToggleSecuritySystem()
        {

            if (IsSecuritySystemArmed)
            {
                _officeBuildingFakeWebService.DisarmSecuritySystem(_securityToken);
                IsSecuritySystemArmed = false;
            }
            else
            {
                _officeBuildingFakeWebService.ArmSecuritySystem(_securityToken);
                IsSecuritySystemArmed = true;
            }
            

        }

    }
}
