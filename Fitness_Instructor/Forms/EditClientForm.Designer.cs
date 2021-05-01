
namespace Fitness_Instructor
{
    partial class EditClientForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(34, 121);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(725, 317);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(34, 21);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(125, 27);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.Text = "First Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(34, 71);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(125, 27);
            this.lastNameBox.TabIndex = 2;
            this.lastNameBox.Text = "Last name";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(192, 21);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(125, 27);
            this.ageBox.TabIndex = 3;
            this.ageBox.Text = "Age";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(192, 71);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(125, 27);
            this.heightBox.TabIndex = 4;
            this.heightBox.Text = "Height";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(341, 21);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(125, 27);
            this.weightBox.TabIndex = 5;
            this.weightBox.Text = "Weight";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(371, 68);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(94, 29);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(513, 68);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 29);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "EditClientForm";
            this.Text = "EditClientForm";
            this.Load += new System.EventHandler(this.EditClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
    }
}