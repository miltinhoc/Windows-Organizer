
namespace Windows_Organizer
{
    partial class CreateRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRule));
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.FolderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.TxtSearchDirectory = new System.Windows.Forms.TextBox();
            this.BtnBrowseSD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxTopOnly = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBrowseOD = new System.Windows.Forms.Button();
            this.TxtOutputDirectory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDirectoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExtension = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(428, 223);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(509, 223);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtSearchDirectory
            // 
            this.TxtSearchDirectory.Location = new System.Drawing.Point(107, 24);
            this.TxtSearchDirectory.Name = "TxtSearchDirectory";
            this.TxtSearchDirectory.Size = new System.Drawing.Size(429, 20);
            this.TxtSearchDirectory.TabIndex = 2;
            // 
            // BtnBrowseSD
            // 
            this.BtnBrowseSD.Location = new System.Drawing.Point(542, 22);
            this.BtnBrowseSD.Name = "BtnBrowseSD";
            this.BtnBrowseSD.Size = new System.Drawing.Size(42, 23);
            this.BtnBrowseSD.TabIndex = 3;
            this.BtnBrowseSD.Text = "...";
            this.BtnBrowseSD.UseVisualStyleBackColor = true;
            this.BtnBrowseSD.Click += new System.EventHandler(this.BtnBrowseSD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Directory:";
            // 
            // CheckBoxTopOnly
            // 
            this.CheckBoxTopOnly.AutoSize = true;
            this.CheckBoxTopOnly.Location = new System.Drawing.Point(109, 63);
            this.CheckBoxTopOnly.Name = "CheckBoxTopOnly";
            this.CheckBoxTopOnly.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxTopOnly.TabIndex = 5;
            this.CheckBoxTopOnly.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Top only?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output Directory:";
            // 
            // BtnBrowseOD
            // 
            this.BtnBrowseOD.Location = new System.Drawing.Point(542, 91);
            this.BtnBrowseOD.Name = "BtnBrowseOD";
            this.BtnBrowseOD.Size = new System.Drawing.Size(42, 23);
            this.BtnBrowseOD.TabIndex = 8;
            this.BtnBrowseOD.Text = "...";
            this.BtnBrowseOD.UseVisualStyleBackColor = true;
            this.BtnBrowseOD.Click += new System.EventHandler(this.BtnBrowseOD_Click);
            // 
            // TxtOutputDirectory
            // 
            this.TxtOutputDirectory.Location = new System.Drawing.Point(107, 93);
            this.TxtOutputDirectory.Name = "TxtOutputDirectory";
            this.TxtOutputDirectory.Size = new System.Drawing.Size(429, 20);
            this.TxtOutputDirectory.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Directory name:";
            // 
            // TxtDirectoryName
            // 
            this.TxtDirectoryName.Location = new System.Drawing.Point(107, 128);
            this.TxtDirectoryName.Name = "TxtDirectoryName";
            this.TxtDirectoryName.Size = new System.Drawing.Size(429, 20);
            this.TxtDirectoryName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Extension:";
            // 
            // TxtExtension
            // 
            this.TxtExtension.Location = new System.Drawing.Point(107, 163);
            this.TxtExtension.Name = "TxtExtension";
            this.TxtExtension.Size = new System.Drawing.Size(429, 20);
            this.TxtExtension.TabIndex = 12;
            // 
            // CreateRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 258);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtExtension);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDirectoryName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnBrowseOD);
            this.Controls.Add(this.TxtOutputDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckBoxTopOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBrowseSD);
            this.Controls.Add(this.TxtSearchDirectory);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowse;
        private System.Windows.Forms.TextBox TxtSearchDirectory;
        private System.Windows.Forms.Button BtnBrowseSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxTopOnly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBrowseOD;
        private System.Windows.Forms.TextBox TxtOutputDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDirectoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExtension;
    }
}