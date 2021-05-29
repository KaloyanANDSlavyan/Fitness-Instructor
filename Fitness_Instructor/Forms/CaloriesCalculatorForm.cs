using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Instructor
{
    public partial class CaloriesCalculatorForm : Form
    {
        private int clientId;
        private Client client;
        private double BMR;
        private double calories;
        private double BMI;
        private DatabaseAccess databaseAccess;

        public CaloriesCalculatorForm()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
        }

        private void caloriesButton_Click(object sender, EventArgs e)
        {
            if(client == null)
            {
                MessageBox.Show("Please double click a row.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else { 
            calcCalories(client);
                calcBMI(client);
            if (gainRadioButton.Checked == true)
                calories += 500;
            else if (loseRadioButton.Checked == true)
                calories -= 500;
                BMI = calcBMI(client);
                BMI = Math.Round(BMI, 2);
            databaseAccess.updateCaloriesBMI(calories, BMI, clientId);
            dataGridView1.DataSource = databaseAccess.outputClients();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            client = new Client();
            clientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            client.Age = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            client.Height = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

            client.Weight = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            client.Gender = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
          
           
        }
        private double formulaGetter(float weight, float height, int age, bool genderFlag)
        {
            if(genderFlag)
                return 10 * weight + 6.25 * height - 5 * age + 5;

            return 10 * weight + 6.25 * height - 5 * age -161;
        }
        

        private double calcBMR(Client client)
        {
           
            if (client.Gender == "Male")
            {
                BMR = formulaGetter(client.Weight, client.Height, client.Age, true);
           
            }else
            {
                BMR = formulaGetter(client.Weight, client.Height, client.Age, false);
            }
           
            return BMR;
        }

        private double calcBMI(Client client)
        {
           
            return client.Weight / (client.Height * client.Height / 10000);
        }

        private void calcCalories(Client client) 
        {
          
            if (comboBox1.SelectedIndex == 0)
                calories = calcBMR(client);
            else if (comboBox1.SelectedIndex == 1)
                calories = calcBMR(client) * 1.375;
            else if (comboBox1.SelectedIndex == 2)
                calories = calcBMR(client) * 1.55;
            else if (comboBox1.SelectedIndex == 3)
                calories = calcBMR(client) * 1.725;
            else
                calories = calcBMR(client) * 1.9;

        }


        private void CaloriesCalculatorForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = databaseAccess.outputClients();
            comboBox1.Items.Add("Sedentary (little or no exercise)");
            comboBox1.Items.Add("Lightly active (light exercise/sports 1-3 days/week)");
            comboBox1.Items.Add("Moderate (exercise/sports 3-5 days/week)");
            comboBox1.Items.Add("Very active (exercise/sports 6-7 days/week)");
            comboBox1.Items.Add("Extra active (physical job or 2x per day training)");
            comboBox1.SelectedIndex = 0;
            maintainRadioButton.Checked = true;
        }
    }
}
