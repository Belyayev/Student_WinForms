﻿
namespace EmployeeManager.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerControl = new EmployeeManager.WinForms.Controls.HeaderControl();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lsbEmployees = new System.Windows.Forms.ListBox();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkIsCoffeeDrinker = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblJobRole = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlRefresh.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.headerControl);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1127, 87);
            this.pnlHeader.TabIndex = 0;
            // 
            // headerControl
            // 
            this.headerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.headerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl.Location = new System.Drawing.Point(0, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1127, 87);
            this.headerControl.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.lsbEmployees);
            this.pnlNavigation.Controls.Add(this.pnlRefresh);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 87);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(194, 612);
            this.pnlNavigation.TabIndex = 1;
            // 
            // lsbEmployees
            // 
            this.lsbEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbEmployees.FormattingEnabled = true;
            this.lsbEmployees.ItemHeight = 25;
            this.lsbEmployees.Location = new System.Drawing.Point(0, 60);
            this.lsbEmployees.Name = "lsbEmployees";
            this.lsbEmployees.Size = new System.Drawing.Size(194, 552);
            this.lsbEmployees.TabIndex = 1;
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.Controls.Add(this.btnRefresh);
            this.pnlRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRefresh.Location = new System.Drawing.Point(0, 0);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(194, 60);
            this.pnlRefresh.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(33, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 36);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.Controls.Add(this.btnSave);
            this.pnlMainArea.Controls.Add(this.chkIsCoffeeDrinker);
            this.pnlMainArea.Controls.Add(this.comboBox1);
            this.pnlMainArea.Controls.Add(this.dateTimePicker1);
            this.pnlMainArea.Controls.Add(this.txtFirstName);
            this.pnlMainArea.Controls.Add(this.lblJobRole);
            this.pnlMainArea.Controls.Add(this.lblEntryDate);
            this.pnlMainArea.Controls.Add(this.lblFirstName);
            this.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainArea.Location = new System.Drawing.Point(194, 87);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(933, 612);
            this.pnlMainArea.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(22, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chkIsCoffeeDrinker
            // 
            this.chkIsCoffeeDrinker.AutoSize = true;
            this.chkIsCoffeeDrinker.Location = new System.Drawing.Point(22, 241);
            this.chkIsCoffeeDrinker.Name = "chkIsCoffeeDrinker";
            this.chkIsCoffeeDrinker.Size = new System.Drawing.Size(170, 29);
            this.chkIsCoffeeDrinker.TabIndex = 6;
            this.chkIsCoffeeDrinker.Text = "Is Coffee Drinker";
            this.chkIsCoffeeDrinker.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(899, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(523, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(22, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(899, 31);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblJobRole
            // 
            this.lblJobRole.AutoSize = true;
            this.lblJobRole.Location = new System.Drawing.Point(17, 149);
            this.lblJobRole.Name = "lblJobRole";
            this.lblJobRole.Size = new System.Drawing.Size(79, 25);
            this.lblJobRole.TabIndex = 2;
            this.lblJobRole.Text = "Job Role";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(17, 81);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(94, 25);
            this.lblEntryDate.TabIndex = 1;
            this.lblEntryDate.Text = "Entry Date";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Firstname";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1127, 699);
            this.Controls.Add(this.pnlMainArea);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlRefresh.ResumeLayout(false);
            this.pnlMainArea.ResumeLayout(false);
            this.pnlMainArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.ListBox lsbEmployees;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlMainArea;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkIsCoffeeDrinker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblJobRole;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblFirstName;
        private Controls.HeaderControl headerControl;
    }
}
