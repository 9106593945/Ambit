using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambit.Common
{
    public class PermissionAccess
    {
        public PermissionAccess()
        {
            this.admin = new Admin();  
        }

        public Admin admin;
        
        public class Admin
        {
            public bool Dashboard_Dashboard_AllowViewAccess { get; set; }
            public bool Dashboard_Dashboard_AssignResponder { get; set; }
            public bool RoamingStaff_RoamingStaff_AllowViewAccess { get; set; }
            public bool RoamingStaff_RoamingStaff_AddEditRoamingStaff { get; set; }
            public bool AdminStaff_AdminStaff_AllowViewAccess { get; set; }
            public bool AdminStaff_AdminStaff_AddEditAdminStaff { get; set; }
            public bool SosType_SosType_AllowViewAccess { get; set; }
            public bool SosType_SosType_AddEditSosType { get; set; }
            public bool Customer_Customer_AllowViewAccess { get; set; }
            public bool Customer_Customer_AddEditCustomer { get; set; }
            public bool SOS_SOS_AllowViewAccess { get; set; }
            public bool SOS_SOS_AssignResponder { get; set; }
            public bool Plan_Plan_AllowViewAccess { get; set; }
            public bool Plan_Plan_AddEditPlan { get; set; }
            public bool Setting_Setting_AllowViewAccess { get; set; }
            public bool Setting_Setting_AddEditSetting { get; set; }
            public bool Role_Role_AllowViewAccess { get; set; }
            public bool Role_Role_AddEditRole { get; set; }
            public bool SOS_SOS_SOSClose { get; set; }
            public bool ServiceProvider_ServiceProvider_AllowViewAccess { get; set; }
            public bool ServiceProvider_ServiceProvider_AddEditServiceProvider { get; set; }

        }
    }
}
