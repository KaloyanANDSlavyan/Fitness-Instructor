using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Instructor
{
    public partial class EditClientForm : Form
    {
        private int clientId;
        private int age;
        private float height;
        private float weight;
        private Client client;
        private DatabaseAccess databaseAccess;
        private DataRetriever dataRetriever;
        private TextValidator validator;

        public EditClientForm()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
            dataRetriever = DataRetriever.Instance;
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = GetDataGridView();
        }

        private object GetDataGridView()
        {
            if (Equals(dataRetriever.getUsername(), "slavcho44"))
                return databaseAccess.outputClients(1);
            else
                return databaseAccess.outputClients(2);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
           if(String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text) || String.IsNullOrEmpty(ageBox.Text) || String.IsNullOrEmpty(heightBox.Text) || String.IsNullOrEmpty(weightBox.Text))
            {
                MessageBox.Show("Empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                client = new Client();
                client.FirstName = firstNameBox.Text;
                client.LastName = lastNameBox.Text;
                client.Age = int.Parse(ageBox.Text);
                client.Height = float.Parse(heightBox.Text);
                client.Weight = float.Parse(weightBox.Text);
                databaseAccess.updateClient(clientId, client);
                dataGridView.DataSource = GetDataGridView();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
           databaseAccess.deleteClient(clientId);
            dataGridView.DataSource = GetDataGridView();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clientId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            firstNameBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastNameBox.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ageBox.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            
            heightBox.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
    
            weightBox.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

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
            base_Validating(firstNameBox, "Invalid format", @"(^[А-ЯA-Z][а-яa-z]{2,}$)", e);
        }

        private void lastNameBox_Validating(object sender, CancelEventArgs e)
        {
            base_Validating(lastNameBox, "Invalid format", @"(^[А-ЯA-Z][а-яa-z]{2,}$)", e);
        }

        private void ageBox_Validating(object sender, CancelEventArgs e)
        {
            base_Validating(ageBox, "Invalid format", @"^\d{0,3}$", e);
        }

        private void heightBox_Validating(object sender, CancelEventArgs e)
        {
            base_Validating(heightBox, "Invalid format", @"^\d{0,3}$", e);
        }

        private void weightBox_Validating(object sender, CancelEventArgs e)
        {
            base_Validating(weightBox, "Invalid format", @"^\d{0,3}$", e);
        }
    }
}
