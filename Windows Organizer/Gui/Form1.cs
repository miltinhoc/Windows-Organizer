using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Windows_Organizer
{
    public partial class Form1 : Form
    {
        private RuleManager ruleManager;
        private Organizer organizer;

        private const string status_done = "Ready";
        private const string status_working = "Organizing...";

        public Form1() => InitializeComponent();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BwOrganize_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach(Rule rule in RuleManager.GetRules())
            {
                organizer.Organize(rule);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ResizeTable()
        {
            for (int i = 0; i <= RulesTable.Columns.Count - 1; i++)
            {
                RulesTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colw = RulesTable.Columns[i].Width;

                RulesTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                RulesTable.Columns[i].Width = colw;
            }
        }

        private void ChangeStatus(string message)
        {
            switch (message)
            {
                case status_done:
                    ToolTipStatus.Image = Properties.Resources.gearStatic;
                    ToolTipStatus.Text = status_done;
                    break;
                case status_working:
                    ToolTipStatus.Image = Properties.Resources.Gear_0_2s_21px;
                    ToolTipStatus.Text = status_working;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BwOrganize_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("Done!");
            ChangeStatus(status_done);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ruleManager = new RuleManager();
            organizer = new Organizer();

            FillTable();
            ResizeTable();

            AddEventHandlers();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillTable()
        {
            //RulesTable.DataSource = RuleManager.GetRules();

            foreach(Rule rule in RuleManager.GetRules())
            {
                AddRuleToDatagrid(rule);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rule"></param>
        private void AddRuleToDatagrid(Rule rule) => RulesTable.Rows.Add(rule.SearchDirectory, rule.TargetDirectory, rule.SearchTopOnly, rule.Extension);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateRule_OnNewRule(object sender, ProgressEventArgs e)
        {
            bool added = ruleManager.AddRule(e.Rule);

            if (added)
            {
                AddRuleToDatagrid(e.Rule);
                ResizeTable();
                return;
            }

            MessageBox.Show("Error adding the rule!", "Windows Organizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddEventHandlers()
        {
            RulesTable.UserDeletingRow += RulesTable_UserDeletingRow;
            RulesTable.CellValueChanged += RulesTable_CellValueChanged1;
            RulesTable.CellMouseUp += RulesTable_CellMouseUp;
        }

        private void RulesTable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                RulesTable.EndEdit();
            }
        }

        private void RulesTable_CellValueChanged1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {

            }
            
        }

        private void RulesTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!ruleManager.RemoveRuleByIndex(e.Row.Index))
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = RulesTable.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                if (ruleManager.RemoveRuleByIndex(RulesTable.SelectedRows[0].Index))
                {
                    RulesTable.Rows.RemoveAt(RulesTable.SelectedRows[0].Index);
                }
            }
        }

        private void ToolTipBtnOrganize_Click(object sender, EventArgs e)
        {
            ChangeStatus(status_working);
            BwOrganize.RunWorkerAsync();
        }

        private void ToolTipBtnCreateRule_Click(object sender, EventArgs e)
        {
            CreateRule createRule = new CreateRule();

            createRule.OnNewRule += CreateRule_OnNewRule;
            createRule.ShowDialog();
        }

        private void ToolTipBtnSmartOrganize_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Created by: miltinhoc", "Windows Organizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        private void duplicateRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
