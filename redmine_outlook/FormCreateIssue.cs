/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.rtf', which is part of this source code package.
 */
using redmine_outlook.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redmine_outlook
{
    public partial class FormCreateIssue : Form
    {
        Controller controller;

        public FormCreateIssue(string subject, string description, Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.textBoxsubject.Text = subject;
            this.textBoxDescription.Text = description;
            controller.Load();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            controller.CreateIssue((int)comboBoxProject.SelectedValue,
                (int)comboBoxIssueType.SelectedValue,
                textBoxsubject.Text,
                textBoxDescription.Text,
                (int)comboBoxAssignee.SelectedValue);

            this.Close();
        }

        private void FormCreateIssue_Load(object sender, EventArgs e)
        {
            FillCombo();

            labelMessage.Text = "For obvious security concers, links are removed";
        }

        private void FillCombo()
        {
            comboBoxProject.ValueMember = "Id";
            comboBoxProject.DisplayMember = "Name";
            comboBoxProject.DataSource = controller.Projects;

            comboBoxIssueType.ValueMember = "Id";
            comboBoxIssueType.DisplayMember = "Name";
            comboBoxIssueType.DataSource = controller.IssueTypes;

            comboBoxAssignee.ValueMember = "Id";
            comboBoxAssignee.DisplayMember = "Name";
            comboBoxAssignee.DataSource = controller.Assignees;
        }

        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.LoadIssueCategories((int)comboBoxProject.SelectedValue);
            controller.LoadAssignees((int)comboBoxProject.SelectedValue);

            FillCombo();
        }
    }
}
