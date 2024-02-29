﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;


namespace Presentation
{
    public partial class AdminAddStudent : Form
    {
        public AdminAddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;

            StudentsManager sm = new StudentsManager();
            sm.AddStudent(name, lastName);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
