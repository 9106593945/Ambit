using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace AmbitWebAPI.Helper
{
    public static class HelperVariables
    {
        public static string Secret = ConfigurationManager.AppSettings["SecureKey"];
    }
}