using GADB;
using GADB.GADataSetTableAdapters;

namespace GAForm
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.problemsBS = new System.Windows.Forms.BindingSource(this.components);
            this.gADataSet = new GADB.GADataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.knapDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gobtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.minPopbox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.maxPopBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.mutProbbox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.crossProbbox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.stopbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.resumebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.statsbtn = new System.Windows.Forms.ToolStripButton();
            this.SolutionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Okays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chromosome = new System.Windows.Forms.DataGridViewImageColumn();
            this.Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolBS = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.gADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChromosomeLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FitnessAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FitnessStDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrossProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrossChromeMinLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mutation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reinsertion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gABS = new System.Windows.Forms.BindingSource(this.components);
            this.problemsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.taControl1 = new GAForm.TAControl();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataBN)).BeginInit();
            this.DataBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problemsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolBS)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBN
            // 
            this.DataBN.AddNewItem = this.bindingNavigatorAddNewItem;
            this.DataBN.BindingSource = this.problemsBS;
            this.DataBN.CountItem = this.bindingNavigatorCountItem;
            this.DataBN.DeleteItem = this.bindingNavigatorDeleteItem;
            this.DataBN.Dock = System.Windows.Forms.DockStyle.None;
            this.DataBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.knapDataBindingNavigatorSaveItem,
            this.gobtn,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.minPopbox,
            this.toolStripSeparator1,
            this.maxPopBox,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.mutProbbox,
            this.toolStripSeparator4,
            this.crossProbbox,
            this.toolStripSeparator6,
            this.stopbtn,
            this.toolStripSeparator5,
            this.resumebtn,
            this.toolStripSeparator7,
            this.statsbtn,
            this.toolStripSeparator8,
            this.toolStripButton1});
            this.DataBN.Location = new System.Drawing.Point(21, 58);
            this.DataBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.DataBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.DataBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.DataBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.DataBN.Name = "DataBN";
            this.DataBN.PositionItem = this.bindingNavigatorPositionItem;
            this.DataBN.Size = new System.Drawing.Size(1097, 29);
            this.DataBN.TabIndex = 0;
            this.DataBN.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // problemsBS
            // 
            this.problemsBS.DataMember = "Problems";
            this.problemsBS.DataSource = this.gADataSet;
            // 
            // gADataSet
            // 
            this.gADataSet.DataSetName = "GADataSet";
            this.gADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 26);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 29);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // knapDataBindingNavigatorSaveItem
            // 
            this.knapDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.knapDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("knapDataBindingNavigatorSaveItem.Image")));
            this.knapDataBindingNavigatorSaveItem.Name = "knapDataBindingNavigatorSaveItem";
            this.knapDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 26);
            this.knapDataBindingNavigatorSaveItem.Text = "Save Data";
            this.knapDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.knapDataBindingNavigatorSaveItem_Click);
            // 
            // gobtn
            // 
            this.gobtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.gobtn.Image = ((System.Drawing.Image)(resources.GetObject("gobtn.Image")));
            this.gobtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(34, 26);
            this.gobtn.Text = "Go";
            this.gobtn.Click += new System.EventHandler(this.Go);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 26);
            this.toolStripLabel1.Text = "Population";
            // 
            // minPopbox
            // 
            this.minPopbox.Name = "minPopbox";
            this.minPopbox.Size = new System.Drawing.Size(70, 29);
            this.minPopbox.Text = "100";
            this.minPopbox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minPopbox.ToolTipText = "Min";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // maxPopBox
            // 
            this.maxPopBox.Name = "maxPopBox";
            this.maxPopBox.Size = new System.Drawing.Size(70, 29);
            this.maxPopBox.Text = "200";
            this.maxPopBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxPopBox.ToolTipText = "Max";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(96, 26);
            this.toolStripLabel2.Text = "Probabilities";
            // 
            // mutProbbox
            // 
            this.mutProbbox.Name = "mutProbbox";
            this.mutProbbox.Size = new System.Drawing.Size(70, 29);
            this.mutProbbox.Text = "0.1";
            this.mutProbbox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mutProbbox.ToolTipText = "Muation";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // crossProbbox
            // 
            this.crossProbbox.Name = "crossProbbox";
            this.crossProbbox.Size = new System.Drawing.Size(70, 29);
            this.crossProbbox.Text = "0.75";
            this.crossProbbox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.crossProbbox.ToolTipText = "CrossOver";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // stopbtn
            // 
            this.stopbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopbtn.Image = ((System.Drawing.Image)(resources.GetObject("stopbtn.Image")));
            this.stopbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(45, 26);
            this.stopbtn.Text = "Stop";
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // resumebtn
            // 
            this.resumebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resumebtn.Image = ((System.Drawing.Image)(resources.GetObject("resumebtn.Image")));
            this.resumebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resumebtn.Name = "resumebtn";
            this.resumebtn.Size = new System.Drawing.Size(70, 26);
            this.resumebtn.Text = "Resume";
            this.resumebtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 29);
            // 
            // statsbtn
            // 
            this.statsbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statsbtn.Image = ((System.Drawing.Image)(resources.GetObject("statsbtn.Image")));
            this.statsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statsbtn.Name = "statsbtn";
            this.statsbtn.Size = new System.Drawing.Size(56, 26);
            this.statsbtn.Text = "STATS";
            this.statsbtn.Click += new System.EventHandler(this.statsbtn_Click);
            // 
            // SolutionsDataGridView
            // 
            this.SolutionsDataGridView.AllowUserToAddRows = false;
            this.SolutionsDataGridView.AllowUserToOrderColumns = true;
            this.SolutionsDataGridView.AutoGenerateColumns = false;
            this.SolutionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.SolutionsDataGridView.BackgroundColor = System.Drawing.Color.Khaki;
            this.SolutionsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SolutionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SolutionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SolutionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn18,
            this.Generations,
            this.dataGridViewTextBoxColumn16,
            this.NormFreq,
            this.dataGridViewTextBoxColumn14,
            this.Frequency,
            this.Okays,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn17,
            this.SchOrder,
            this.Chromosome,
            this.Counter,
            this.dataGridViewTextBoxColumn19});
            this.SolutionsDataGridView.DataSource = this.SolBS;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SolutionsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.SolutionsDataGridView.Location = new System.Drawing.Point(398, 409);
            this.SolutionsDataGridView.Name = "SolutionsDataGridView";
            this.SolutionsDataGridView.Size = new System.Drawing.Size(1274, 489);
            this.SolutionsDataGridView.TabIndex = 2;
            this.SolutionsDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoubleMouseclick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 49;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TimeSpan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Format = "N1";
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn18.HeaderText = "Time";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 67;
            // 
            // Generations
            // 
            this.Generations.DataPropertyName = "Generations";
            this.Generations.HeaderText = "Generations";
            this.Generations.Name = "Generations";
            this.Generations.Width = 113;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Fitness";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.Format = "N4";
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn16.HeaderText = "Fitness";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 78;
            // 
            // NormFreq
            // 
            this.NormFreq.DataPropertyName = "NormFreq";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle4.Format = "N4";
            this.NormFreq.DefaultCellStyle = dataGridViewCellStyle4;
            this.NormFreq.HeaderText = "NormFreq";
            this.NormFreq.Name = "NormFreq";
            this.NormFreq.ReadOnly = true;
            this.NormFreq.Width = 101;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Genotype";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn14.HeaderText = "Genotype";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 98;
            // 
            // Frequency
            // 
            this.Frequency.DataPropertyName = "Frequency";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Lime;
            this.Frequency.DefaultCellStyle = dataGridViewCellStyle6;
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            this.Frequency.Width = 101;
            // 
            // Okays
            // 
            this.Okays.DataPropertyName = "Okays";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Okays.DefaultCellStyle = dataGridViewCellStyle7;
            this.Okays.HeaderText = "Okays";
            this.Okays.Name = "Okays";
            this.Okays.Width = 73;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ChromosomeLength";
            this.dataGridViewTextBoxColumn7.HeaderText = "CLength";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 88;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn17.HeaderText = "Date";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 66;
            // 
            // SchOrder
            // 
            this.SchOrder.DataPropertyName = "SchOrder";
            this.SchOrder.HeaderText = "SchOrder";
            this.SchOrder.Name = "SchOrder";
            this.SchOrder.Width = 95;
            // 
            // Chromosome
            // 
            this.Chromosome.DataPropertyName = "Chromosome";
            this.Chromosome.HeaderText = "Chromosome";
            this.Chromosome.Name = "Chromosome";
            this.Chromosome.Width = 104;
            // 
            // Counter
            // 
            this.Counter.DataPropertyName = "Counter";
            this.Counter.HeaderText = "Counter";
            this.Counter.Name = "Counter";
            this.Counter.Width = 86;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ProblemID";
            this.dataGridViewTextBoxColumn19.HeaderText = "Problem ID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            this.dataGridViewTextBoxColumn19.Width = 109;
            // 
            // SolBS
            // 
            this.SolBS.DataMember = "Solutions";
            this.SolBS.DataSource = this.gADataSet;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 945);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1621, 27);
            this.statusStrip1.TabIndex = 3;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 21);
            // 
            // gADataGridView
            // 
            this.gADataGridView.AllowUserToAddRows = false;
            this.gADataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Lavender;
            this.gADataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gADataGridView.AutoGenerateColumns = false;
            this.gADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gADataGridView.BackgroundColor = System.Drawing.Color.Thistle;
            this.gADataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gADataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn33,
            this.ChromosomeLength,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn23,
            this.FitnessAvg,
            this.FitnessStDev,
            this.TimeAvg,
            this.TimeStDev,
            this.MaxTime,
            this.CrossProbability,
            this.CrossChromeMinLenght,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn22,
            this.Selection,
            this.Mutation,
            this.Reinsertion});
            this.gADataGridView.DataSource = this.gABS;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gADataGridView.DefaultCellStyle = dataGridViewCellStyle20;
            this.gADataGridView.Location = new System.Drawing.Point(398, 90);
            this.gADataGridView.Name = "gADataGridView";
            this.gADataGridView.Size = new System.Drawing.Size(1155, 302);
            this.gADataGridView.TabIndex = 4;
            this.gADataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoubleMouseclick);
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn20.HeaderText = "ID";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            this.dataGridViewTextBoxColumn20.Width = 49;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Fitness";
            dataGridViewCellStyle11.Format = "N4";
            this.dataGridViewTextBoxColumn33.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn33.HeaderText = "Fitness";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ToolTipText = "Current fitness when Running, Best fitness when averaging";
            this.dataGridViewTextBoxColumn33.Width = 78;
            // 
            // ChromosomeLength
            // 
            this.ChromosomeLength.DataPropertyName = "ChromosomeLength";
            this.ChromosomeLength.HeaderText = "CLength";
            this.ChromosomeLength.Name = "ChromosomeLength";
            this.ChromosomeLength.Width = 88;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "GenerationCurrent";
            this.dataGridViewTextBoxColumn30.HeaderText = "GCurrent";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ToolTipText = "Current Generation";
            this.dataGridViewTextBoxColumn30.Width = 92;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "GenerationTotal";
            this.dataGridViewTextBoxColumn29.HeaderText = "GTotal";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ToolTipText = "Total Generations";
            this.dataGridViewTextBoxColumn29.Width = 77;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "TimeStamp";
            dataGridViewCellStyle12.Format = "N1";
            this.dataGridViewTextBoxColumn32.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn32.HeaderText = "TS";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ToolTipText = "Time Stamp";
            this.dataGridViewTextBoxColumn32.Width = 50;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "MutationProb";
            dataGridViewCellStyle13.Format = "N4";
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn23.HeaderText = "MProb";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ToolTipText = "Mutation Probability";
            this.dataGridViewTextBoxColumn23.Width = 78;
            // 
            // FitnessAvg
            // 
            this.FitnessAvg.DataPropertyName = "FitnessAvg";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle14.Format = "N4";
            this.FitnessAvg.DefaultCellStyle = dataGridViewCellStyle14;
            this.FitnessAvg.HeaderText = "FAvg";
            this.FitnessAvg.Name = "FitnessAvg";
            this.FitnessAvg.ReadOnly = true;
            this.FitnessAvg.Width = 66;
            // 
            // FitnessStDev
            // 
            this.FitnessStDev.DataPropertyName = "FitnessStDev";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle15.Format = "N4";
            this.FitnessStDev.DefaultCellStyle = dataGridViewCellStyle15;
            this.FitnessStDev.HeaderText = "FStDev";
            this.FitnessStDev.Name = "FitnessStDev";
            this.FitnessStDev.ReadOnly = true;
            this.FitnessStDev.Width = 80;
            // 
            // TimeAvg
            // 
            this.TimeAvg.DataPropertyName = "TimeAvg";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle16.Format = "N1";
            this.TimeAvg.DefaultCellStyle = dataGridViewCellStyle16;
            this.TimeAvg.HeaderText = "TimeAvg";
            this.TimeAvg.Name = "TimeAvg";
            this.TimeAvg.ReadOnly = true;
            this.TimeAvg.Width = 93;
            // 
            // TimeStDev
            // 
            this.TimeStDev.DataPropertyName = "TimeStDev";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle17.Format = "N1";
            this.TimeStDev.DefaultCellStyle = dataGridViewCellStyle17;
            this.TimeStDev.HeaderText = "TimeStDev";
            this.TimeStDev.Name = "TimeStDev";
            this.TimeStDev.ReadOnly = true;
            this.TimeStDev.Width = 106;
            // 
            // MaxTime
            // 
            this.MaxTime.DataPropertyName = "MaxTime";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle18.Format = "N1";
            this.MaxTime.DefaultCellStyle = dataGridViewCellStyle18;
            this.MaxTime.HeaderText = "MaxTime";
            this.MaxTime.Name = "MaxTime";
            this.MaxTime.ReadOnly = true;
            this.MaxTime.Width = 95;
            // 
            // CrossProbability
            // 
            this.CrossProbability.DataPropertyName = "CrossProbability";
            dataGridViewCellStyle19.Format = "N4";
            this.CrossProbability.DefaultCellStyle = dataGridViewCellStyle19;
            this.CrossProbability.HeaderText = "CProb";
            this.CrossProbability.Name = "CrossProbability";
            this.CrossProbability.ToolTipText = "Cross Probability";
            this.CrossProbability.Width = 74;
            // 
            // CrossChromeMinLenght
            // 
            this.CrossChromeMinLenght.DataPropertyName = "CrossChromeMinLenght";
            this.CrossChromeMinLenght.HeaderText = "CCMinLenght";
            this.CrossChromeMinLenght.Name = "CrossChromeMinLenght";
            this.CrossChromeMinLenght.ToolTipText = "Cross Chromosome Min Length";
            this.CrossChromeMinLenght.Width = 122;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Termination";
            this.dataGridViewTextBoxColumn21.HeaderText = "Term";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ToolTipText = "Termination";
            this.dataGridViewTextBoxColumn21.Width = 67;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "GenerationStrategy";
            this.dataGridViewTextBoxColumn31.HeaderText = "GStrategy";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ToolTipText = "Generation Strategy";
            this.dataGridViewTextBoxColumn31.Width = 99;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "CrossParents";
            this.dataGridViewTextBoxColumn24.HeaderText = "CParents";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ToolTipText = "Coss Parents";
            this.dataGridViewTextBoxColumn24.Width = 90;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "CrossChildren";
            this.dataGridViewTextBoxColumn25.HeaderText = "CChildren";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ToolTipText = "CrossChildren";
            this.dataGridViewTextBoxColumn25.Width = 98;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "PopMin";
            this.dataGridViewTextBoxColumn27.HeaderText = "PopMin";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ToolTipText = "Population Minimum";
            this.dataGridViewTextBoxColumn27.Width = 84;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "PopMax";
            this.dataGridViewTextBoxColumn28.HeaderText = "PopMax";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ToolTipText = "Population Maximum";
            this.dataGridViewTextBoxColumn28.Width = 87;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn26.HeaderText = "Population";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ToolTipText = "Comments";
            this.dataGridViewTextBoxColumn26.Width = 105;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Crossover";
            this.dataGridViewTextBoxColumn22.HeaderText = "Crossover";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ToolTipText = "Comments";
            this.dataGridViewTextBoxColumn22.Width = 98;
            // 
            // Selection
            // 
            this.Selection.DataPropertyName = "Selection";
            this.Selection.HeaderText = "Selection";
            this.Selection.Name = "Selection";
            this.Selection.Width = 95;
            // 
            // Mutation
            // 
            this.Mutation.DataPropertyName = "Mutation";
            this.Mutation.HeaderText = "Mutation";
            this.Mutation.Name = "Mutation";
            this.Mutation.Width = 94;
            // 
            // Reinsertion
            // 
            this.Reinsertion.DataPropertyName = "Reinsertion";
            this.Reinsertion.HeaderText = "Reinsertion";
            this.Reinsertion.Name = "Reinsertion";
            this.Reinsertion.Width = 108;
            // 
            // gABS
            // 
            this.gABS.DataMember = "GA";
            this.gABS.DataSource = this.gADataSet;
            // 
            // problemsDataGridView
            // 
            this.problemsDataGridView.AutoGenerateColumns = false;
            this.problemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.problemsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.problemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.problemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.problemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.problemIDDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.minSizeDataGridViewTextBoxColumn,
            this.maxSizeDataGridViewTextBoxColumn,
            this.itersDataGridViewTextBoxColumn});
            this.problemsDataGridView.DataSource = this.problemsBS;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.problemsDataGridView.DefaultCellStyle = dataGridViewCellStyle22;
            this.problemsDataGridView.Location = new System.Drawing.Point(12, 90);
            this.problemsDataGridView.Name = "problemsDataGridView";
            this.problemsDataGridView.Size = new System.Drawing.Size(380, 449);
            this.problemsDataGridView.TabIndex = 5;
            this.problemsDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoubleMouseclick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 49;
            // 
            // problemIDDataGridViewTextBoxColumn
            // 
            this.problemIDDataGridViewTextBoxColumn.DataPropertyName = "ProblemID";
            this.problemIDDataGridViewTextBoxColumn.HeaderText = "ProblemID";
            this.problemIDDataGridViewTextBoxColumn.Name = "problemIDDataGridViewTextBoxColumn";
            this.problemIDDataGridViewTextBoxColumn.Visible = false;
            this.problemIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "Label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "Label";
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            this.labelDataGridViewTextBoxColumn.Width = 70;
            // 
            // minSizeDataGridViewTextBoxColumn
            // 
            this.minSizeDataGridViewTextBoxColumn.DataPropertyName = "MinSize";
            this.minSizeDataGridViewTextBoxColumn.HeaderText = "MinSize";
            this.minSizeDataGridViewTextBoxColumn.Name = "minSizeDataGridViewTextBoxColumn";
            this.minSizeDataGridViewTextBoxColumn.Width = 86;
            // 
            // maxSizeDataGridViewTextBoxColumn
            // 
            this.maxSizeDataGridViewTextBoxColumn.DataPropertyName = "MaxSize";
            this.maxSizeDataGridViewTextBoxColumn.HeaderText = "MaxSize";
            this.maxSizeDataGridViewTextBoxColumn.Name = "maxSizeDataGridViewTextBoxColumn";
            this.maxSizeDataGridViewTextBoxColumn.Width = 89;
            // 
            // itersDataGridViewTextBoxColumn
            // 
            this.itersDataGridViewTextBoxColumn.DataPropertyName = "Iters";
            this.itersDataGridViewTextBoxColumn.HeaderText = "Iters";
            this.itersDataGridViewTextBoxColumn.Name = "itersDataGridViewTextBoxColumn";
            this.itersDataGridViewTextBoxColumn.Width = 62;
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
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(12, 545);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(340, 353);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // taControl1
            // 
            this.taControl1.Location = new System.Drawing.Point(0, 3);
            this.taControl1.Name = "taControl1";
            this.taControl1.Size = new System.Drawing.Size(1097, 42);
            this.taControl1.TabIndex = 8;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 26);
            this.toolStripButton1.Text = "Faster";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 972);
            this.Controls.Add(this.taControl1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.problemsDataGridView);
            this.Controls.Add(this.gADataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SolutionsDataGridView);
            this.Controls.Add(this.DataBN);
            this.Name = "Form";
            this.Text = "GA - Fulvio\'s Farina Program based on GeneticSharp Library";
            this.Load += new System.EventHandler(this.KnapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBN)).EndInit();
            this.DataBN.ResumeLayout(false);
            this.DataBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problemsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolBS)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GADataSet gADataSet;
        private System.Windows.Forms.BindingNavigator DataBN;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton knapDataBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource SolBS;
        private System.Windows.Forms.DataGridView SolutionsDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripButton gobtn;
        private System.Windows.Forms.BindingSource gABS;
        private System.Windows.Forms.DataGridView gADataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox minPopbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox maxPopBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox mutProbbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox crossProbbox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton stopbtn;
        private System.Windows.Forms.ToolStripButton resumebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.BindingSource problemsBS;
        private System.Windows.Forms.DataGridView problemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton statsbtn;
        private System.Windows.Forms.PictureBox picBox;
        private TAControl taControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Generations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Okays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchOrder;
        private System.Windows.Forms.DataGridViewImageColumn Chromosome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChromosomeLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitnessAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitnessStDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrossProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrossChromeMinLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mutation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reinsertion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

