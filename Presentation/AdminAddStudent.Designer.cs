﻿
namespace Presentation
{
    partial class AdminAddStudent
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
            this.lblLastName = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCourse = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxCourses = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Depth = 0;
            this.lblLastName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastName.Location = new System.Drawing.Point(42, 27);
            this.lblLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(70, 19);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Apellido : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLastName);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Location = new System.Drawing.Point(30, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 64);
            this.panel2.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.AnimateReadOnly = false;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.LeadingIcon = null;
            this.txtLastName.Location = new System.Drawing.Point(113, 21);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(264, 36);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.Text = "";
            this.txtLastName.TrailingIcon = null;
            this.txtLastName.UseTallSize = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(48, 45);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(26, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 77);
            this.panel1.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(117, 37);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 36);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            this.txtName.UseTallSize = false;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Depth = 0;
            this.lblCourse.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse.Location = new System.Drawing.Point(47, 18);
            this.lblCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(62, 19);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Cursos : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxCourses);
            this.panel3.Controls.Add(this.lblCourse);
            this.panel3.Location = new System.Drawing.Point(30, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 60);
            this.panel3.TabIndex = 7;
            // 
            // cbxCourses
            // 
            this.cbxCourses.AutoResize = false;
            this.cbxCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCourses.Depth = 0;
            this.cbxCourses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCourses.DropDownHeight = 118;
            this.cbxCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCourses.DropDownWidth = 121;
            this.cbxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCourses.FormattingEnabled = true;
            this.cbxCourses.IntegralHeight = false;
            this.cbxCourses.ItemHeight = 29;
            this.cbxCourses.Location = new System.Drawing.Point(112, 14);
            this.cbxCourses.MaxDropDownItems = 4;
            this.cbxCourses.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCourses.Name = "cbxCourses";
            this.cbxCourses.Size = new System.Drawing.Size(264, 35);
            this.cbxCourses.StartIndex = 0;
            this.cbxCourses.TabIndex = 0;
            this.cbxCourses.UseTallSize = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(240, 251);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(88, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(323, 251);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(96, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AdminAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(578, 443);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(578, 443);
            this.MinimumSize = new System.Drawing.Size(578, 443);
            this.Name = "AdminAddStudent";
            this.Text = "0";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblLastName;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialLabel lblCourse;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialComboBox cbxCourses;
    }
}