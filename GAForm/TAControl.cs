using System;
using System.Data;
using GADB;

namespace GAForm
{
    public partial class TAControl : System.Windows.Forms.UserControl
    {
        private IController IsampleControl = null;

        private GADataSet gADataSet;

        public TAControl()
        {
            InitializeComponent();
        }

        public void Set(ref GADataSet gads)
        {
            gADataSet = gads;

            this.toolStripComboBox1.ComboBox.DataSource = this.gADataSet.CrossOver;
            this.toolStripComboBox1.ComboBox.ValueMember = this.gADataSet.CrossOver.TypeColumn.ColumnName;
            this.toolStripComboBox2.ComboBox.DataSource = this.gADataSet.Mutation;
            this.toolStripComboBox2.ComboBox.ValueMember = this.gADataSet.Mutation.TypeColumn.ColumnName;
            this.toolStripComboBox3.ComboBox.DataSource = this.gADataSet.Selection;
            this.toolStripComboBox3.ComboBox.ValueMember = this.gADataSet.Selection.TypeColumn.ColumnName;
            this.toolStripComboBox4.ComboBox.DataSource = this.gADataSet.Reinsertion;
            this.toolStripComboBox4.ComboBox.ValueMember = this.gADataSet.Reinsertion.TypeColumn.ColumnName;
            this.toolStripComboBox5.ComboBox.DataSource = this.gADataSet.Termination;
            this.toolStripComboBox5.ComboBox.ValueMember = this.gADataSet.Termination.TypeColumn.ColumnName;
        }

        public int[] GetSelection ()
        {

            int[] indexes = new int[5];

            indexes[0] = this.toolStripComboBox3.SelectedIndex+1; //selection
            indexes[1] = this.toolStripComboBox1.SelectedIndex+1; //crossover
            indexes[2] = this.toolStripComboBox2.SelectedIndex+1; //mutation
            indexes[3] = this.toolStripComboBox4.SelectedIndex+1; //reinsertion
            indexes[4] = this.toolStripComboBox5.SelectedIndex+1; //temrinaion

            return indexes;

        }


        public void UpdateStrings(object sender, EventArgs e)
        {
            GADB.GADataSetTableAdapters.StringsTableAdapter sta = new GADB.GADataSetTableAdapters.StringsTableAdapter();
            sta.Update(this.gADataSet.Strings);
            sta.Dispose();
            sta = null;
        }

        public void UpdateAll(object sender, EventArgs e)
        {
            this.TAM.UpdateAll(this.gADataSet);
            //  this.TAM.UpdateAll(this.gADataSet);
            this.gADataSet.WriteXml("dataset.xml", XmlWriteMode.WriteSchema);
        }

        public void LoadDatabase(object sender, EventArgs e)
        {
            //   this.knapSolBS.Sort =  this.gADataSet.Solutions.FitnessColumn.ColumnName + ", " + this.gADataSet.Solutions.TimeSpanColumn.ColumnName + ", " + this.gADataSet.Solutions.FrequencyColumn.ColumnName + " asc";

            this.problemsTA.Fill(this.gADataSet.Problems);

            // TODO: This line of code loads data into the 'gADataSet.GA' table. You can move, or remove it, as needed.

            fillMenuItems(sender, e);
        }

        public void FillProblemData(int problemID)
        {
            this.ConditionTA.FillByID(this.gADataSet.Conditions, problemID);

            this.DataTA.FillByID(this.gADataSet.Data, problemID);

            this.SolTA.FillByID(this.gADataSet.Solutions, problemID);

            this.gATA.FillByID(this.gADataSet.GA, problemID);
        }

        private void fillMenuItems(object sender, EventArgs e)
        {
            this.crossOverTableAdapter1.Fill(this.gADataSet.CrossOver);
            this.mutationTableAdapter1.Fill(this.gADataSet.Mutation);
            this.selectionTableAdapter1.Fill(this.gADataSet.Selection);
            this.terminationTableAdapter1.Fill(this.gADataSet.Termination);
            this.reinsertionTableAdapter1.Fill(this.gADataSet.Reinsertion);
        }

        public void UpdateGA(object sender, EventArgs e)
        {
            GADB.GADataSetTableAdapters.GATableAdapter gata = new GADB.GADataSetTableAdapters.GATableAdapter();
            gata.Update(this.gADataSet.GA);
            gata.Dispose();
            gata = null;
        }

        public void UpdateSolutions(object sender, EventArgs e)
        {
            GADB.GADataSetTableAdapters.SolutionsTableAdapter solta = new GADB.GADataSetTableAdapters.SolutionsTableAdapter();
            solta.Update(this.gADataSet.Solutions);
            solta.Dispose();
            solta = null;
        }
    }
}