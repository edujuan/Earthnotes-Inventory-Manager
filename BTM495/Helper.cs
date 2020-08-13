using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM495
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            //looks ups connection in the name variable and returns a string
            //grabs connectionString from App.config
        }
    }
}
