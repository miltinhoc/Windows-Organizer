
namespace Windows_Organizer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RulesTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BwOrganize = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolTipBtnCreateRule = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolTipBtnOrganize = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolTipBtnSmartOrganize = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticOrganizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolTipStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.OrganizeTimer = new System.Windows.Forms.Timer(this.components);
            this.BwSmart = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.RulesTable)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RulesTable
            // 
            this.RulesTable.AllowUserToAddRows = false;
            this.RulesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RulesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.RulesTable.ContextMenuStrip = this.contextMenuStrip1;
            this.RulesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RulesTable.Location = new System.Drawing.Point(0, 49);
            this.RulesTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RulesTable.MultiSelect = false;
            this.RulesTable.Name = "RulesTable";
            this.RulesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RulesTable.Size = new System.Drawing.Size(1073, 442);
            this.RulesTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Search Directory";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Target Directory";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Top Only";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Extension";
            this.Column4.Name = "Column4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRuleToolStripMenuItem,
            this.duplicateRuleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 48);
            // 
            // deleteRuleToolStripMenuItem
            // 
            this.deleteRuleToolStripMenuItem.Name = "deleteRuleToolStripMenuItem";
            this.deleteRuleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteRuleToolStripMenuItem.Text = "Delete Rule";
            this.deleteRuleToolStripMenuItem.Click += new System.EventHandler(this.deleteRuleToolStripMenuItem_Click);
            // 
            // duplicateRuleToolStripMenuItem
            // 
            this.duplicateRuleToolStripMenuItem.Name = "duplicateRuleToolStripMenuItem";
            this.duplicateRuleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.duplicateRuleToolStripMenuItem.Text = "Duplicate Rule";
            this.duplicateRuleToolStripMenuItem.Click += new System.EventHandler(this.duplicateRuleToolStripMenuItem_Click);
            // 
            // BwOrganize
            // 
            this.BwOrganize.WorkerReportsProgress = true;
            this.BwOrganize.WorkerSupportsCancellation = true;
            this.BwOrganize.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwOrganize_DoWork);
            this.BwOrganize.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwOrganize_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTipBtnCreateRule,
            this.toolStripSeparator1,
            this.ToolTipBtnOrganize,
            this.toolStripSeparator2,
            this.ToolTipBtnSmartOrganize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1073, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolTipBtnCreateRule
            // 
            this.ToolTipBtnCreateRule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolTipBtnCreateRule.Image = global::Windows_Organizer.Properties.Resources.ToolTipBtnCreateRule_Image;
            this.ToolTipBtnCreateRule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolTipBtnCreateRule.Name = "ToolTipBtnCreateRule";
            this.ToolTipBtnCreateRule.Size = new System.Drawing.Size(23, 22);
            this.ToolTipBtnCreateRule.Text = "New Rule";
            this.ToolTipBtnCreateRule.Click += new System.EventHandler(this.ToolTipBtnCreateRule_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolTipBtnOrganize
            // 
            this.ToolTipBtnOrganize.ForeColor = System.Drawing.Color.White;
            this.ToolTipBtnOrganize.Image = ((System.Drawing.Image)(resources.GetObject("ToolTipBtnOrganize.Image")));
            this.ToolTipBtnOrganize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolTipBtnOrganize.Name = "ToolTipBtnOrganize";
            this.ToolTipBtnOrganize.Size = new System.Drawing.Size(74, 22);
            this.ToolTipBtnOrganize.Text = "Organize";
            this.ToolTipBtnOrganize.Click += new System.EventHandler(this.ToolTipBtnOrganize_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolTipBtnSmartOrganize
            // 
            this.ToolTipBtnSmartOrganize.ForeColor = System.Drawing.Color.White;
            this.ToolTipBtnSmartOrganize.Image = global::Windows_Organizer.Properties.Resources.smart;
            this.ToolTipBtnSmartOrganize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolTipBtnSmartOrganize.Name = "ToolTipBtnSmartOrganize";
            this.ToolTipBtnSmartOrganize.Size = new System.Drawing.Size(108, 22);
            this.ToolTipBtnSmartOrganize.Text = "Smart Organize";
            this.ToolTipBtnSmartOrganize.Click += new System.EventHandler(this.ToolTipBtnSmartOrganize_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1073, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticOrganizerToolStripMenuItem,
            this.exclusionListToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // automaticOrganizerToolStripMenuItem
            // 
            this.automaticOrganizerToolStripMenuItem.Name = "automaticOrganizerToolStripMenuItem";
            this.automaticOrganizerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.automaticOrganizerToolStripMenuItem.Text = "Schedule Organizer";
            this.automaticOrganizerToolStripMenuItem.Click += new System.EventHandler(this.automaticOrganizerToolStripMenuItem_Click);
            // 
            // exclusionListToolStripMenuItem
            // 
            this.exclusionListToolStripMenuItem.Name = "exclusionListToolStripMenuItem";
            this.exclusionListToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exclusionListToolStripMenuItem.Text = "Exclusion List";
            this.exclusionListToolStripMenuItem.Click += new System.EventHandler(this.exclusionListToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTipStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1073, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolTipStatus
            // 
            this.ToolTipStatus.ForeColor = System.Drawing.Color.White;
            this.ToolTipStatus.Image = global::Windows_Organizer.Properties.Resources.gearStatic;
            this.ToolTipStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolTipStatus.Name = "ToolTipStatus";
            this.ToolTipStatus.Size = new System.Drawing.Size(56, 21);
            this.ToolTipStatus.Text = "Done";
            // 
            // OrganizeTimer
            // 
            this.OrganizeTimer.Interval = 1000;
            this.OrganizeTimer.Tick += new System.EventHandler(this.OrganizeTimer_Tick);
            // 
            // BwSmart
            // 
            this.BwSmart.WorkerReportsProgress = true;
            this.BwSmart.WorkerSupportsCancellation = true;
            this.BwSmart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwSmart_DoWork);
            this.BwSmart.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwSmart_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 517);
            this.Controls.Add(this.RulesTable);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RulesTable)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RulesTable;
        private System.ComponentModel.BackgroundWorker BwOrganize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolTipBtnCreateRule;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolTipBtnOrganize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolTipBtnSmartOrganize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolTipStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Timer OrganizeTimer;
        private System.Windows.Forms.ToolStripMenuItem automaticOrganizerToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker BwSmart;
        private System.Windows.Forms.ToolStripMenuItem exclusionListToolStripMenuItem;
    }
}

