using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_Instructor
{
    class DataRetriever
    {
        private static DataRetriever instance = new DataRetriever();
        private String username;
        private int clientId;
        private int programId;
        private Client client;
        private FitnessProgram program;

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

        public int getClientId()
        {
            return clientId;
        }

        public void setClientId(int id)
        {
            clientId = id;
        }

        public int getProgramId()
        {
            return programId;
        }

        public void setProgramId(int id)
        {
            programId = id;
        }

        public void setClient(Client obj)
        {
            client = obj;
        }

        public Client getClient()
        {
            return client;
        }

        public void setFitnessProgram(FitnessProgram obj)
        {
            program = obj;
        }

        public FitnessProgram getFitnessProgram()
        {
            return program;
        }

    }
}
