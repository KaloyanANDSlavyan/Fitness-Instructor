using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Instructor.Forms
{
    public partial class FProgramForm2 : Form
    {
        private DatabaseAccess databaseAccess;
        private DataRetriever dataRetriever = DataRetriever.Instance;
        private int clientId;
        private int programId;
        private int exerciseId;
        private int reps;
        private int clientsProgramsId;
        
        public FProgramForm2()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
            clientId = dataRetriever.getClientId();
            programId = dataRetriever.getProgramId();
        }

        private void exercisesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            exerciseId = Convert.ToInt32(exercisesGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private int getInstructor()
        {
            if (Equals(dataRetriever.getUsername(), "slavcho44"))
                return 1;
            else
                return 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                reps = Convert.ToInt32(repsBox.Text);
                databaseAccess.insertClients_Programs_Exercises(clientsProgramsId, exerciseId, reps, getInstructor());
                reportGridView.DataSource = databaseAccess.report2(clientsProgramsId);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void Stage2_Load(object sender, EventArgs e)
        {
            firstNameLabel.Text = dataRetriever.getClient().FirstName;
            programNameLabel.Text = dataRetriever.getFitnessProgram().ProgramName;
            descriptionLabel.Text = dataRetriever.getFitnessProgram().Description;
            exercisesGridView.DataSource = databaseAccess.outputExercises();
            clientsProgramsId = databaseAccess.insertClients_Programs(clientId, programId);
        }
    }
}
