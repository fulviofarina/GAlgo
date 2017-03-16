using GADB;
using GADB.GADataSetTableAdapters;

namespace GAForm
{
    partial class TAControl
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
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox5 = new System.Windows.Forms.ToolStripComboBox();
            this.DataTA = new GADB.GADataSetTableAdapters.DataTableAdapter();
            this.TAM = new GADB.GADataSetTableAdapters.TableAdapterManager();
            this.ConditionTA = new GADB.GADataSetTableAdapters.ConditionsTableAdapter();
            this.crossOverTableAdapter1 = new GADB.GADataSetTableAdapters.CrossOverTableAdapter();
            this.gATA = new GADB.GADataSetTableAdapters.GATableAdapter();
            this.mutationTableAdapter1 = new GADB.GADataSetTableAdapters.MutationTableAdapter();
            this.problemsTA = new GADB.GADataSetTableAdapters.ProblemsTableAdapter();
            this.reinsertionTableAdapter1 = new GADB.GADataSetTableAdapters.ReinsertionTableAdapter();
            this.selectionTableAdapter1 = new GADB.GADataSetTableAdapters.SelectionTableAdapter();
            this.SolTA = new GADB.GADataSetTableAdapters.SolutionsTableAdapter();
            this.StringsTA = new GADB.GADataSetTableAdapters.StringsTableAdapter();
            this.terminationTableAdapter1 = new GADB.GADataSetTableAdapters.TerminationTableAdapter();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crossOverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reinsertionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn34.HeaderText = "ID";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            this.dataGridViewTextBoxColumn34.Width = 49;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripComboBox3,
            this.crossOverToolStripMenuItem,
            this.toolStripComboBox1,
            this.mutationToolStripMenuItem,
            this.toolStripComboBox2,
            this.reinsertionToolStripMenuItem,
            this.toolStripComboBox4,
            this.terminationToolStripMenuItem,
            this.toolStripComboBox5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 29);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 29);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 29);
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 29);
            // 
            // toolStripComboBox5
            // 
            this.toolStripComboBox5.Name = "toolStripComboBox5";
            this.toolStripComboBox5.Size = new System.Drawing.Size(121, 29);
            // 
            // DataTA
            // 
            this.DataTA.ClearBeforeFill = true;
            // 
            // TAM
            // 
            this.TAM.BackupDataSetBeforeUpdate = false;
            this.TAM.ConditionsTableAdapter = this.ConditionTA;
            this.TAM.CrossOverTableAdapter = this.crossOverTableAdapter1;
            this.TAM.DataTableAdapter = this.DataTA;
            this.TAM.GATableAdapter = this.gATA;
            this.TAM.MutationTableAdapter = this.mutationTableAdapter1;
            this.TAM.ProblemsTableAdapter = this.problemsTA;
            this.TAM.ReinsertionTableAdapter = this.reinsertionTableAdapter1;
            this.TAM.SelectionTableAdapter = this.selectionTableAdapter1;
            this.TAM.SolutionsTableAdapter = this.SolTA;
            this.TAM.StringsTableAdapter = this.StringsTA;
            this.TAM.TerminationTableAdapter = this.terminationTableAdapter1;
            this.TAM.UpdateOrder = GADB.GADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ConditionTA
            // 
            this.ConditionTA.ClearBeforeFill = true;
            // 
            // crossOverTableAdapter1
            // 
            this.crossOverTableAdapter1.ClearBeforeFill = true;
            // 
            // gATA
            // 
            this.gATA.ClearBeforeFill = true;
            // 
            // mutationTableAdapter1
            // 
            this.mutationTableAdapter1.ClearBeforeFill = true;
            // 
            // problemsTA
            // 
            this.problemsTA.ClearBeforeFill = true;
            // 
            // reinsertionTableAdapter1
            // 
            this.reinsertionTableAdapter1.ClearBeforeFill = true;
            // 
            // selectionTableAdapter1
            // 
            this.selectionTableAdapter1.ClearBeforeFill = true;
            // 
            // SolTA
            // 
            this.SolTA.ClearBeforeFill = true;
            // 
            // StringsTA
            // 
            this.StringsTA.ClearBeforeFill = true;
            // 
            // terminationTableAdapter1
            // 
            this.terminationTableAdapter1.ClearBeforeFill = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 29);
            this.toolStripMenuItem1.Text = "Selection";
            // 
            // crossOverToolStripMenuItem
            // 
            this.crossOverToolStripMenuItem.Name = "crossOverToolStripMenuItem";
            this.crossOverToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.crossOverToolStripMenuItem.Text = "Cross-Over";
            // 
            // mutationToolStripMenuItem
            // 
            this.mutationToolStripMenuItem.Name = "mutationToolStripMenuItem";
            this.mutationToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.mutationToolStripMenuItem.Text = "Mutation";
            // 
            // reinsertionToolStripMenuItem
            // 
            this.reinsertionToolStripMenuItem.Name = "reinsertionToolStripMenuItem";
            this.reinsertionToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.reinsertionToolStripMenuItem.Text = "Reinsertion";
            // 
            // terminationToolStripMenuItem
            // 
            this.terminationToolStripMenuItem.Name = "terminationToolStripMenuItem";
            this.terminationToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.terminationToolStripMenuItem.Text = "Termination";
            // 
            // TAControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Name = "TAControl";
            this.Size = new System.Drawing.Size(1109, 43);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataTableAdapter DataTA;
        private TableAdapterManager TAM;
        private SolutionsTableAdapter SolTA;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private GATableAdapter gATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private ProblemsTableAdapter problemsTA;
        private ConditionsTableAdapter ConditionTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private StringsTableAdapter StringsTA;
        private CrossOverTableAdapter crossOverTableAdapter1;
        private MutationTableAdapter mutationTableAdapter1;
        private ReinsertionTableAdapter reinsertionTableAdapter1;
        private SelectionTableAdapter selectionTableAdapter1;
        private TerminationTableAdapter terminationTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crossOverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reinsertionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminationToolStripMenuItem;
    }
}

