using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Instructor.Forms
{
    public partial class InfoFProgramForm : Form
    {
        public InfoFProgramForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            FProgramForm1 stage1 = new FProgramForm1();
            stage1.ShowDialog();
        }
    }
}
