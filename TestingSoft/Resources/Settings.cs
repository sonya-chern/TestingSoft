using Aquality.Selenium.Core.Applications;
using Aquality.Selenium.Core.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingSoft.Resources
{
    public static class Settings
    {
        private static readonly ISettingsFile SettingsFile = new Startup().GetSettings();
        public static string Login = SettingsFile.GetValue<string>(".login");
        public static string Password = SettingsFile.GetValue<string>(".password");
    }
}
