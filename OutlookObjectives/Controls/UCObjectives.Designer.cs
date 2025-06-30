namespace OutlookObjectives
{

    partial class UCObjectives
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCObjectives));
            this.MenuObjective = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListObjectives = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveToOneDrive = new System.Windows.Forms.CheckBox();
            this.AllowOpenAI = new System.Windows.Forms.CheckBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.MenuObjective.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuObjective
            // 
            this.MenuObjective.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.MenuObjective.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuObjective.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuObjective.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDetails,
            this.MenuRates,
            this.toolStripSeparator1,
            this.MenuArchive,
            this.MenuActivate});
            this.MenuObjective.Name = "contextMenuStrip1";
            this.MenuObjective.Size = new System.Drawing.Size(335, 202);
            // 
            // MenuDetails
            // 
            this.MenuDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuDetails.ForeColor = System.Drawing.Color.White;
            this.MenuDetails.Name = "MenuDetails";
            this.MenuDetails.Size = new System.Drawing.Size(334, 48);
            this.MenuDetails.Text = "Objective Details";
            // 
            // MenuRates
            // 
            this.MenuRates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuRates.ForeColor = System.Drawing.Color.White;
            this.MenuRates.Name = "MenuRates";
            this.MenuRates.Size = new System.Drawing.Size(334, 48);
            this.MenuRates.Text = "Rates and Costs";
            this.MenuRates.Click += new System.EventHandler(this.MenuRates_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(331, 6);
            // 
            // MenuArchive
            // 
            this.MenuArchive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuArchive.ForeColor = System.Drawing.Color.White;
            this.MenuArchive.Name = "MenuArchive";
            this.MenuArchive.Size = new System.Drawing.Size(334, 48);
            this.MenuArchive.Text = "Archive Objective";
            this.MenuArchive.Click += new System.EventHandler(this.MenuArchive_Click);
            // 
            // MenuActivate
            // 
            this.MenuActivate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuActivate.ForeColor = System.Drawing.Color.White;
            this.MenuActivate.Name = "MenuActivate";
            this.MenuActivate.Size = new System.Drawing.Size(334, 48);
            this.MenuActivate.Text = "Activate Objective";
            this.MenuActivate.Click += new System.EventHandler(this.MenuActivate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tick_button.png");
            this.imageList1.Images.SetKeyName(1, "prohibition_button.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1236, 1824);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grpSummary);
            this.tabPage4.Location = new System.Drawing.Point(8, 55);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1220, 1761);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "  Summary  ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.splitContainer3);
            this.grpSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSummary.Location = new System.Drawing.Point(0, 0);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(1220, 1761);
            this.grpSummary.TabIndex = 0;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "groupBox3";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 55);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1220, 1761);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  Prompt  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1214, 1755);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 43);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webView);
            this.splitContainer1.Size = new System.Drawing.Size(1208, 1709);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Size = new System.Drawing.Size(1208, 75);
            this.splitContainer2.SplitterDistance = 864;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(864, 47);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.LightGray;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.ForeColor = System.Drawing.Color.Black;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1208, 1624);
            this.webView.Source = new System.Uri("http://localhost:2025/", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(8, 55);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1220, 1761);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Under Impl  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListObjectives);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 1755);
            this.panel1.TabIndex = 5;
            // 
            // ListObjectives
            // 
            this.ListObjectives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ListObjectives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListObjectives.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListObjectives.ContextMenuStrip = this.MenuObjective;
            this.ListObjectives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListObjectives.ForeColor = System.Drawing.Color.White;
            this.ListObjectives.FullRowSelect = true;
            this.ListObjectives.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListObjectives.HideSelection = false;
            this.ListObjectives.Location = new System.Drawing.Point(0, 0);
            this.ListObjectives.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.ListObjectives.MultiSelect = false;
            this.ListObjectives.Name = "ListObjectives";
            this.ListObjectives.Size = new System.Drawing.Size(1214, 1755);
            this.ListObjectives.SmallImageList = this.imageList1;
            this.ListObjectives.TabIndex = 1;
            this.ListObjectives.UseCompatibleStateImageBehavior = false;
            this.ListObjectives.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Objective";
            this.columnHeader1.Width = 295;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(8, 55);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1220, 1761);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "  Settings  ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveToOneDrive);
            this.groupBox2.Controls.Add(this.AllowOpenAI);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 184);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System";
            // 
            // SaveToOneDrive
            // 
            this.SaveToOneDrive.AutoSize = true;
            this.SaveToOneDrive.Checked = true;
            this.SaveToOneDrive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveToOneDrive.ForeColor = System.Drawing.Color.Gray;
            this.SaveToOneDrive.Location = new System.Drawing.Point(6, 110);
            this.SaveToOneDrive.Name = "SaveToOneDrive";
            this.SaveToOneDrive.Size = new System.Drawing.Size(455, 45);
            this.SaveToOneDrive.TabIndex = 1;
            this.SaveToOneDrive.Text = "Use Save Content To OneDrive";
            this.SaveToOneDrive.UseVisualStyleBackColor = true;
            // 
            // AllowOpenAI
            // 
            this.AllowOpenAI.AutoSize = true;
            this.AllowOpenAI.ForeColor = System.Drawing.Color.Gray;
            this.AllowOpenAI.Location = new System.Drawing.Point(6, 52);
            this.AllowOpenAI.Name = "AllowOpenAI";
            this.AllowOpenAI.Size = new System.Drawing.Size(502, 45);
            this.AllowOpenAI.TabIndex = 1;
            this.AllowOpenAI.Text = "Allow Online LLM, such as OpenAI";
            this.AllowOpenAI.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 43);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.webView21);
            this.splitContainer3.Size = new System.Drawing.Size(1214, 1715);
            this.splitContainer3.SplitterDistance = 75;
            this.splitContainer3.SplitterWidth = 10;
            this.splitContainer3.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.textBox2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.button2);
            this.splitContainer4.Size = new System.Drawing.Size(1214, 75);
            this.splitContainer4.SplitterDistance = 870;
            this.splitContainer4.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(870, 47);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 75);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.LightGray;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.ForeColor = System.Drawing.Color.Black;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1214, 1630);
            this.webView21.Source = new System.Uri("http://localhost:2025/summary", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // UCObjectives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "UCObjectives";
            this.Size = new System.Drawing.Size(1236, 1824);
            this.Load += new System.EventHandler(this.UCObjectives_Load);
            this.Resize += new System.EventHandler(this.UCObjectives_Resize);
            this.MenuObjective.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuObjective;
        private System.Windows.Forms.ToolStripMenuItem MenuArchive;
        private System.Windows.Forms.ToolStripMenuItem MenuActivate;
        private System.Windows.Forms.ToolStripMenuItem MenuRates;
        private System.Windows.Forms.ToolStripMenuItem MenuDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView ListObjectives;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox AllowOpenAI;
        private System.Windows.Forms.CheckBox SaveToOneDrive;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
