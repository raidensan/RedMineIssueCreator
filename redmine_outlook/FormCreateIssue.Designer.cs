namespace redmine_outlook
{
    partial class FormCreateIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateIssue));
            this.tableLayoutPanelBody = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.comboBoxIssueType = new System.Windows.Forms.ComboBox();
            this.textBoxsubject = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxAssignee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanelRoot = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanelBody.SuspendLayout();
            this.tableLayoutPanelRoot.SuspendLayout();
            this.tableLayoutPanelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBody
            // 
            this.tableLayoutPanelBody.ColumnCount = 2;
            this.tableLayoutPanelBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.588957F));
            this.tableLayoutPanelBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.41104F));
            this.tableLayoutPanelBody.Controls.Add(this.comboBoxProject, 1, 0);
            this.tableLayoutPanelBody.Controls.Add(this.comboBoxIssueType, 1, 1);
            this.tableLayoutPanelBody.Controls.Add(this.textBoxsubject, 1, 2);
            this.tableLayoutPanelBody.Controls.Add(this.textBoxDescription, 1, 3);
            this.tableLayoutPanelBody.Controls.Add(this.comboBoxAssignee, 1, 4);
            this.tableLayoutPanelBody.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelBody.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelBody.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelBody.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanelBody.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBody.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanelBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelBody.Name = "tableLayoutPanelBody";
            this.tableLayoutPanelBody.RowCount = 5;
            this.tableLayoutPanelBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.310249F));
            this.tableLayoutPanelBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.864266F));
            this.tableLayoutPanelBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.00554F));
            this.tableLayoutPanelBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.67867F));
            this.tableLayoutPanelBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.864266F));
            this.tableLayoutPanelBody.Size = new System.Drawing.Size(1002, 362);
            this.tableLayoutPanelBody.TabIndex = 0;
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(89, 3);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(910, 25);
            this.comboBoxProject.TabIndex = 0;
            this.comboBoxProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxProject_SelectedIndexChanged);
            // 
            // comboBoxIssueType
            // 
            this.comboBoxIssueType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxIssueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIssueType.FormattingEnabled = true;
            this.comboBoxIssueType.Location = new System.Drawing.Point(89, 33);
            this.comboBoxIssueType.Name = "comboBoxIssueType";
            this.comboBoxIssueType.Size = new System.Drawing.Size(910, 25);
            this.comboBoxIssueType.TabIndex = 1;
            // 
            // textBoxsubject
            // 
            this.textBoxsubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxsubject.Location = new System.Drawing.Point(89, 65);
            this.textBoxsubject.Multiline = true;
            this.textBoxsubject.Name = "textBoxsubject";
            this.textBoxsubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxsubject.Size = new System.Drawing.Size(910, 59);
            this.textBoxsubject.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(89, 130);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(910, 196);
            this.textBoxDescription.TabIndex = 3;
            // 
            // comboBoxAssignee
            // 
            this.comboBoxAssignee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAssignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAssignee.FormattingEnabled = true;
            this.comboBoxAssignee.Location = new System.Drawing.Point(89, 332);
            this.comboBoxAssignee.Name = "comboBoxAssignee";
            this.comboBoxAssignee.Size = new System.Drawing.Size(910, 25);
            this.comboBoxAssignee.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Issue Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Assignee";
            // 
            // tableLayoutPanelRoot
            // 
            this.tableLayoutPanelRoot.ColumnCount = 1;
            this.tableLayoutPanelRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRoot.Controls.Add(this.tableLayoutPanelBody, 0, 1);
            this.tableLayoutPanelRoot.Controls.Add(this.tableLayoutPanelFooter, 0, 2);
            this.tableLayoutPanelRoot.Controls.Add(this.labelMessage, 0, 0);
            this.tableLayoutPanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRoot.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRoot.Name = "tableLayoutPanelRoot";
            this.tableLayoutPanelRoot.RowCount = 3;
            this.tableLayoutPanelRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanelRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.41844F));
            this.tableLayoutPanelRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81966F));
            this.tableLayoutPanelRoot.Size = new System.Drawing.Size(1008, 461);
            this.tableLayoutPanelRoot.TabIndex = 1;
            // 
            // tableLayoutPanelFooter
            // 
            this.tableLayoutPanelFooter.ColumnCount = 2;
            this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFooter.Controls.Add(this.buttonCreate, 0, 0);
            this.tableLayoutPanelFooter.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFooter.Location = new System.Drawing.Point(3, 394);
            this.tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            this.tableLayoutPanelFooter.RowCount = 1;
            this.tableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFooter.Size = new System.Drawing.Size(1002, 64);
            this.tableLayoutPanelFooter.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreate.Location = new System.Drawing.Point(3, 3);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(495, 58);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "CREATE";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(504, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(495, 58);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Location = new System.Drawing.Point(3, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(1002, 21);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCreateIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.tableLayoutPanelRoot);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormCreateIssue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create RedMine issue from mail item...";
            this.Load += new System.EventHandler(this.FormCreateIssue_Load);
            this.tableLayoutPanelBody.ResumeLayout(false);
            this.tableLayoutPanelBody.PerformLayout();
            this.tableLayoutPanelRoot.ResumeLayout(false);
            this.tableLayoutPanelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBody;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.ComboBox comboBoxIssueType;
        private System.Windows.Forms.TextBox textBoxsubject;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxAssignee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFooter;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMessage;
    }
}