namespace ScreenInjection
{
    partial class CustomRibboncs : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CustomRibboncs()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.markButton = this.Factory.CreateRibbonButton();
            this.injectButton = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.bug1 = this.Factory.CreateRibbonButtonGroup();
            this.bug1Select = this.Factory.CreateRibbonButton();
            this.bug1Execute = this.Factory.CreateRibbonButton();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.bug2Select = this.Factory.CreateRibbonButton();
            this.bug2Execute = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.bug1.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.markButton);
            this.group1.Items.Add(this.injectButton);
            this.group1.Label = "range insert xml";
            this.group1.Name = "group1";
            // 
            // markButton
            // 
            this.markButton.Label = "mark";
            this.markButton.Name = "markButton";
            this.markButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.markButton_Click);
            // 
            // injectButton
            // 
            this.injectButton.Label = "inject";
            this.injectButton.Name = "injectButton";
            this.injectButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.injectButton_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.bug1);
            this.group2.Items.Add(this.buttonGroup1);
            this.group2.Label = "motorolla bugs";
            this.group2.Name = "group2";
            // 
            // bug1
            // 
            this.bug1.Items.Add(this.bug1Select);
            this.bug1.Items.Add(this.bug1Execute);
            this.bug1.Name = "bug1";
            // 
            // bug1Select
            // 
            this.bug1Select.Label = "select (1)";
            this.bug1Select.Name = "bug1Select";
            this.bug1Select.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bug1Select_Click);
            // 
            // bug1Execute
            // 
            this.bug1Execute.Label = "execute(1)";
            this.bug1Execute.Name = "bug1Execute";
            this.bug1Execute.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bug1Execute_Click);
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.bug2Select);
            this.buttonGroup1.Items.Add(this.bug2Execute);
            this.buttonGroup1.Name = "buttonGroup1";
            // 
            // bug2Select
            // 
            this.bug2Select.Label = "select(2)";
            this.bug2Select.Name = "bug2Select";
            this.bug2Select.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bug2Select_Click);
            // 
            // bug2Execute
            // 
            this.bug2Execute.Label = "execute(2)";
            this.bug2Execute.Name = "bug2Execute";
            this.bug2Execute.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bug2Execute_Click);
            // 
            // CustomRibboncs
            // 
            this.Name = "CustomRibboncs";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CustomRibboncs_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.bug1.ResumeLayout(false);
            this.bug1.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton markButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton injectButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup bug1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bug1Select;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bug1Execute;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bug2Select;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bug2Execute;
    }

    partial class ThisRibbonCollection
    {
        internal CustomRibboncs CustomRibboncs
        {
            get { return this.GetRibbon<CustomRibboncs>(); }
        }
    }
}
