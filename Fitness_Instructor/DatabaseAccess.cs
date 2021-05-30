using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace Fitness_Instructor
{
    class DatabaseAccess
    {
        // radko => C:\Users\Rado\Desktop\Fitness Instructor\Fitness-Instructor\Fitness_Instructor\FSDatabase.mdf
        // slavcho => E:\Study related\VS Projects\Fitness_Instructor v2\Fitness-Instructor\Fitness_Instructor\FSDatabase.mdf
        private String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Study related\VS Projects\Fitness_Instructor v2\Fitness-Instructor\Fitness_Instructor\FSDatabase.mdf;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;

        public DatabaseAccess()
        {
            connection = new SqlConnection(conString);
        }

        public object DisplayExercise(int MuscleGroupFK)
        {

            String query = "SELECT * FROM Exercises WHERE Muscle_Group_FK = '" + MuscleGroupFK + "'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }





        public void insertClient(Client client, int fk)
        {
            String query = "insert into Clients (firstName, lastName, age, height, weight, gender, Instructor_FK) values(N'" + client.FirstName + "',N'" + client.LastName + "','"
                + client.Age.ToString() + "','" + client.Height.ToString() + "','" + client.Weight.ToString() + "','" + client.Gender + "','" + fk + "')";
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
                MessageBox.Show("Неуспех");
            }
        }

        public void updateCaloriesBMI(double cals, double BMI, int Id)
        {
            String query = "UPDATE Clients SET calories = '" + cals + "', BMI = '" + BMI + "' WHERE Id = '" + Id + "'";
  
            command = new SqlCommand(query, connection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Успешнa актуализация");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Неуспех");
            }
        }

        public object outputClients(int fk)
        {
            String query = "SELECT * FROM Clients WHERE Instructor_FK = '" + fk + "'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public void deleteClient(int id)
        {
            String query = "DELETE FROM Clients WHERE Id = '" + id + "'";
            command = new SqlCommand(query, connection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Успешно изтрит клиент!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Неуспех");
            }
        }

        public void updateClient(int id, String firstName, String lastName, String age, String height, String weight)
        {
            String query = "UPDATE Clients SET firstName= N'" + firstName + "',lastName= N'" + lastName + "',age='" + age + "',height='" + height + "',weight='" + weight + "' WHERE Id='"+ id + "'";
            command = new SqlCommand(query, connection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Успешно редактиран клиент!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Неуспех");
            }
        }

        public object selectById(int id)
        {
            String query = "SELECT * FROM Clients WHERE Id = '" + id + "'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable selectInstructor(String username, String password)
        {
            String query = "SELECT * FROM Instructors WHERE username = '" + username + "' and password = '" + password + "'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

    }
}
