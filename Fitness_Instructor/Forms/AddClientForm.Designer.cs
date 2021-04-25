
namespace Fitness_Instructor
{
    partial class AddClientForm
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.genderCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(381, 72);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(177, 27);
            this.firstNameBox.TabIndex = 0;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(381, 131);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(177, 27);
            this.lastNameBox.TabIndex = 1;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(381, 188);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(177, 27);
            this.ageBox.TabIndex = 2;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(381, 318);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(177, 27);
            this.weightBox.TabIndex = 3;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(381, 252);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(177, 27);
            this.heightBox.TabIndex = 4;
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(419, 403);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(94, 29);
            this.addClientButton.TabIndex = 5;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // genderCheckBox
            // 
            this.genderCheckBox.AutoSize = true;
            this.genderCheckBox.Location = new System.Drawing.Point(419, 362);
            this.genderCheckBox.Name = "genderCheckBox";
            this.genderCheckBox.Size = new System.Drawing.Size(98, 24);
            this.genderCheckBox.TabIndex = 6;
            this.genderCheckBox.Text = "undefined";
            this.genderCheckBox.UseVisualStyleBackColor = true;
            this.genderCheckBox.CheckedChanged += new System.EventHandler(this.genderCheckBox_CheckedChanged);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(944, 492);
            this.Controls.Add(this.genderCheckBox);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.CheckBox genderCheckBox;
    }
}