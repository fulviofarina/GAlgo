using System;
using System.Data;
using System.Windows.Forms;
using GADB;

namespace GAForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        /// <summary>
        /// A MOUSE EVENT ARGUMENT
        /// </summary>
        private static MouseEventArgs MOUSEVENT = new MouseEventArgs(MouseButtons.Left, 2, 0, 0, 0);

        /// <summary>
        /// A DATAGRID SELECTED ROW CALL
        /// </summary>
        private static DataGridViewCellMouseEventArgs DGVARGUMENTDUMMY = new DataGridViewCellMouseEventArgs(0, 0, 0, 0, MOUSEVENT);

        public void FillExternalProblems(ref DataRow[] problems, string field, string fieldID, int minSize, int maxSize, int nrOfIters)
        {
            this.gADataSet.FillExternalProblems(ref problems, field, fieldID, minSize, maxSize, nrOfIters);
        }

        /// <summary>
        /// Controller to Employ
        /// </summary>
        public IController IControl = null;

        /// <summary>
        /// A form for the problem Data and Conditions
        /// </summary>
        private ProblemForm pform;

        public Form()
        {
            InitializeComponent();

            // taControl1 = new TAControl();
            taControl1.Set(ref gADataSet);

            this.resumebtn.Enabled = false;
            this.stopbtn.Enabled = false;

            pform = new ProblemForm();
            pform.Set(ref this.gADataSet);
            pform.FormClosing += this.knapDataBindingNavigatorSaveItem_Click;
        }

        public void Go(object sender, EventArgs e)
        {
            this.Validate();

            GADataSet.ProblemsRow currentProblem = (this.problemsBS.Current as DataRowView).Row as GADataSet.ProblemsRow;

            int MINSIZE = 8; //dummy value
            int MAXSIZE = 16; //dummy value
            int ITERS = 5;
            //MIN SIZE OF CHROMOSOME TO ITERATE
            MINSIZE = currentProblem.MinSize;
            //MAX SIZE OF CHROMOSOME TO ITERATE
            MAXSIZE = currentProblem.MaxSize;
            ITERS = currentProblem.Iters;

            int ITERCOUNTER = 1;

            do
            {
                this.gobtn.Enabled = false;
                this.stopbtn.Enabled = true;

                Probabilities prob = setProbabilities();

                this.toolStripProgressBar1.Maximum = prob.maxPop;
                this.toolStripProgressBar1.Step = 1;
                this.toolStripProgressBar1.Value = 0;
                this.toolStripProgressBar1.Minimum = 0;

                //genetic algorithRow
                GADataSet.GARow currentGARow = null;
                currentGARow = this.gADataSet.GA.NewGARow();
                this.gADataSet.GA.AddGARow(currentGARow);

                currentGARow.ProblemID = currentProblem.ProblemID;
                currentGARow.ChromosomeLength = MINSIZE;
                //create knapRow

                taControl1.UpdateGA(sender, e);

                this.SolBS.Filter = this.gADataSet.Solutions.GAIDColumn
                    .ColumnName + "=" + currentGARow.ID;
                this.SolBS.Sort = this.gADataSet.Solutions.FitnessColumn
                    .ColumnName + " desc";

                int[] selection = taControl1.GetSelection();
                Configuration Configuration = new Configuration(selection[0], selection[1], selection[2], selection[3], selection[4]);
                ///CUT HERE
                // IsampleControl= new KnapController();

                IControl.SetControllerFor(ref currentProblem, MINSIZE);
                IControl.Probabilities = prob;
                IControl.Config = Configuration;
                IControl.GARow = currentGARow;

                IControl.RunConfiguration();

                //refresh progress bar
                IControl.CallBack = delegate
                {
                    Application.DoEvents();
                    this.toolStripProgressBar1.PerformStep();
                };

                //UPDATE DATABASES
                IControl.SaveCallBack = delegate
                {
                    taControl1.UpdateGA(sender, e);
                    taControl1.UpdateSolutions(sender, e);
                };
                //UPDATE DATABASES
                IControl.FinalCallBack = delegate
                {
                    taControl1.UpdateStrings(sender, e);
                    dgvDoubleMouseclick(this.SolutionsDataGridView, new DataGridViewCellMouseEventArgs(0, 0, 0, 0, MOUSEVENT));
                };

                //   IsampleControl.ConfigGA();

                //no BKG worker for now...
                IControl.PostScript(false);

                //ABORT IF STOPPED
                if (!stopbtn.Enabled) break;

                this.gobtn.Enabled = true;
                this.stopbtn.Enabled = false;

                if (ITERCOUNTER < ITERS)
                {
                    ITERCOUNTER++;
                }
                else
                {
                    ITERCOUNTER = 1;
                    MINSIZE++; //ADD SIZE OF CHROMOSOME NEXT GENETIC ALGORITHM
                }
            }
            while (MINSIZE <= MAXSIZE);
        }

        public void FillExternalData(int problemID, int[] subProblemIDs)
        {
            this.gADataSet.FillExternalData(problemID, subProblemIDs);
        }

        private Probabilities setProbabilities()
        {
            int MINPOP = 10; //dummy value
            int MAXPOP = 20; //dummy value
            float MUTPROB = 0.1f; //dummy value
            float CROSSPROB = 0.75f; //dummy value

            MINPOP = int.Parse(minPopbox.Text);
            MAXPOP = int.Parse(maxPopBox.Text);
            MUTPROB = float.Parse(mutProbbox.Text);
            CROSSPROB = float.Parse(crossProbbox.Text);

            return new Probabilities(MINPOP, MAXPOP, MUTPROB, CROSSPROB);
        }

        private void knapDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.SolBS.EndEdit();
            this.gABS.EndEdit();
            this.problemsBS.EndEdit();

            taControl1.UpdateAll(sender, e);
        }

        private void fillMissingColumns()
        {
            string relation = "KnapStrings_Solutions";
            this.SolutionsDataGridView.AutoGenerateColumns = true;
            foreach (DataColumn c in gADataSet.Strings.Columns)
            {
                if (!c.ColumnName.Contains("ID"))
                {
                    string str = "Parent(" + relation + ")." + c.ColumnName;
                    this.gADataSet.Solutions.Columns.Add(new DataColumn(c.ColumnName, c.DataType, str));
                }
            }
        }

        private void KnapForm_Load(object sender, EventArgs e)
        {
            //   this.knapSolBS.Sort =  this.gADataSet.Solutions.FitnessColumn.ColumnName + ", " + this.gADataSet.Solutions.TimeSpanColumn.ColumnName + ", " + this.gADataSet.Solutions.FrequencyColumn.ColumnName + " asc";
            fillMissingColumns();

            taControl1.LoadDatabase(sender, e);

            dgvDoubleMouseclick(this.problemsDataGridView, DGVARGUMENTDUMMY);
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            bool stop = false;
            if (sender.Equals(this.stopbtn))
            {
                this.gobtn.Enabled = true;
                this.resumebtn.Enabled = true;
                this.stopbtn.Enabled = false;
                stop = true;
            }
            else
            {
                this.resumebtn.Enabled = false;
                this.stopbtn.Enabled = true;
                this.gobtn.Enabled = false;
                stop = false;
            }

            IControl.StopResume(stop);
        }

        private void dgvDoubleMouseclick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView dgv = (sender as DataGridView);
            if (dgv.Rows.Count == 0) return;

            dynamic dgvr = dgv.Rows[e.RowIndex].DataBoundItem;

            if (dgvr == null) return;

            if (sender.Equals(this.problemsDataGridView))
            {
                GADataSet.ProblemsRow currentProblem = dgvr.Row as GADataSet.ProblemsRow;

                //   this.ConditionsBS.Filter = this.gADataSet.Conditions.ProblemIDColumn.ColumnName + "=" + currentProblem.ProblemID;

                //   this.DataBS.Filter = this.gADataSet.Data.ProblemIDColumn.ColumnName + "=" + currentProblem.ProblemID;

                this.gABS.SuspendBinding();

                this.SolBS.SuspendBinding();

                taControl1.FillProblemData(currentProblem.ProblemID);

                this.gABS.Filter = this.gADataSet.GA.ProblemIDColumn.ColumnName + "=" + currentProblem.ProblemID;
                this.gABS.Sort = this.gADataSet.GA.IDColumn.ColumnName + " desc";

                this.SolBS.Filter = this.gADataSet.Solutions.ProblemIDColumn.ColumnName + "=" + currentProblem.ProblemID;

                this.SolBS.Sort = this.gADataSet.Solutions.ChromosomeLengthColumn.ColumnName + " desc";

                this.gABS.ResumeBinding();
                this.SolBS.ResumeBinding();

                pform.Find(currentProblem.ProblemID);
                pform.Show();
            }
            else if (sender.Equals(this.gADataGridView))
            {
                GADataSet.GARow currentGARow = null;
                currentGARow = dgvr.Row as GADataSet.GARow;

                this.SolBS.Filter = this.gADataSet.Solutions.GAIDColumn.ColumnName + "=" + currentGARow.ID;

                this.SolBS.Sort = this.gADataSet.Solutions.FitnessColumn.ColumnName + " desc";
            }
            else if (sender.Equals(this.SolutionsDataGridView))
            {
                GADataSet.SolutionsRow sol = dgvr.Row as GADataSet.SolutionsRow;
                if (sol.IsChromosomeNull()) return;
                System.IO.File.WriteAllBytes("current.gif", sol.Chromosome);
                picBox.ImageLocation = "current.gif";
                picBox.Refresh();
            }
        }

        private void statsbtn_Click(object sender, EventArgs e)
        {
            DataRowView rv = this.problemsBS.Current as DataRowView;
            GADataSet.ProblemsRow p = rv.Row as GADataSet.ProblemsRow;

            Aid.DoStatistics<GADataSet.ProblemsRow>(p);
            Application.DoEvents();
            taControl1.UpdateAll(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.toolStripButton1.Text.CompareTo("Faster") == 0)
            {
                this.SolutionsDataGridView.Visible = false;
                this.toolStripButton1.Text = ("Slower");
            }
            else
            {
                this.toolStripButton1.Text = ("Faster");
                this.SolutionsDataGridView.Visible = true;
            }
        }
    }
}