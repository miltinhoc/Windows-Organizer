using System;
using System.IO;
using System.Windows.Forms;

namespace Windows_Organizer
{
    public partial class CreateRule : Form
    {
        public delegate void NewRuleHandler(object sender, ProgressEventArgs e);
        public event NewRuleHandler OnNewRule;

        public CreateRule() => InitializeComponent();

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (Validations())
            {
                Rule r = new Rule()
                {
                    SearchDirectory = TxtSearchDirectory.Text,
                    SearchTopOnly = CheckBoxTopOnly.Checked,
                    TargetDirectory = Path.Combine(TxtOutputDirectory.Text, TxtDirectoryName.Text),
                    Extension = TxtExtension.Text
                };

                UpdateRule(r);
                CloseForm();
            }

        }

        private bool Validations()
        {
            bool valid = true;

            if (String.IsNullOrEmpty(TxtDirectoryName.Text))
                valid = false;
            if (String.IsNullOrEmpty(TxtOutputDirectory.Text))
                valid = false;
            if (String.IsNullOrEmpty(TxtSearchDirectory.Text))
                valid = false;

            return valid;
        }

        private void CloseForm() => this.Close();

        private void UpdateRule(Rule rule)
        {
            if (OnNewRule == null) return;

            ProgressEventArgs args = new ProgressEventArgs(rule);
            OnNewRule(this, args);
        }

        private void BtnCancel_Click(object sender, EventArgs e) => this.Close();

        private void BtnBrowseSD_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    TxtSearchDirectory.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void BtnBrowseOD_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    TxtOutputDirectory.Text = folderBrowser.SelectedPath;
                }
            }
        }
    }

    public class ProgressEventArgs : EventArgs
    {
        public Rule Rule { get; private set; }

        public ProgressEventArgs(Rule rule) => Rule = rule;
        
    }
}
