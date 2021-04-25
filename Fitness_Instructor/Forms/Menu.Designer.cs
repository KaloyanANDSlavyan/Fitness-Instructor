
namespace Fitness_Instructor
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panelMenu.Controls.Add(this.deleteButton);
            this.panelMenu.Controls.Add(this.addButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 623);
            this.panelMenu.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteButton.IconColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.IconSize = 42;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(0, 200);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(220, 60);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Remove Client";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.addButton.IconColor = System.Drawing.Color.Gainsboro;
            this.addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addButton.IconSize = 42;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(0, 140);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(220, 60);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Client";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(53, 21);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 98);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "FS";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panelTopBar.Controls.Add(this.minimizeButton);
            this.panelTopBar.Controls.Add(this.restoreButton);
            this.panelTopBar.Controls.Add(this.exitButton);
            this.panelTopBar.Controls.Add(this.lblTitleChildForm);
            this.panelTopBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(220, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(962, 75);
            this.panelTopBar.TabIndex = 1;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(84, 29);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(69, 23);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(31, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(962, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDesktop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(962, 539);
            this.panelDesktop.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(220, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(8, 8);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(919, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(31, 29);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restoreButton.Location = new System.Drawing.Point(882, 13);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(31, 29);
            this.restoreButton.TabIndex = 3;
            this.restoreButton.Text = "[]";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.Location = new System.Drawing.Point(845, 13);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(31, 29);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1182, 623);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton deleteButton;
        private FontAwesome.Sharp.IconButton addButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label btnHome;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button exitButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button restoreButton;
    }
}