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
        private DataRetriever dataRetriever;
        private string gender = "undefined";
        private TextValidator validator;
        public AddClientForm()
        {
            InitializeComponent();
            db = new DatabaseAccess();
            dataRetriever = DataRetriever.Instance;
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
            if(Equals(dataRetriever.getUsername(), "slavcho44"))
                db.insertClient(client, 1);
            else
                db.insertClient(client, 2);
        }

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";

        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void base_Validating(TextBox textBox, string errorMsg, String pattern, CancelEventArgs e)
        {
            validator = new TextValidator(pattern, textBox.Text);
            bool state = validator.regexValidator();

            if (state)
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, errorMsg);
            }
        }

        private void firstNameBox_Validating(object sender, CancelEventArgs e)
        {
            base_Validating(firstNameBox, "Enter valid first name!", @"(^[А-ЯA-Z][а-яa-z]{2,}$)", e);
        }

        private void lastNameBox_Validating(object sender, CancelEventArgs e)
        {
            base_Validating(lastNameBox, "Enter valid last name!", @"(^[А-ЯA-Z][а-яa-z]{2,}$)", e);
        }

        private void ageBox_Validating(object sender, CancelEventArgs e)
        {
            base_Validating(ageBox, "Enter valid age!", @"^\d{0,3}$", e);
        }

        private void heightBox_Validating(object sender, CancelEventArgs e)
        {
            base_Validating(heightBox, "Enter valid height!", @"^\d{0,3}$", e);    // @"(^[1 - 2].[0 - 9]{ 2}$)
        }

        private void weightBox_Validating(object sender, CancelEventArgs e)
        {
            base_Validating(weightBox, "Enter valid weight!", @"^\d{0,3}$", e);
        }
    }
}
