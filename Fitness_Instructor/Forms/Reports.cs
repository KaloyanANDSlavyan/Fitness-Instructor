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
        private int ClientsProgramsId;
        public Reports()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientsProgramsId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            dataGridView2.DataSource = databaseAccess.report2(ClientsProgramsId);
        }

        private int getInstructor()
        {
            if (Equals(dataRetriever.getUsername(), "slavcho44"))
                return 1;
            else
                return 2;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = databaseAccess.report(getInstructor());
        }
    }
}
