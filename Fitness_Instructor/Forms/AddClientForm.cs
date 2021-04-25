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
            client.Gender = genderCheckBox.Text;

            db.insertClient(client);
        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genderCheckBox.CheckState == CheckState.Checked)
            {
                genderCheckBox.Text = "Male";
            }
            else if (genderCheckBox.CheckState == CheckState.Unchecked)
            {
                genderCheckBox.Text = "Female";
            }
            else
            {
                genderCheckBox.Text = "undefined";
            }
        }
    }
}
