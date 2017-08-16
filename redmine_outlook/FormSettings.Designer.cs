namespace redmine_outlook
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.tableLayoutPanelRoot = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelBodyRoot = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelConnectionInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.tableLayoutPanelRoot.SuspendLayout();
            this.tableLayoutPanelFooter.SuspendLayout();
            this.tableLayoutPanelBodyRoot.SuspendLayout();
            this.tableLayoutPanelConnectionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelRoot
            // 
            this.tableLayoutPanelRoot.ColumnCount = 1;
            this.tableLayoutPanelRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRoot.Controls.Add(this.tableLayoutPanelFooter, 0, 1);
            this.tableLayoutPanelRoot.Controls.Add(this.tableLayoutPanelBodyRoot, 0, 0);
            this.tableLayoutPanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRoot.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRoot.Name = "tableLayoutPanelRoot";
            this.tableLayoutPanelRoot.RowCount = 2;
            this.tableLayoutPanelRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRoot.Size = new System.Drawing.Size(583, 193);
            this.tableLayoutPanelRoot.TabIndex = 0;
            // 
            // tableLayoutPanelFooter
            // 
            this.tableLayoutPanelFooter.ColumnCount = 2;
            this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFooter.Controls.Add(this.buttonSaveSettings, 0, 0);
            this.tableLayoutPanelFooter.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFooter.Location = new System.Drawing.Point(3, 147);
            this.tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            this.tableLayoutPanelFooter.RowCount = 1;
            this.tableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFooter.Size = new System.Drawing.Size(577, 43);
            this.tableLayoutPanelFooter.TabIndex = 1;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveSettings.Location = new System.Drawing.Point(3, 3);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(282, 37);
            this.buttonSaveSettings.TabIndex = 0;
            this.buttonSaveSettings.Text = "SAVE";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(291, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(283, 37);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "CLOSE";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanelBodyRoot
            // 
            this.tableLayoutPanelBodyRoot.ColumnCount = 1;
            this.tableLayoutPanelBodyRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBodyRoot.Controls.Add(this.tableLayoutPanelConnectionInfo, 0, 0);
            this.tableLayoutPanelBodyRoot.Controls.Add(this.buttonTestConnection, 0, 1);
            this.tableLayoutPanelBodyRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBodyRoot.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBodyRoot.Name = "tableLayoutPanelBodyRoot";
            this.tableLayoutPanelBodyRoot.RowCount = 2;
            this.tableLayoutPanelBodyRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.59524F));
            this.tableLayoutPanelBodyRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.40476F));
            this.tableLayoutPanelBodyRoot.Size = new System.Drawing.Size(577, 138);
            this.tableLayoutPanelBodyRoot.TabIndex = 2;
            // 
            // tableLayoutPanelConnectionInfo
            // 
            this.tableLayoutPanelConnectionInfo.ColumnCount = 2;
            this.tableLayoutPanelConnectionInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.67398F));
            this.tableLayoutPanelConnectionInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.32602F));
            this.tableLayoutPanelConnectionInfo.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelConnectionInfo.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelConnectionInfo.Controls.Add(this.textBoxHost, 1, 0);
            this.tableLayoutPanelConnectionInfo.Controls.Add(this.textBoxKey, 1, 1);
            this.tableLayoutPanelConnectionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelConnectionInfo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelConnectionInfo.Name = "tableLayoutPanelConnectionInfo";
            this.tableLayoutPanelConnectionInfo.RowCount = 2;
            this.tableLayoutPanelConnectionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelConnectionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelConnectionInfo.Size = new System.Drawing.Size(571, 63);
            this.tableLayoutPanelConnectionInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "KEY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxHost
            // 
            this.textBoxHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHost.Location = new System.Drawing.Point(92, 3);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(476, 25);
            this.textBoxHost.TabIndex = 2;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKey.Location = new System.Drawing.Point(92, 34);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(476, 25);
            this.textBoxKey.TabIndex = 3;
            this.textBoxKey.UseSystemPasswordChar = true;
            this.textBoxKey.MouseEnter += new System.EventHandler(this.textBoxKey_MouseEnter);
            this.textBoxKey.MouseLeave += new System.EventHandler(this.textBoxKey_MouseLeave);
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTestConnection.Location = new System.Drawing.Point(3, 72);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(571, 63);
            this.buttonTestConnection.TabIndex = 1;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 193);
            this.Controls.Add(this.tableLayoutPanelRoot);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RedMine Outlook Add-in Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tableLayoutPanelRoot.ResumeLayout(false);
            this.tableLayoutPanelFooter.ResumeLayout(false);
            this.tableLayoutPanelBodyRoot.ResumeLayout(false);
            this.tableLayoutPanelConnectionInfo.ResumeLayout(false);
            this.tableLayoutPanelConnectionInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFooter;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBodyRoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConnectionInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonTestConnection;
    }
}