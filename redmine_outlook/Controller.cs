/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.rtf', which is part of this source code package.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Redmine.Net.Api;
using System.Collections.Specialized;
using Redmine.Net.Api.Types;
using redmine_outlook.Properties;
using redmine_outlook.Helper;

namespace redmine_outlook
{
    public class Controller
    {
        public List<Views.Project> Projects { get; set; }
        public List<Views.Category> Categories { get; set; }
        public List<Views.Priority> Priorities { get; set; }
        public List<Views.Status> Statuses { get; set; }
        public List<Views.Assignee> Assignees { get; set; }
        public List<Views.Tracker> IssueTypes { get; set; }

        public RedMineApiHelper apiHelper { get; set; }

        public Outlook.Explorer Explorer { get; set; }

        public Controller(Outlook.Explorer explorer)
        {
            this.Explorer = explorer;
            this.apiHelper = new redmine_outlook.RedMineApiHelper();

            if (!IsSettingsPresent())
            {
                var settings = new FormSettings();
                settings.ShowDialog();
                return;
            }
            else
            {
                apiHelper.Init(Settings.Default.HOST, Settings.Default.API_KEY);
            }
        }

        private bool IsSettingsPresent()
        {
            if (string.IsNullOrEmpty(Settings.Default.API_KEY))
                return false;

            if (string.IsNullOrEmpty(Settings.Default.HOST))
                return false;

            return true;
        }

        public void Load()
        {
            Projects = apiHelper.GetProjects();
        }

        public void ShowCreateIssueForm()
        {
            if (!IsSettingsPresent())
            {
                var settings = new FormSettings();
                settings.ShowDialog();
                return;
            }

            Outlook.MAPIFolder selectedFolder =
               Explorer.CurrentFolder;

            if (this.Explorer.Selection.Count > 0)
            {
                Object selObject = this.Explorer.Selection[1];
                if (selObject is Outlook.MailItem)
                {
                    Outlook.MailItem mailItem = (selObject as Outlook.MailItem);
                    FormCreateIssue form = new FormCreateIssue(mailItem.Subject, MarkdownHelper.PrepareBody(mailItem.SenderEmailAddress,mailItem.To,mailItem.CreationTime.ToString(), mailItem.Body), this);
                    form.ShowDialog();
                }
            }
        }

        public void CreateIssue(int project, int tracker, string subject, string desc, int assignee)
        {
            if (string.IsNullOrEmpty(subject))
                throw new ArgumentException("subject cannon be empty or null!", "subject");
            if (string.IsNullOrEmpty(desc))
                throw new ArgumentException("description cannon be empty or null!", "desc");
            // TODO create issue
            apiHelper.CreateIssue(project, tracker, subject, desc, assignee);
        }

        public void LoadIssueCategories(int projectId)
        {
            IssueTypes = apiHelper.GetTrackers(projectId);
        }

        public void LoadAssignees(int projectyId)
        {
            Assignees = apiHelper.GetAssignees(projectyId);
        }
    }
}
