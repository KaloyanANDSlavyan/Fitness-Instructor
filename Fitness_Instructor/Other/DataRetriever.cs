using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_Instructor
{
    class DataRetriever
    {
        private static DataRetriever instance = new DataRetriever();
        private String username;

        private DataRetriever() { }

        public static DataRetriever Instance 
        {
            get { return instance; }
        }

        public String getUsername()
        {
            return username;
        }
        
        public void setUsername(String value)
        {
            username = value;
        }

    }
}
