using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace gtsco2.forms.CnxDataBase
{
   public class AppSetting
    {
        Configuration config;
        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        }
        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;

        }
        public void SeveConnectionString(string key, string valeu)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = valeu;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Date.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
