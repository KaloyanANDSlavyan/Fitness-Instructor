using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Instructor
{
    public partial class IntroForm : Form
    {

        public IntroForm()
        {
            InitializeComponent();

            this.Text = null;
            this.ControlBox = false;
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
           
            DatabaseAccess db = new DatabaseAccess();
            handleProgressBar();
        }

        private void handleProgressBar()
        {
            this.timer1.Enabled = true;
            this.timer1.Start();
            this.timer1.Interval = 100;
            progressBar1.Maximum = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value != 100)
                progressBar1.Value++;
            else
            {
                timer1.Stop();
                Menu m = new Menu();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
         
        }
    }
}
