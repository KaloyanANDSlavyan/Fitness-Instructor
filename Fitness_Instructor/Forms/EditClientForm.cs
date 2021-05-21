﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Instructor
{
    public partial class EditClientForm : Form
    {
        private int clientId;
        private int age;
        private float height;
        private float weight;
        private DatabaseAccess databaseAccess;

        public EditClientForm()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = databaseAccess.outputClients();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
           
            databaseAccess.updateClient(clientId, firstNameBox.Text, lastNameBox.Text, ageBox.Text, heightBox.Text, weightBox.Text);
            dataGridView.DataSource = databaseAccess.outputClients();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
           databaseAccess.deleteClient(clientId);
            dataGridView.DataSource = databaseAccess.outputClients();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clientId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            firstNameBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastNameBox.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ageBox.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            
            heightBox.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
    
            weightBox.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
    }
}