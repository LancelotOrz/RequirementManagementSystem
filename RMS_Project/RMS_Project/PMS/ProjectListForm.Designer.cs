﻿namespace RMS_Project
{
    partial class projectListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._yourProjectListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.projectTabControl = new System.Windows.Forms.TabControl();
            this.YourProjects = new System.Windows.Forms.TabPage();
            this.ManagedProjects = new System.Windows.Forms.TabPage();
            this._managedProjectListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinedProjects = new System.Windows.Forms.TabPage();
            this.joinedProjectListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._yourProjectListDataGridView)).BeginInit();
            this.projectTabControl.SuspendLayout();
            this.YourProjects.SuspendLayout();
            this.ManagedProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._managedProjectListDataGridView)).BeginInit();
            this.JoinedProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joinedProjectListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _yourProjectListDataGridView
            // 
            this._yourProjectListDataGridView.AccessibleName = "projectDataGridView";
            this._yourProjectListDataGridView.AllowUserToAddRows = false;
            this._yourProjectListDataGridView.AllowUserToDeleteRows = false;
            this._yourProjectListDataGridView.AllowUserToResizeColumns = false;
            this._yourProjectListDataGridView.AllowUserToResizeRows = false;
            this._yourProjectListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._yourProjectListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._yourProjectListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._yourProjectListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._yourProjectListDataGridView.ColumnHeadersVisible = false;
            this._yourProjectListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.deleteColumn});
            this._yourProjectListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._yourProjectListDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this._yourProjectListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._yourProjectListDataGridView.Location = new System.Drawing.Point(0, 0);
            this._yourProjectListDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this._yourProjectListDataGridView.MultiSelect = false;
            this._yourProjectListDataGridView.Name = "_yourProjectListDataGridView";
            this._yourProjectListDataGridView.ReadOnly = true;
            this._yourProjectListDataGridView.RowHeadersVisible = false;
            this._yourProjectListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._yourProjectListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._yourProjectListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this._yourProjectListDataGridView.RowTemplate.DividerHeight = 1;
            this._yourProjectListDataGridView.RowTemplate.Height = 50;
            this._yourProjectListDataGridView.RowTemplate.ReadOnly = true;
            this._yourProjectListDataGridView.Size = new System.Drawing.Size(476, 422);
            this._yourProjectListDataGridView.TabIndex = 1;
            this._yourProjectListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._yourProjectListDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 179.6954F;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.deleteColumn.HeaderText = "Column3";
            this.deleteColumn.Image = global::RMS_Project.Properties.Resources.ios7_trash;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn.Width = 5;
            // 
            // projectTabControl
            // 
            this.projectTabControl.AccessibleName = "projectTabControl";
            this.projectTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.projectTabControl.Controls.Add(this.YourProjects);
            this.projectTabControl.Controls.Add(this.ManagedProjects);
            this.projectTabControl.Controls.Add(this.JoinedProjects);
            this.projectTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTabControl.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTabControl.Location = new System.Drawing.Point(50, 0);
            this.projectTabControl.Name = "projectTabControl";
            this.projectTabControl.SelectedIndex = 0;
            this.projectTabControl.Size = new System.Drawing.Size(484, 461);
            this.projectTabControl.TabIndex = 2;
            // 
            // YourProjects
            // 
            this.YourProjects.AccessibleName = "Your Projects";
            this.YourProjects.Controls.Add(this._yourProjectListDataGridView);
            this.YourProjects.Location = new System.Drawing.Point(4, 35);
            this.YourProjects.Margin = new System.Windows.Forms.Padding(0);
            this.YourProjects.Name = "YourProjects";
            this.YourProjects.Size = new System.Drawing.Size(476, 422);
            this.YourProjects.TabIndex = 0;
            this.YourProjects.Text = "Your Projects";
            this.YourProjects.UseVisualStyleBackColor = true;
            // 
            // ManagedProjects
            // 
            this.ManagedProjects.AccessibleName = "Managed Projects";
            this.ManagedProjects.Controls.Add(this._managedProjectListDataGridView);
            this.ManagedProjects.Location = new System.Drawing.Point(4, 35);
            this.ManagedProjects.Name = "ManagedProjects";
            this.ManagedProjects.Padding = new System.Windows.Forms.Padding(3);
            this.ManagedProjects.Size = new System.Drawing.Size(476, 422);
            this.ManagedProjects.TabIndex = 1;
            this.ManagedProjects.Text = "Managed Projects";
            this.ManagedProjects.UseVisualStyleBackColor = true;
            // 
            // _managedProjectListDataGridView
            // 
            this._managedProjectListDataGridView.AccessibleName = "managedProjectListDataGridView";
            this._managedProjectListDataGridView.AllowUserToAddRows = false;
            this._managedProjectListDataGridView.AllowUserToDeleteRows = false;
            this._managedProjectListDataGridView.AllowUserToResizeColumns = false;
            this._managedProjectListDataGridView.AllowUserToResizeRows = false;
            this._managedProjectListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._managedProjectListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._managedProjectListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._managedProjectListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._managedProjectListDataGridView.ColumnHeadersVisible = false;
            this._managedProjectListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this._managedProjectListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._managedProjectListDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this._managedProjectListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._managedProjectListDataGridView.Location = new System.Drawing.Point(3, 3);
            this._managedProjectListDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this._managedProjectListDataGridView.MultiSelect = false;
            this._managedProjectListDataGridView.Name = "_managedProjectListDataGridView";
            this._managedProjectListDataGridView.ReadOnly = true;
            this._managedProjectListDataGridView.RowHeadersVisible = false;
            this._managedProjectListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._managedProjectListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this._managedProjectListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this._managedProjectListDataGridView.RowTemplate.DividerHeight = 1;
            this._managedProjectListDataGridView.RowTemplate.Height = 50;
            this._managedProjectListDataGridView.RowTemplate.ReadOnly = true;
            this._managedProjectListDataGridView.Size = new System.Drawing.Size(470, 416);
            this._managedProjectListDataGridView.TabIndex = 2;
            this._managedProjectListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._managedProjectListDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 179.6954F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // JoinedProjects
            // 
            this.JoinedProjects.AccessibleName = "Joined Projects";
            this.JoinedProjects.Controls.Add(this.joinedProjectListDataGridView);
            this.JoinedProjects.Location = new System.Drawing.Point(4, 35);
            this.JoinedProjects.Name = "JoinedProjects";
            this.JoinedProjects.Size = new System.Drawing.Size(476, 422);
            this.JoinedProjects.TabIndex = 2;
            this.JoinedProjects.Text = "Joined Projects";
            this.JoinedProjects.UseVisualStyleBackColor = true;
            // 
            // joinedProjectListDataGridView
            // 
            this.joinedProjectListDataGridView.AccessibleName = "joinedProjectListDataGridView";
            this.joinedProjectListDataGridView.AllowUserToAddRows = false;
            this.joinedProjectListDataGridView.AllowUserToDeleteRows = false;
            this.joinedProjectListDataGridView.AllowUserToResizeColumns = false;
            this.joinedProjectListDataGridView.AllowUserToResizeRows = false;
            this.joinedProjectListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.joinedProjectListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.joinedProjectListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.joinedProjectListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.joinedProjectListDataGridView.ColumnHeadersVisible = false;
            this.joinedProjectListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.joinedProjectListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.joinedProjectListDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.joinedProjectListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinedProjectListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.joinedProjectListDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.joinedProjectListDataGridView.MultiSelect = false;
            this.joinedProjectListDataGridView.Name = "joinedProjectListDataGridView";
            this.joinedProjectListDataGridView.ReadOnly = true;
            this.joinedProjectListDataGridView.RowHeadersVisible = false;
            this.joinedProjectListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinedProjectListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.joinedProjectListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.joinedProjectListDataGridView.RowTemplate.DividerHeight = 1;
            this.joinedProjectListDataGridView.RowTemplate.Height = 50;
            this.joinedProjectListDataGridView.RowTemplate.ReadOnly = true;
            this.joinedProjectListDataGridView.Size = new System.Drawing.Size(476, 422);
            this.joinedProjectListDataGridView.TabIndex = 2;
            this.joinedProjectListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.joinedProjectListDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 179.6954F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // projectListForm
            // 
            this.AccessibleName = "projectListForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.projectTabControl);
            this.Name = "projectListForm";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Text = "ProjectListForm";
            ((System.ComponentModel.ISupportInitialize)(this._yourProjectListDataGridView)).EndInit();
            this.projectTabControl.ResumeLayout(false);
            this.YourProjects.ResumeLayout(false);
            this.ManagedProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._managedProjectListDataGridView)).EndInit();
            this.JoinedProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.joinedProjectListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _yourProjectListDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;*/
        private System.Windows.Forms.TabControl projectTabControl;
        private System.Windows.Forms.TabPage YourProjects;
        private System.Windows.Forms.TabPage ManagedProjects;
        private System.Windows.Forms.TabPage JoinedProjects;
        private System.Windows.Forms.DataGridView _managedProjectListDataGridView;
        private System.Windows.Forms.DataGridView joinedProjectListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
    }
}