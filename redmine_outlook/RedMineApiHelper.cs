/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.rtf', which is part of this source code package.
 */
using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redmine_outlook
{
    /// <summary>
    /// Helper class, acts as gateway between RedMine-net API and Add-in
    /// </summary>
    public class RedMineApiHelper
    {
        /// <summary>
        /// API Key
        /// </summary>
        public string ApiKey { get; private set; }
        /// <summary>
        /// Address or name of host
        /// </summary>
        public string Host { get; private set; }

        /// <summary>
        /// RedMine-net API manager
        /// </summary>
        RedmineManager manager;

        /// <summary>
        /// List of projects
        /// </summary>
        List<Views.Project> projects;

        /// <summary>
        /// List of assignees of project
        /// </summary>
        List<Views.Assignee> assignees;

        /// <summary>
        /// List of trackers of project
        /// </summary>
        List<Views.Tracker> trackers;

        /// <summary>
        /// Initializes API, must be called prior to any operation
        /// </summary>
        /// <param name="host">Address or name of host</param>
        /// <param name="apiKey">API Key</param>
        public void Init(string host, string apiKey)
        {
            this.ApiKey = apiKey;
            this.Host = host;
            manager = new RedmineManager(host, apiKey);
            projects = new List<Views.Project>();
            trackers = new List<Views.Tracker>();
            assignees = new List<Views.Assignee>();
        }

        /// <summary>
        /// Returns a List of projects from RedMine where user have permission
        /// Note: Only returns projects that user have permission.
        /// </summary>
        /// <returns>List of projects user have permission</returns>
        public List<Views.Project> GetProjects()
        {
            var host = Host;
            var apiKey = ApiKey;
            Init(host, apiKey);

            var parameters = new NameValueCollection { { RedmineKeys.INCLUDE, RedmineKeys.PROJECTS } };
            var prjects = manager.GetObjects<Redmine.Net.Api.Types.Project>();

            projects.Clear();

            foreach (var project in prjects)
            {
                projects.Add(new Views.Project() { Id=project.Id, Name=project.Name });
            }

            return projects;
        }

        /// <summary>
        /// Returns a list of Assignee from RedMine that are members of given project
        /// </summary>
        /// <param name="projectId">Project Id to get assignee from</param>
        /// <returns>Returns a list of Assignee from RedMine that are members of given project</returns>
        public List<Views.Assignee> GetAssignees(int projectId)
        {
            var host = Host;
            var apiKey = ApiKey;
            Init(host, apiKey);

            var parameters = new NameValueCollection { { RedmineKeys.PROJECT_ID, projectId.ToString() } };
            parameters.Add(RedmineKeys.INCLUDE, RedmineKeys.MEMBERSHIPS);
            var prjects = manager.GetObjects<Redmine.Net.Api.Types.ProjectMembership>(parameters);

            assignees.Clear();

            foreach (var project in prjects)
            {
                if (project.User == null)
                    continue;

                assignees.Add(new Views.Assignee() { Id = project.User.Id, Name = project.User.Name });
            }

            return assignees;
        }

        public List<Views.Tracker> GetTrackers(int projectId)
        {
            var host = Host;
            var apiKey = ApiKey;
            Init(host, apiKey);

            var parameters = new NameValueCollection { { RedmineKeys.INCLUDE, RedmineKeys.TRACKERS } };
            try
            {
                var prjects = manager.GetObjects<Redmine.Net.Api.Types.Tracker>();

                trackers.Clear();

                foreach (var project in prjects)
                {
                    trackers.Add(new Views.Tracker() { Id = project.Id, Name = project.Name });
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return trackers;
        }

        public void CreateIssue(int projectId, int trackerId, string subject, string desc, int assigneeId)
        {
            var host = Host;
            var apiKey = ApiKey;
            Init(host, apiKey);
            
            Issue issue = new Issue();
            issue.Project = new IdentifiableName() { Id = projectId};
            issue.Subject = subject;
            issue.Description = desc;
            issue.Tracker = new IdentifiableName() { Id = trackerId };
            issue.AssignedTo = new IdentifiableName() { Id = assigneeId };

            try
            {
                Issue savedIssue = manager.CreateObject(issue);
            }
            catch (Redmine.Net.Api.Exceptions.RedmineException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public bool IsConnectionSuccessful()
        {
            bool result = true;
            try
            {
                manager = new RedmineManager(this.Host, this.ApiKey);
            }
            catch(Redmine.Net.Api.Exceptions.RedmineException ex)
            {
                result = false;
            }
            return result;
        }

    }
}
