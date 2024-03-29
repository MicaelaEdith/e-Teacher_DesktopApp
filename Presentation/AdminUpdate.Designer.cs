﻿
namespace Presentation
{
    partial class AdminUpdate
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
            this.lblWarning = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCourse = new MaterialSkin.Controls.MaterialLabel();
            this.txtCourse = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInstitute = new MaterialSkin.Controls.MaterialTextBox();
            this.lblInstitute = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLevel = new MaterialSkin.Controls.MaterialTextBox();
            this.lblLevel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxHs = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxHs2 = new MaterialSkin.Controls.MaterialComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxDomingo = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxSabado = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxViernes = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxJueves = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxMiercoles = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxMartes = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxLunes = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.IndianRed;
            this.lblWarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.White;
            this.lblWarning.Location = new System.Drawing.Point(151, 4);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(347, 24);
            this.lblWarning.TabIndex = 23;
            this.lblWarning.Text = " Todos los campos son obligatorios ";
            this.lblWarning.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Location = new System.Drawing.Point(155, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 58);
            this.panel5.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(134, 7);
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
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(44, 7);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCourse);
            this.panel4.Controls.Add(this.txtCourse);
            this.panel4.Location = new System.Drawing.Point(17, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 53);
            this.panel4.TabIndex = 21;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Depth = 0;
            this.lblCourse.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCourse.Location = new System.Drawing.Point(43, 11);
            this.lblCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 19);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Curso :";
            // 
            // txtCourse
            // 
            this.txtCourse.AnimateReadOnly = false;
            this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourse.Depth = 0;
            this.txtCourse.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourse.LeadingIcon = null;
            this.txtCourse.LeaveOnEnterKey = true;
            this.txtCourse.Location = new System.Drawing.Point(103, 7);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(0);
            this.txtCourse.MaxLength = 50;
            this.txtCourse.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCourse.Multiline = false;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(324, 36);
            this.txtCourse.TabIndex = 0;
            this.txtCourse.Text = "";
            this.txtCourse.TrailingIcon = null;
            this.txtCourse.UseTallSize = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtInstitute);
            this.panel2.Controls.Add(this.lblInstitute);
            this.panel2.Location = new System.Drawing.Point(17, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 52);
            this.panel2.TabIndex = 19;
            // 
            // txtInstitute
            // 
            this.txtInstitute.AnimateReadOnly = false;
            this.txtInstitute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstitute.Depth = 0;
            this.txtInstitute.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInstitute.LeadingIcon = null;
            this.txtInstitute.Location = new System.Drawing.Point(103, 16);
            this.txtInstitute.Margin = new System.Windows.Forms.Padding(0);
            this.txtInstitute.MaxLength = 50;
            this.txtInstitute.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInstitute.Multiline = false;
            this.txtInstitute.Name = "txtInstitute";
            this.txtInstitute.Size = new System.Drawing.Size(324, 36);
            this.txtInstitute.TabIndex = 0;
            this.txtInstitute.Text = "";
            this.txtInstitute.TrailingIcon = null;
            this.txtInstitute.UseTallSize = false;
            // 
            // lblInstitute
            // 
            this.lblInstitute.AutoSize = true;
            this.lblInstitute.Depth = 0;
            this.lblInstitute.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInstitute.Location = new System.Drawing.Point(17, 21);
            this.lblInstitute.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInstitute.Name = "lblInstitute";
            this.lblInstitute.Size = new System.Drawing.Size(83, 19);
            this.lblInstitute.TabIndex = 6;
            this.lblInstitute.Text = "Institución :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Location = new System.Drawing.Point(17, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 58);
            this.panel1.TabIndex = 18;
            // 
            // txtLevel
            // 
            this.txtLevel.AnimateReadOnly = false;
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.Depth = 0;
            this.txtLevel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLevel.LeadingIcon = null;
            this.txtLevel.Location = new System.Drawing.Point(103, 14);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(0);
            this.txtLevel.MaxLength = 50;
            this.txtLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLevel.Multiline = false;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(324, 36);
            this.txtLevel.TabIndex = 0;
            this.txtLevel.Text = "";
            this.txtLevel.TrailingIcon = null;
            this.txtLevel.UseTallSize = false;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Depth = 0;
            this.lblLevel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLevel.Location = new System.Drawing.Point(47, 18);
            this.lblLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(44, 19);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Nivel :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(49, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Dias :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(37, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Horario:";
            // 
            // cbxHs
            // 
            this.cbxHs.AutoResize = false;
            this.cbxHs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxHs.Depth = 0;
            this.cbxHs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxHs.DropDownHeight = 118;
            this.cbxHs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHs.DropDownWidth = 121;
            this.cbxHs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxHs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxHs.FormattingEnabled = true;
            this.cbxHs.IntegralHeight = false;
            this.cbxHs.ItemHeight = 29;
            this.cbxHs.Location = new System.Drawing.Point(104, 6);
            this.cbxHs.MaxDropDownItems = 4;
            this.cbxHs.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxHs.Name = "cbxHs";
            this.cbxHs.Size = new System.Drawing.Size(136, 35);
            this.cbxHs.StartIndex = 0;
            this.cbxHs.TabIndex = 0;
            this.cbxHs.UseTallSize = false;
            // 
            // cbxHs2
            // 
            this.cbxHs2.AutoResize = false;
            this.cbxHs2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxHs2.Depth = 0;
            this.cbxHs2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxHs2.DropDownHeight = 118;
            this.cbxHs2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHs2.DropDownWidth = 121;
            this.cbxHs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxHs2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxHs2.FormattingEnabled = true;
            this.cbxHs2.IntegralHeight = false;
            this.cbxHs2.ItemHeight = 29;
            this.cbxHs2.Location = new System.Drawing.Point(241, 6);
            this.cbxHs2.MaxDropDownItems = 4;
            this.cbxHs2.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxHs2.Name = "cbxHs2";
            this.cbxHs2.Size = new System.Drawing.Size(139, 35);
            this.cbxHs2.StartIndex = 0;
            this.cbxHs2.TabIndex = 1;
            this.cbxHs2.UseTallSize = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxDomingo);
            this.panel3.Controls.Add(this.cbxSabado);
            this.panel3.Controls.Add(this.cbxViernes);
            this.panel3.Controls.Add(this.cbxJueves);
            this.panel3.Controls.Add(this.cbxMiercoles);
            this.panel3.Controls.Add(this.cbxMartes);
            this.panel3.Controls.Add(this.cbxLunes);
            this.panel3.Controls.Add(this.materialLabel1);
            this.panel3.Location = new System.Drawing.Point(17, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 68);
            this.panel3.TabIndex = 27;
            // 
            // cbxDomingo
            // 
            this.cbxDomingo.AutoSize = true;
            this.cbxDomingo.Depth = 0;
            this.cbxDomingo.Location = new System.Drawing.Point(235, 30);
            this.cbxDomingo.Margin = new System.Windows.Forms.Padding(0);
            this.cbxDomingo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxDomingo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxDomingo.Name = "cbxDomingo";
            this.cbxDomingo.ReadOnly = false;
            this.cbxDomingo.Ripple = true;
            this.cbxDomingo.Size = new System.Drawing.Size(100, 37);
            this.cbxDomingo.TabIndex = 6;
            this.cbxDomingo.Text = "Domingo";
            this.cbxDomingo.UseVisualStyleBackColor = true;
            // 
            // cbxSabado
            // 
            this.cbxSabado.AutoSize = true;
            this.cbxSabado.Depth = 0;
            this.cbxSabado.Location = new System.Drawing.Point(163, 31);
            this.cbxSabado.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSabado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxSabado.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxSabado.Name = "cbxSabado";
            this.cbxSabado.ReadOnly = false;
            this.cbxSabado.Ripple = true;
            this.cbxSabado.Size = new System.Drawing.Size(90, 37);
            this.cbxSabado.TabIndex = 5;
            this.cbxSabado.Text = "Sábado";
            this.cbxSabado.UseVisualStyleBackColor = true;
            // 
            // cbxViernes
            // 
            this.cbxViernes.AutoSize = true;
            this.cbxViernes.BackColor = System.Drawing.Color.Transparent;
            this.cbxViernes.Depth = 0;
            this.cbxViernes.Location = new System.Drawing.Point(96, 31);
            this.cbxViernes.Margin = new System.Windows.Forms.Padding(0);
            this.cbxViernes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxViernes.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxViernes.Name = "cbxViernes";
            this.cbxViernes.ReadOnly = false;
            this.cbxViernes.Ripple = true;
            this.cbxViernes.Size = new System.Drawing.Size(87, 37);
            this.cbxViernes.TabIndex = 4;
            this.cbxViernes.Text = "Viernes";
            this.cbxViernes.UseVisualStyleBackColor = false;
            // 
            // cbxJueves
            // 
            this.cbxJueves.AutoSize = true;
            this.cbxJueves.Depth = 0;
            this.cbxJueves.Location = new System.Drawing.Point(319, 2);
            this.cbxJueves.Margin = new System.Windows.Forms.Padding(0);
            this.cbxJueves.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxJueves.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxJueves.Name = "cbxJueves";
            this.cbxJueves.ReadOnly = false;
            this.cbxJueves.Ripple = true;
            this.cbxJueves.Size = new System.Drawing.Size(85, 37);
            this.cbxJueves.TabIndex = 3;
            this.cbxJueves.Text = "Jueves";
            this.cbxJueves.UseVisualStyleBackColor = true;
            // 
            // cbxMiercoles
            // 
            this.cbxMiercoles.AutoSize = true;
            this.cbxMiercoles.Depth = 0;
            this.cbxMiercoles.Location = new System.Drawing.Point(235, 1);
            this.cbxMiercoles.Margin = new System.Windows.Forms.Padding(0);
            this.cbxMiercoles.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxMiercoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxMiercoles.Name = "cbxMiercoles";
            this.cbxMiercoles.ReadOnly = false;
            this.cbxMiercoles.Ripple = true;
            this.cbxMiercoles.Size = new System.Drawing.Size(103, 37);
            this.cbxMiercoles.TabIndex = 2;
            this.cbxMiercoles.Text = "Miércoles";
            this.cbxMiercoles.UseVisualStyleBackColor = true;
            // 
            // cbxMartes
            // 
            this.cbxMartes.AutoSize = true;
            this.cbxMartes.Depth = 0;
            this.cbxMartes.Location = new System.Drawing.Point(163, 1);
            this.cbxMartes.Margin = new System.Windows.Forms.Padding(0);
            this.cbxMartes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxMartes.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxMartes.Name = "cbxMartes";
            this.cbxMartes.ReadOnly = false;
            this.cbxMartes.Ripple = true;
            this.cbxMartes.Size = new System.Drawing.Size(84, 37);
            this.cbxMartes.TabIndex = 1;
            this.cbxMartes.Text = "Martes";
            this.cbxMartes.UseVisualStyleBackColor = true;
            // 
            // cbxLunes
            // 
            this.cbxLunes.AutoSize = true;
            this.cbxLunes.Depth = 0;
            this.cbxLunes.Location = new System.Drawing.Point(96, 1);
            this.cbxLunes.Margin = new System.Windows.Forms.Padding(0);
            this.cbxLunes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxLunes.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxLunes.Name = "cbxLunes";
            this.cbxLunes.ReadOnly = false;
            this.cbxLunes.Ripple = true;
            this.cbxLunes.Size = new System.Drawing.Size(78, 37);
            this.cbxLunes.TabIndex = 0;
            this.cbxLunes.Text = "Lunes";
            this.cbxLunes.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.materialLabel2);
            this.panel6.Controls.Add(this.cbxHs);
            this.panel6.Controls.Add(this.cbxHs2);
            this.panel6.Location = new System.Drawing.Point(17, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(443, 49);
            this.panel6.TabIndex = 28;
            // 
            // AdminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(578, 443);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(578, 443);
            this.MinimumSize = new System.Drawing.Size(578, 443);
            this.Name = "AdminUpdate";
            this.Text = "AdminUpdate";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel lblCourse;
        private MaterialSkin.Controls.MaterialTextBox txtCourse;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox txtInstitute;
        private MaterialSkin.Controls.MaterialLabel lblInstitute;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtLevel;
        private MaterialSkin.Controls.MaterialLabel lblLevel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbxHs;
        private MaterialSkin.Controls.MaterialComboBox cbxHs2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialCheckbox cbxDomingo;
        private MaterialSkin.Controls.MaterialCheckbox cbxSabado;
        private MaterialSkin.Controls.MaterialCheckbox cbxViernes;
        private MaterialSkin.Controls.MaterialCheckbox cbxJueves;
        private MaterialSkin.Controls.MaterialCheckbox cbxMiercoles;
        private MaterialSkin.Controls.MaterialCheckbox cbxMartes;
        private MaterialSkin.Controls.MaterialCheckbox cbxLunes;
    }
}