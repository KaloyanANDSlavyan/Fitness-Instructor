using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Instructor
{
    public partial class LoginForm : Form
    {
        private DatabaseAccess databaseAccess;
        private DataRetriever dataRetriever;

        public LoginForm()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
           DataTable dataTable = databaseAccess.authenticateInstructor(usernameBox.Text.Trim(), passwordBox.Text.Trim());
            if(dataTable.Rows.Count == 1)
            {
                dataRetriever = DataRetriever.Instance;
                dataRetriever.setUsername(usernameBox.Text);
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Entered instructor doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
