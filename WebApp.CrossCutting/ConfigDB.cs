using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.CrossCutting
{
    public class ConfigDB
    {
        public static void Register()
        {
            new WebApp.Entity.SQLiteConfiguration();
        }
    }
}
