using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Instructor
{
    public partial class AddClientForm : Form
    {
        private DatabaseAccess db;
        private string gender = "undefined";
        public AddClientForm()
        {
            InitializeComponent();
            db = new DatabaseAccess();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            client.FirstName = firstNameBox.Text;
            client.LastName = lastNameBox.Text;
            client.Age = int.Parse(ageBox.Text);
            client.Height = float.Parse(heightBox.Text);
            client.Weight = float.Parse(weightBox.Text);
            client.Gender = gender;

            db.insertClient(client);
        }

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";

        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}
