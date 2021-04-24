using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace Fitness_Instructor
{
    class DatabaseAccess
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
