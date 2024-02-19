﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Business;

namespace Presentation
{
    public partial class Admin : MaterialForm
    {
        public Admin()
        {
            AppData.id = -1;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Grey900, Primary.Grey900,
            Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            AddItems();
        }

        private Form activeForm = null;
        private void OpenPanel(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlAdmin.Controls.Add(form);
            pnlAdmin.Tag = form;
            form.Tag = this;
            form.Show();

        }

        private void AddItems()
        {

            cbxItems.Items.Add("Cursos");
            cbxItems.Items.Add("Alumnos");
            cbxItems.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            swAvailable.Visible = false;
            lblAvailable.Visible = false;
            if (cbxItems.SelectedIndex == 0)
            {
                OpenPanel(new AdminNewCourse());
            }
            else
            {
                OpenPanel(new AdminAddStudent());
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            panelList(swAvailable.Checked);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnUpdate_click");
            if (AppData.SelectedItem is Courses)
            {
                OpenPanel(new AdminUpdate());

            }
            else
            {
                OpenPanel(new AdminUpdateStudent((Student)AppData.SelectedItem));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(AppData.id!=-1)
            OpenPanel(new DeleteWarning(cbxItems.SelectedIndex));
            

        }
        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppData.id = -1;

        }

        private void swAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (swAvailable.Checked)
            {
                if (AppData.SelectedItem is Courses)
                {
                    panelList(true);
                }
                else
                {
                    panelList(true);
                }
            }
            else {

                panelList(false);
            }

        }

        private void panelList(bool Available) {

            OpenPanel(new AdminList(cbxItems.SelectedIndex,Available));
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            swAvailable.Visible = true;
            lblAvailable.Visible = true;

        }
    }
}
