﻿using System;
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
    public partial class AdminUpdate : Form
    {
        string days = "";
        string hsFinal = "";

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

        public AdminUpdate(Courses cour)
        {
            InitializeComponent();
            txtCourse.Text = cour.CoursesClasses;
            txtInstitute.Text = cour.Institution;
            txtLevel.Text = cour.Level;
            checkDays(cour.Days);
            txtCourse.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCourse.Width, txtCourse.Height, 5, 5));
            txtInstitute.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtInstitute.Width, txtInstitute.Height, 5, 5));
            txtLevel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtLevel.Width, txtLevel.Height, 5, 5));
            cbxHs.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxHs.Width, cbxHs.Height, 5, 5));
            cbxHs2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxHs2.Width, cbxHs2.Height, 5, 5));
            cbxHs.DataSource = setHs();
            cbxHs2.DataSource = setHs();
            setHs(cour.Days);
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CoursesManager cm = new CoursesManager();
            Courses course = new Courses();
            course.CoursesClasses = txtCourse.Text;
            course.Days = setDays();
            course.Institution = txtInstitute.Text;
            course.Level = txtLevel.Text;
            course.Id = AppData.id;

            if (txtCourse.Text != "" && txtCourse != null &&
               txtInstitute.Text != "" && txtInstitute != null &&
               txtLevel.Text != "" && txtLevel != null)
            {
                cm.Update(course);
            }
            else
                lblWarning.Visible = true;
            Close();

        }

        private static List<string> setHs()
        {
            List<string> list = new List<string>();


            for (int i = 6; i <= 23; i++)
            {
                for (int min = 0; min < 60; min += 30)
                {
                    string hs = $"{i % 12}:{min:D2} {(i < 12 ? "am" : "pm")}";
                    list.Add(hs);
                }
            }

            return list;
        }

        private string setDays()
        {
            if (cbxHs.SelectedIndex < cbxHs2.SelectedIndex)
                hsFinal = $" {cbxHs.Text} - {cbxHs2.Text}";

            List<string> Select = new List<string> { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            for (int i = 0; i < 7; i++)
            {
                CheckBox checkbox = (CheckBox)Controls.Find("cbx" + Select[i], true).FirstOrDefault();

                if (checkbox.Checked)
                {
                    if (days != "")
                        days += ", " + Select[i];
                    else
                        days += Select[i];
                }

            }
            days = days + "  - " + hsFinal;

            return days;
        }

        private void setHs(string input)
        {
            List<string> list = new List<string>();
            string[] parts = input.Split('-');

            string hs1 = parts[1].Trim();
            string hs2 = parts[2].Trim();

            list.Add(hs1);
            list.Add(hs2);
            Console.WriteLine(hs1);
            Console.WriteLine(hs2);

            cbxHs.SelectedIndex = cbxHs.Items.IndexOf(hs1);
            cbxHs2.SelectedIndex = cbxHs.Items.IndexOf(hs2);
            
           

        }

        private void checkDays(string courDays)
        {
            List<string> dayList = new List<string> { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            List<string> dayListCopy = new List<string> { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            for (int i=0;i<7;i++)
            {
                CheckBox checkbox = (CheckBox)this.GetType().GetField("cbx" + dayListCopy[i], System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this);

                if (courDays.Contains(dayList[i]))
                {
                    checkbox.Checked = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
