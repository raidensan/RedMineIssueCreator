/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.rtf', which is part of this source code package.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Redmine.Net.Api;
using System.Collections.Specialized;
using Redmine.Net.Api.Types;

namespace redmine_outlook
{
    public partial class ThisAddIn
    {
        Outlook.Explorer currentExplorer = null;
        private RibbonRedMine ribbonRedMine;
        private Controller controller;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            currentExplorer = this.Application.ActiveExplorer();
            var ribbon = ribbonRedMine as RibbonRedMine;
            ribbon.Controller = new Controller(currentExplorer);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return ribbonRedMine = new RibbonRedMine();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
