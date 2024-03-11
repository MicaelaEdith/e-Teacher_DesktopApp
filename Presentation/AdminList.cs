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
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class AdminList : Form
    {
        private List<Courses> listCourses;
        private List<Student> listStudents;
        private int index;
        private Student selectedStudent;
        private Courses selectedCourses;
        private CoursesManager courses = new CoursesManager();
        private StudentsManager students = new StudentsManager();
        private bool swAvailable;
        private List<Courses> listAvailableC;
        private List<Student> listAvailableS;
        private bool details = false;




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

        public AdminList(int index, bool Available)
        {
            this.swAvailable = Available;
            this.index = index;
            InitializeComponent();
            dgvList.BorderStyle = BorderStyle.None;
            dgvData.BorderStyle = BorderStyle.None;
            dgvList.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dgvList.Width, dgvList.Height, 5, 5));
            dgvData.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dgvData.Width, dgvData.Height, 5, 5));
            cbxAdd.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxAdd.Width, cbxAdd.Height, 5, 5));
            if (index == 0)
            {
                UpdateCourses();
                dgvList.Columns["level"].Visible = false;
                dgvList.Columns["CoursesClasses"].Width = 65;
                dgvList.Columns["days"].Width = 120;
                dgvList.Columns["Institution"].Width = 95;

            }
            else
            {
                UpdateStudents();
                dgvList.Columns["lastName"].Width = 180;
            }


            dgvList.ClearSelection();
            dgvList.CurrentCell = null;




        }
        private void UpdateCourses()
        {
            listCourses = courses.ListCourses();
            listAvailableC = courses.ListCoursesAvailable();
            AppData.openPanel = "ListCourses";


            try
            {
                if (!swAvailable)
                    dgvList.DataSource = listAvailableC;
                else
                    dgvList.DataSource = listCourses;
                dgvList.Columns["id"].Visible = false;
                if (!swAvailable)
                    dgvList.Columns["available"].Visible = false;

                dgvList.ClearSelection();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void UpdateStudents()
        {
            listStudents = students.ListStudents();
            listAvailableS = students.ListStudentsAvailable();
            AppData.openPanel = "ListStudents";

            try
            {
                if (!swAvailable)
                    dgvList.DataSource = listAvailableS;
                else
                    dgvList.DataSource = listStudents;
                dgvList.Columns["id"].Visible = false;

                if (!swAvailable)
                    dgvList.Columns["available"].Visible = false;

                dgvList.ClearSelection();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void Datails()
        {
            if (AppData.SelectedItem is Courses)
            {
                dgvData.DataSource = courses.listStudents(AppData.id);
                dgvData.Columns["id"].Visible = false;
                dgvData.Columns[3].Visible = false;
                string name = courses.findNameByid(AppData.id).ToUpper();
                lblTitle.Text = name;
                List<Student> list = students.ListStudentsAvailable();

                for (int i = 0; i < list.Count; i++)
                {
                    name += list[i].Name + " " + list[i].LastName;
                    cbxAdd.Items.Add(name);
                    name = "";
                }

            }
            else
            {
                int id = AppData.id;
                dgvData.DataSource = students.ListCourses(id);
                List<Courses> list = courses.ListCoursesAvailable();
                string name = students.findNameByid(AppData.id).ToUpper();
                lblTitle.Text = name;

                for (int i = 0; i < list.Count; i++)
                {
                    name = list[i].CoursesClasses;
                    cbxAdd.Items.Add(name);
                    name = "";
                }
            }

        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (!details) {
                details = true;
                dgvList.Visible = false;
                cbxAdd.Visible = true;
                btnAddData.Visible = true;
                dgvData.Visible = true;
                lblTitle.Visible = true;
                btnDetails.Text = "Volver";
                Datails();


            }
            else
            {
                details = false;
                dgvList.Visible = true;
                dgvData.Visible = false;
                cbxAdd.Visible = false;
                lblTitle.Visible = false;
                btnAddData.Visible = false;
                btnDetails.Text = "Detalle";

            }

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (AppData.SelectedItem is Courses)
            {
                List<Student> list = students.ListStudentsAvailable();
                int index = cbxAdd.SelectedIndex;
                Console.WriteLine("index: " + index);
                /// fix ↓
                students.AddCourse(list[index].Id, AppData.id);
            }
            else
            {
                List<Courses> list = courses.ListCoursesAvailable();
                int index = cbxAdd.SelectedIndex;
                students.AddCourse(AppData.id, list[index].Id);
            }
        }

        private void dgvList_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvList.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dgvList.SelectedRows[0];

                int idValue = (int)selectedRow.Cells["id"].Value;
                AppData.id = idValue;
                Console.WriteLine(AppData.id);
                if (index == 0)
                {
                    selectedCourses = courses.findByid(idValue);
                    AppData.SelectedItem = selectedCourses;

                }
                else
                {
                    selectedStudent = students.findByid(idValue);
                    AppData.SelectedItem = selectedStudent;
                }

            }
        }
    }
}
