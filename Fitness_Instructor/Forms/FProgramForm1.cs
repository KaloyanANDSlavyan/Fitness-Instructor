using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Instructor.Forms
{
    public partial class FProgramForm1 : Form
    {
        private DatabaseAccess databaseAccess;
        private int clientId;
        private int programId;
        private Client client;
        private FitnessProgram program;

        private DataRetriever dataRetriever = DataRetriever.Instance;
        public FProgramForm1()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (client == null || program == null)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                FProgramForm2 stage2 = new FProgramForm2();
                this.Hide();
                stage2.ShowDialog();
                this.Close();
            }
        }

        private void clientsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            client = new Client();
            clientId = Convert.ToInt32(clientsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            client.FirstName = clientsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            dataRetriever.setClientId(clientId);
            dataRetriever.setClient(client);

        }

        private void programsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            program = new FitnessProgram();
            programId = Convert.ToInt32(programsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            program.ProgramName = programsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            program.Description = programsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            dataRetriever.setProgramId(programId);
            dataRetriever.setFitnessProgram(program);
        }

        private object GetDataGridView()
        {
            if (Equals(dataRetriever.getUsername(), "slavcho44"))
                return databaseAccess.outputClients(1);
            else
                return databaseAccess.outputClients(2);
        }

        private void Stage1_Load(object sender, EventArgs e)
        {
            clientsGridView.DataSource = GetDataGridView();
            programsGridView.DataSource = databaseAccess.outputPrograms();
            
        }
    }
}
