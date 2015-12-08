﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class ProjectDetailForm : BasicForm
    {
        private Project _project;

        public ProjectDetailForm(Project project, Panel panel) : base (panel) 
        {
            InitializeComponent();
            this._project = project;
            nameLabel.Text = project.NAME;
            descriptionLabel.Text = project.DESC;
            numberLabel.Text = project.ID.ToString();
        }
    }
}
