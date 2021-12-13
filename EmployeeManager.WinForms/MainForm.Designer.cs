
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerControl = new EmployeeManager.WinForms.Controls.HeaderControl();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lsbEmployees = new System.Windows.Forms.ListBox();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkIsCoffeeDrinker = new System.Windows.Forms.CheckBox();
            this.cboJobRole = new System.Windows.Forms.ComboBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblJobRole = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlRefresh.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.headerControl);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1244, 87);
            this.pnlHeader.TabIndex = 0;
            // 
            // headerControl
            // 
            this.headerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.headerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl.Location = new System.Drawing.Point(0, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1244, 87);
            this.headerControl.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.lsbEmployees);
            this.pnlNavigation.Controls.Add(this.pnlRefresh);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 87);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(194, 730);
            this.pnlNavigation.TabIndex = 1;
            // 
            // lsbEmployees
            // 
            this.lsbEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbEmployees.FormattingEnabled = true;
            this.lsbEmployees.ItemHeight = 25;
            this.lsbEmployees.Location = new System.Drawing.Point(0, 60);
            this.lsbEmployees.Name = "lsbEmployees";
            this.lsbEmployees.Size = new System.Drawing.Size(194, 670);
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.Controls.Add(this.btnSave);
            this.pnlMainArea.Controls.Add(this.chkIsCoffeeDrinker);
            this.pnlMainArea.Controls.Add(this.cboJobRole);
            this.pnlMainArea.Controls.Add(this.dtpEntryDate);
            this.pnlMainArea.Controls.Add(this.txtFirstName);
            this.pnlMainArea.Controls.Add(this.lblJobRole);
            this.pnlMainArea.Controls.Add(this.lblEntryDate);
            this.pnlMainArea.Controls.Add(this.lblFirstName);
            this.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainArea.Location = new System.Drawing.Point(194, 87);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(1050, 730);
            this.pnlMainArea.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(22, 673);
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
            // cboJobRole
            // 
            this.cboJobRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboJobRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJobRole.FormattingEnabled = true;
            this.cboJobRole.Location = new System.Drawing.Point(22, 178);
            this.cboJobRole.Name = "cboJobRole";
            this.cboJobRole.Size = new System.Drawing.Size(1016, 33);
            this.cboJobRole.TabIndex = 5;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(22, 109);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(523, 31);
            this.dtpEntryDate.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(22, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(1016, 31);
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
            this.ClientSize = new System.Drawing.Size(1244, 817);
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
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cboJobRole;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblJobRole;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblFirstName;
        private Controls.HeaderControl headerControl;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}

