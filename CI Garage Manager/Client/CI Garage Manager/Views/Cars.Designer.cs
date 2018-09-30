namespace CI_Garage_Manager.Views
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.ListViewCar = new System.Windows.Forms.ListView();
            this.Button20 = new System.Windows.Forms.Button();
            this.LabelItems = new System.Windows.Forms.Label();
            this.Button50 = new System.Windows.Forms.Button();
            this.Button100 = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.TextBoxPage = new System.Windows.Forms.TextBox();
            this.LabelPage = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.CreateCar = new System.Windows.Forms.Button();
            this.pictureMarkomi = new System.Windows.Forms.PictureBox();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarkomi)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewCar
            // 
            this.ListViewCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewCar.Location = new System.Drawing.Point(12, 43);
            this.ListViewCar.Name = "ListViewCar";
            this.ListViewCar.Size = new System.Drawing.Size(615, 479);
            this.ListViewCar.TabIndex = 2;
            this.ListViewCar.UseCompatibleStateImageBehavior = false;
            this.ListViewCar.SelectedIndexChanged += new System.EventHandler(this.ListViewCar_SelectedIndexChanged);
            // 
            // Button20
            // 
            this.Button20.Location = new System.Drawing.Point(95, 12);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(35, 25);
            this.Button20.TabIndex = 3;
            this.Button20.Text = "20";
            this.Button20.UseVisualStyleBackColor = true;
            this.Button20.Click += new System.EventHandler(this.Button20_Click);
            // 
            // LabelItems
            // 
            this.LabelItems.AutoSize = true;
            this.LabelItems.Location = new System.Drawing.Point(12, 18);
            this.LabelItems.Name = "LabelItems";
            this.LabelItems.Size = new System.Drawing.Size(77, 13);
            this.LabelItems.TabIndex = 4;
            this.LabelItems.Text = "Items per page";
            this.LabelItems.Click += new System.EventHandler(this.LabelItems_Click);
            // 
            // Button50
            // 
            this.Button50.Location = new System.Drawing.Point(136, 12);
            this.Button50.Name = "Button50";
            this.Button50.Size = new System.Drawing.Size(35, 25);
            this.Button50.TabIndex = 5;
            this.Button50.Text = "50";
            this.Button50.UseVisualStyleBackColor = true;
            this.Button50.Click += new System.EventHandler(this.Button50_Click);
            // 
            // Button100
            // 
            this.Button100.Location = new System.Drawing.Point(177, 12);
            this.Button100.Name = "Button100";
            this.Button100.Size = new System.Drawing.Size(35, 25);
            this.Button100.TabIndex = 6;
            this.Button100.Text = "100";
            this.Button100.UseVisualStyleBackColor = true;
            this.Button100.Click += new System.EventHandler(this.Button100_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNext.Location = new System.Drawing.Point(567, 12);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(60, 25);
            this.ButtonNext.TabIndex = 7;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPrevious.Location = new System.Drawing.Point(501, 12);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(60, 25);
            this.ButtonPrevious.TabIndex = 8;
            this.ButtonPrevious.Text = "Previous";
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // TextBoxPage
            // 
            this.TextBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPage.Location = new System.Drawing.Point(465, 15);
            this.TextBoxPage.Name = "TextBoxPage";
            this.TextBoxPage.Size = new System.Drawing.Size(30, 20);
            this.TextBoxPage.TabIndex = 9;
            this.TextBoxPage.TextChanged += new System.EventHandler(this.TextBoxPage_TextChanged);
            // 
            // LabelPage
            // 
            this.LabelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPage.AutoSize = true;
            this.LabelPage.Location = new System.Drawing.Point(427, 18);
            this.LabelPage.Name = "LabelPage";
            this.LabelPage.Size = new System.Drawing.Size(32, 13);
            this.LabelPage.TabIndex = 10;
            this.LabelPage.Text = "Page";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Location = new System.Drawing.Point(77, 528);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(550, 20);
            this.TextBoxSearch.TabIndex = 11;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(12, 531);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(59, 13);
            this.LabelSearch.TabIndex = 12;
            this.LabelSearch.Text = "Search car";
            // 
            // CreateCar
            // 
            this.CreateCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateCar.Location = new System.Drawing.Point(687, 468);
            this.CreateCar.Name = "CreateCar";
            this.CreateCar.Size = new System.Drawing.Size(85, 23);
            this.CreateCar.TabIndex = 1;
            this.CreateCar.Text = "Create Car";
            this.CreateCar.UseVisualStyleBackColor = true;
            this.CreateCar.Click += new System.EventHandler(this.CreateCar_Click);
            // 
            // pictureMarkomi
            // 
            this.pictureMarkomi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMarkomi.Image = global::CI_Garage_Manager.Properties.Resources.Markomi;
            this.pictureMarkomi.Location = new System.Drawing.Point(633, 12);
            this.pictureMarkomi.Name = "pictureMarkomi";
            this.pictureMarkomi.Size = new System.Drawing.Size(139, 127);
            this.pictureMarkomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMarkomi.TabIndex = 13;
            this.pictureMarkomi.TabStop = false;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.Location = new System.Drawing.Point(687, 497);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(85, 23);
            this.ButtonEdit.TabIndex = 14;
            this.ButtonEdit.Text = "Edit Car";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRemove.Enabled = false;
            this.ButtonRemove.Location = new System.Drawing.Point(687, 526);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(85, 23);
            this.ButtonRemove.TabIndex = 15;
            this.ButtonRemove.Text = "Remove Car";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.pictureMarkomi);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.LabelPage);
            this.Controls.Add(this.TextBoxPage);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.Button100);
            this.Controls.Add(this.Button50);
            this.Controls.Add(this.LabelItems);
            this.Controls.Add(this.Button20);
            this.Controls.Add(this.ListViewCar);
            this.Controls.Add(this.CreateCar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars - CI Garage Manager";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarkomi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ListViewCar;
        private System.Windows.Forms.Button Button20;
        private System.Windows.Forms.Label LabelItems;
        private System.Windows.Forms.Button Button50;
        private System.Windows.Forms.Button Button100;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.TextBox TextBoxPage;
        private System.Windows.Forms.Label LabelPage;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Button CreateCar;
        private System.Windows.Forms.PictureBox pictureMarkomi;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonRemove;
    }
}