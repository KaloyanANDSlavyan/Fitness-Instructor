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


        public object outputExercises()
        {
            String query = "SELECT * FROM Exercises";
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

        public int insertClients_Programs(int clientFk, int programFk)
        {
            String query = "insert into Clients_Programs (Client_FK, Program_FK) values('" + clientFk.ToString() + "','" + programFk.ToString() + "'); SELECT SCOPE_IDENTITY()";
            command = new SqlCommand(query, connection);
            int id = 0;
            try
            {
                command.Connection.Open();
                id = Convert.ToInt32(command.ExecuteScalar());
                command.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неуспех");
            }

            return id;
        }

        public void insertClients_Programs_Exercises(int client_ProgramId, int exerciseId, int numOfReps)
        {
            String query = "insert into Clients_Programs_Exercises (Client_Program_FK, Exercise_FK, numOfReps) values('" + client_ProgramId + "','" + exerciseId + "','" + numOfReps + "')";
            command = new SqlCommand(query, connection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

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

        public object outputPrograms()
        {
            String query = "SELECT * FROM Programs";
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

        public DataTable authenticateInstructor(String username, String password)
        {
            String query = "SELECT * FROM Instructors WHERE username = '" + username + "' and password = '" + password + "'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public object outputClientsPrograms(int clientId, int programId)
        {
            String query = "SELECT * FROM Clients_Programs WHERE Client_FK = '" + clientId + "' and Program_FK = '" + programId + "'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public object report(int instructorId)
        {
            String query = @"SELECT cp.Id, c.firstName, p.ProgramName, p.Description
            FROM ((Clients_Programs cp INNER JOIN Clients c
            ON cp.Client_FK = c.Id) INNER JOIN Programs p
            ON cp.Program_FK = p.Id) WHERE c.Instructor_FK = '" + instructorId + "'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public object report2(int id)
        {
            String query = @"SELECT c.firstName, p.ProgramName, e.Name as 'Exercise', numOfReps as 'Repetitions', i.name as 'Instructor'
            FROM ((((( Clients_Programs_Exercises cpe INNER JOIN Exercises e 
            ON cpe.Exercise_FK = e.Id) 
            INNER JOIN Clients_Programs cp ON 
            cpe.Client_Program_FK = cp.Id) 
            INNER JOIN Clients c ON cp.Client_FK = c.Id) 
            INNER JOIN Programs p ON cp.Program_FK = p.Id) 
            INNER JOIN  Instructors i ON 
            c.Instructor_FK = i.Id)
            WHERE Client_Program_FK = '" + id + "'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

    }
}
