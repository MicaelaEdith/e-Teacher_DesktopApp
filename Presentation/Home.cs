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
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class Home : MaterialForm
    {
        private List<Courses> listCourses;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Grey900, Primary.Grey900,
            Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            dgvCourses.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dgvCourses.Width, dgvCourses.Height, 5, 5));
            UpdateDiary();
            UpdateGrid();
            
        }

        private void UpdateGrid()
        {
            CoursesManager courses = new CoursesManager();

            dgvCourses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvCourses.RowHeadersVisible = false;

            try
            {
                listCourses = courses.ListCoursesAvailable();
                foreach (Courses c in listCourses)
                {

                    int rowIndex = dgvCourses.Rows.Add();
                    DataGridViewRow row = dgvCourses.Rows[rowIndex];
                    row.Cells[0].Value = c.CoursesClasses.ToUpper();
                    row.Cells[1].Value = c.Days;
                    row.Cells[2].Value = c.Institution;
                    row.Cells[3].Value = c.Level;
                }



            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        private void UpdateDiary()
        {



        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
    }
}

