namespace testSample
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
            this.myBarAndDockingController1 = new testSample.MyBarAndDockingController(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.tableBarItem1 = new testSample.TableBarItem();
            this.myUserControl5 = new testSample.MyUserControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.myUserControl4 = new testSample.MyUserControl();
            this.myUserControl2 = new testSample.MyUserControl();
            this.myUserControl1 = new testSample.MyUserControl();
            this.myUserControl3 = new testSample.MyUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.myBarAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Controller = this.myBarAndDockingController1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.tableBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(545, 142);
            // 
            // tableBarItem1
            // 
            this.tableBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.tableBarItem1.Caption = "Table";
            this.tableBarItem1.Id = 1;
            this.tableBarItem1.InnerPopupControl = this.myUserControl2;
            this.tableBarItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tableBarItem1.LargeGlyph")));
            this.tableBarItem1.Name = "tableBarItem1";
            this.tableBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // myUserControl5
            // 
            this.myUserControl5.Location = new System.Drawing.Point(33, 26);
            this.myUserControl5.Name = "myUserControl5";
            this.myUserControl5.Size = new System.Drawing.Size(146, 97);
            this.myUserControl5.TabIndex = 1;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "InsertTable";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.tableBarItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "TableGroup";
            // 
            // myUserControl4
            // 
            this.myUserControl4.Location = new System.Drawing.Point(33, 26);
            this.myUserControl4.Name = "myUserControl4";
            this.myUserControl4.Size = new System.Drawing.Size(146, 97);
            this.myUserControl4.TabIndex = 1;
            // 
            // myUserControl2
            // 
            this.myUserControl2.Location = new System.Drawing.Point(33, 26);
            this.myUserControl2.Name = "myUserControl2";
            this.myUserControl2.Size = new System.Drawing.Size(146, 97);
            this.myUserControl2.TabIndex = 1;
            // 
            // myUserControl1
            // 
            this.myUserControl1.Location = new System.Drawing.Point(33, 26);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(146, 97);
            this.myUserControl1.TabIndex = 1;
            // 
            // myUserControl3
            // 
            this.myUserControl3.Location = new System.Drawing.Point(33, 26);
            this.myUserControl3.Name = "myUserControl3";
            this.myUserControl3.Size = new System.Drawing.Size(146, 97);
            this.myUserControl3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 446);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myBarAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyBarAndDockingController myBarAndDockingController1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private TableBarItem tableBarItem1;
        private MyUserControl myUserControl1;
        private MyUserControl myUserControl2;
        private MyUserControl myUserControl3;
        private MyUserControl myUserControl4;
        private MyUserControl myUserControl5;








    }
}

