/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.rtf', which is part of this source code package.
 */
using redmine_outlook.Properties;
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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHost.Text))
                return;

            if (string.IsNullOrEmpty(textBoxKey.Text))
                return;

            Settings.Default.HOST = textBoxHost.Text;
            Settings.Default.API_KEY = textBoxKey.Text;
            Settings.Default.Save();

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            textBoxHost.Text = Settings.Default.HOST;
            textBoxKey.Text = Settings.Default.API_KEY;
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHost.Text))
                return;

            if (string.IsNullOrEmpty(textBoxKey.Text))
                return;

            var api = new RedMineApiHelper();
            api.Init(textBoxHost.Text, textBoxKey.Text);
            var result = api.IsConnectionSuccessful();
            MessageBox.Show(string.Format("Connection to {0} is {1}", textBoxHost.Text, result == true ? "Successful" : "Failed"));
        }

        private void textBoxKey_MouseEnter(object sender, EventArgs e)
        {
            textBoxKey.UseSystemPasswordChar = false;
        }

        private void textBoxKey_MouseLeave(object sender, EventArgs e)
        {
            textBoxKey.UseSystemPasswordChar = true;
        }
    }
}
