using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Fitness_Instructor.Forms;

namespace Fitness_Instructor
{

    public partial class Menu : Form
    {
        // Fields
        private DatabaseAccess db;
        private DataRetriever dataRetriever;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        // Constructor
        public Menu()
        {
            InitializeComponent();
            db = new DatabaseAccess();
            dataRetriever = DataRetriever.Instance;
            userLabel.Text = dataRetriever.getUsername();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            // Form - removes window frame
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        // Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(3, 148, 252);
        }
        // Methods
        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color; 

            }
        }

        private void disableButton()
        {
            if (currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(33, 36, 41);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            openChildForm(new AddClientForm());
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            openChildForm(new EditClientForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }


        private void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open single form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Dumbbell;
            iconCurrentChildForm.IconColor = SystemColors.Highlight;
            lblTitleChildForm.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Exercisebutton_click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            openChildForm(new ExerciseForm());

        }

        private void caloriesButton_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            openChildForm(new CaloriesCalculatorForm());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();

        }

        private void reportsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
