using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Instructor.Forms
{
    public partial class Reports : Form
    {
        private DatabaseAccess databaseAccess;
        private DataRetriever dataRetriever = DataRetriever.Instance;
        public Reports()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
        }

        private object GetDataGridView()
        {
            if (Equals(dataRetriever.getUsername(), "slavcho44"))
                return databaseAccess.report(double.Parse(textBox1.Text), 1);
            else
                return databaseAccess.report(double.Parse(textBox1.Text), 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = GetDataGridView();
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
            
        }
    }
}
