using System.Windows.Forms;
using GADB;

namespace GAForm
{
    public partial class ProblemForm : System.Windows.Forms.Form
    {
        public ProblemForm()
        {
            InitializeComponent();
        }

        public void Find(int problemID)
        {
            this.ConditionsBS.Filter = this.gADataSet.Conditions.ProblemIDColumn.ColumnName + "=" + problemID;

            this.DataBS.Filter = this.gADataSet.Data.ProblemIDColumn.ColumnName + "=" + problemID;
        }

        public void Set(ref GADataSet set)
        {
            this.ConditionsBS.SuspendBinding();
            this.DataBS.SuspendBinding();

            this.gADataSet.Dispose();
            this.gADataSet = null;

            this.gADataSet = set;

            this.ConditionsBS.DataSource = set;
            this.DataBS.DataSource = set;

            this.DataBS.ResumeBinding();
            this.ConditionsBS.ResumeBinding();

            this.knapConditionsDataGridView.AutoGenerateColumns = true;
            this.knapDataDataGridView.AutoGenerateColumns = true;
        }

        private void ProblemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.ConditionsBS.EndEdit();
            this.DataBS.EndEdit();
            this.Visible = false;
            e.Cancel = true;
        }
    }
}