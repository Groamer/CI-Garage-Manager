namespace CI_Garage_Manager.Views
{
    partial class Jobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jobs));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuComputerInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelPage = new System.Windows.Forms.Label();
            this.TextBoxPage = new System.Windows.Forms.TextBox();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.Button100 = new System.Windows.Forms.Button();
            this.Button50 = new System.Windows.Forms.Button();
            this.LabelItems = new System.Windows.Forms.Label();
            this.Button20 = new System.Windows.Forms.Button();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ListViewJob = new System.Windows.Forms.ListView();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.pictureMarkomi = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarkomi)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuFile,
            this.ToolStripMenuHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuFile
            // 
            this.ToolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuSave});
            this.ToolStripMenuFile.Name = "ToolStripMenuFile";
            this.ToolStripMenuFile.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenuFile.Text = "File";
            // 
            // ToolStripMenuSave
            // 
            this.ToolStripMenuSave.Name = "ToolStripMenuSave";
            this.ToolStripMenuSave.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuSave.Text = "Save jobs";
            this.ToolStripMenuSave.Click += new System.EventHandler(this.ToolStripMenuSave_Click);
            // 
            // ToolStripMenuHelp
            // 
            this.ToolStripMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuInformation,
            this.ToolStripMenuComputerInfor});
            this.ToolStripMenuHelp.Name = "ToolStripMenuHelp";
            this.ToolStripMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuHelp.Text = "Help";
            // 
            // ToolStripMenuInformation
            // 
            this.ToolStripMenuInformation.Name = "ToolStripMenuInformation";
            this.ToolStripMenuInformation.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuInformation.Text = "Information";
            this.ToolStripMenuInformation.Click += new System.EventHandler(this.ToolStripMenuInformation_Click);
            // 
            // ToolStripMenuComputerInfor
            // 
            this.ToolStripMenuComputerInfor.Name = "ToolStripMenuComputerInfor";
            this.ToolStripMenuComputerInfor.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuComputerInfor.Text = "ComputerInfor";
            this.ToolStripMenuComputerInfor.Click += new System.EventHandler(this.ToolStripMenuComputerInfor_Click);
            // 
            // LabelPage
            // 
            this.LabelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPage.AutoSize = true;
            this.LabelPage.Location = new System.Drawing.Point(427, 33);
            this.LabelPage.Name = "LabelPage";
            this.LabelPage.Size = new System.Drawing.Size(32, 13);
            this.LabelPage.TabIndex = 18;
            this.LabelPage.Text = "Page";
            // 
            // TextBoxPage
            // 
            this.TextBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPage.Location = new System.Drawing.Point(465, 30);
            this.TextBoxPage.Name = "TextBoxPage";
            this.TextBoxPage.Size = new System.Drawing.Size(30, 20);
            this.TextBoxPage.TabIndex = 17;
            this.TextBoxPage.TextChanged += new System.EventHandler(this.TextBoxPage_TextChanged);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPrevious.Location = new System.Drawing.Point(501, 27);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(60, 25);
            this.ButtonPrevious.TabIndex = 16;
            this.ButtonPrevious.Text = "Previous";
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNext.Location = new System.Drawing.Point(567, 27);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(60, 25);
            this.ButtonNext.TabIndex = 15;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // Button100
            // 
            this.Button100.Location = new System.Drawing.Point(177, 27);
            this.Button100.Name = "Button100";
            this.Button100.Size = new System.Drawing.Size(35, 25);
            this.Button100.TabIndex = 14;
            this.Button100.Text = "100";
            this.Button100.UseVisualStyleBackColor = true;
            this.Button100.Click += new System.EventHandler(this.Button100_Click);
            // 
            // Button50
            // 
            this.Button50.Location = new System.Drawing.Point(136, 27);
            this.Button50.Name = "Button50";
            this.Button50.Size = new System.Drawing.Size(35, 25);
            this.Button50.TabIndex = 13;
            this.Button50.Text = "50";
            this.Button50.UseVisualStyleBackColor = true;
            this.Button50.Click += new System.EventHandler(this.Button50_Click);
            // 
            // LabelItems
            // 
            this.LabelItems.AutoSize = true;
            this.LabelItems.Location = new System.Drawing.Point(12, 33);
            this.LabelItems.Name = "LabelItems";
            this.LabelItems.Size = new System.Drawing.Size(74, 13);
            this.LabelItems.TabIndex = 12;
            this.LabelItems.Text = "Jobs per page";
            // 
            // Button20
            // 
            this.Button20.Location = new System.Drawing.Point(95, 27);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(35, 25);
            this.Button20.TabIndex = 11;
            this.Button20.Text = "20";
            this.Button20.UseVisualStyleBackColor = true;
            this.Button20.Click += new System.EventHandler(this.Button20_Click);
            // 
            // LabelSearch
            // 
            this.LabelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(12, 532);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(58, 13);
            this.LabelSearch.TabIndex = 22;
            this.LabelSearch.Text = "Search job";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Location = new System.Drawing.Point(76, 529);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(551, 20);
            this.TextBoxSearch.TabIndex = 21;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ListViewJob
            // 
            this.ListViewJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewJob.Location = new System.Drawing.Point(12, 58);
            this.ListViewJob.Name = "ListViewJob";
            this.ListViewJob.Size = new System.Drawing.Size(615, 465);
            this.ListViewJob.TabIndex = 20;
            this.ListViewJob.UseCompatibleStateImageBehavior = false;
            this.ListViewJob.SelectedIndexChanged += new System.EventHandler(this.ListViewJob_SelectedIndexChanged);
            this.ListViewJob.DoubleClick += new System.EventHandler(this.ListViewJob_DoubleClick);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRemove.Enabled = false;
            this.ButtonRemove.Location = new System.Drawing.Point(687, 526);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(85, 23);
            this.ButtonRemove.TabIndex = 25;
            this.ButtonRemove.Text = "Remove Job";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.Location = new System.Drawing.Point(687, 497);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(85, 23);
            this.ButtonEdit.TabIndex = 24;
            this.ButtonEdit.Text = "Edit Job";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCreate.Location = new System.Drawing.Point(687, 468);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(85, 23);
            this.ButtonCreate.TabIndex = 23;
            this.ButtonCreate.Text = "Create Job";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // pictureMarkomi
            // 
            this.pictureMarkomi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMarkomi.Image = global::CI_Garage_Manager.Properties.Resources.Markomi;
            this.pictureMarkomi.Location = new System.Drawing.Point(633, 27);
            this.pictureMarkomi.Name = "pictureMarkomi";
            this.pictureMarkomi.Size = new System.Drawing.Size(139, 127);
            this.pictureMarkomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMarkomi.TabIndex = 19;
            this.pictureMarkomi.TabStop = false;
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ListViewJob);
            this.Controls.Add(this.pictureMarkomi);
            this.Controls.Add(this.LabelPage);
            this.Controls.Add(this.TextBoxPage);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.Button100);
            this.Controls.Add(this.Button50);
            this.Controls.Add(this.LabelItems);
            this.Controls.Add(this.Button20);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Jobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jobs - CI Garage Manager";
            this.Load += new System.EventHandler(this.Jobs_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarkomi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuInformation;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuComputerInfor;
        private System.Windows.Forms.Label LabelPage;
        private System.Windows.Forms.TextBox TextBoxPage;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button Button100;
        private System.Windows.Forms.Button Button50;
        private System.Windows.Forms.Label LabelItems;
        private System.Windows.Forms.Button Button20;
        private System.Windows.Forms.PictureBox pictureMarkomi;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.ListView ListViewJob;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonCreate;
    }
}