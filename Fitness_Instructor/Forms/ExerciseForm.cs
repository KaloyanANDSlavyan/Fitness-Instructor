using Fitness_Instructor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Fitness_Instructor.Forms
{
    public partial class ExerciseForm : Form
    {
        Image Chest = Resources.Chest;
        Image Back = Resources.Back;
        Image Shoulders = Resources.Shoulders;
        Image Abdominal = Resources.Abdominal;
        Image Quadriceps = Resources.Quadriceps;
        Image Calves = Resources.Calves;
        Image Biceps = Resources.Biceps;
        Image Triceps = Resources.Triceps;

        private DatabaseAccess databaseAccess;

        public ExerciseForm()
        {

            InitializeComponent();
            pictureBox1.Image = Chest;
            pictureBox2.Image = Back;
            pictureBox3.Image = Shoulders;
            pictureBox4.Image = Abdominal;
            pictureBox5.Image = Quadriceps;
            pictureBox6.Image = Calves;
            pictureBox7.Image = Biceps;
            pictureBox8.Image = Triceps;

            databaseAccess = new DatabaseAccess();
        }



        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = databaseAccess.DisplayExercise(1);
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        pictureBox1.Size = new System.Drawing.Size(160, 130);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
           pictureBox1.Size = new System.Drawing.Size(112, 91);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = databaseAccess.DisplayExercise(2);

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new System.Drawing.Size(160, 130);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new System.Drawing.Size(112, 91);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = databaseAccess.DisplayExercise(3);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Size = new System.Drawing.Size(160, 130);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new System.Drawing.Size(112, 91);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = databaseAccess.DisplayExercise(4);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new System.Drawing.Size(160, 130);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new System.Drawing.Size(112, 91);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = databaseAccess.DisplayExercise(5);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Size = new System.Drawing.Size(160, 130);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new System.Drawing.Size(112, 91);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = databaseAccess.DisplayExercise(6);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Size = new System.Drawing.Size(160, 130);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new System.Drawing.Size(112, 91);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = databaseAccess.DisplayExercise(7);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Size = new System.Drawing.Size(160, 130);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new System.Drawing.Size(112, 91);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = databaseAccess.DisplayExercise(8);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Size = new System.Drawing.Size(160, 130);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new System.Drawing.Size(112, 91);
        }


    }
}
