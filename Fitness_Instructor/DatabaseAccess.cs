using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Fitness_Instructor
{
    class DatabaseAccess
    {
        private String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Study related\VS Projects\Fitness_Instructor\Fitness_Instructor\FSDatabase.mdf;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;

        public DatabaseAccess()
        {
            connection = new SqlConnection(conString);
        }

        public void insertClient(Client client)
        {
            String query = "insert into Clients values(N'" + client.FirstName + "',N'" + client.LastName + "','"
                + client.Age.ToString() + "','" + client.Height.ToString() + "','" + client.Weight.ToString() + "','" + client.Gender + "')";
            command = new SqlCommand(query, connection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Успешно добавен клиент!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Нещо са прееба брат");
            }
        }

    }
}
