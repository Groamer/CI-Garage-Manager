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
            this.CreateCar = new System.Windows.Forms.Button();
            this.ListViewCar = new System.Windows.Forms.ListView();
            this.Button10 = new System.Windows.Forms.Button();
            this.LabelItems = new System.Windows.Forms.Label();
            this.Button20 = new System.Windows.Forms.Button();
            this.Button50 = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.TextBoxPage = new System.Windows.Forms.TextBox();
            this.LabelPage = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.pictureMarkomi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarkomi)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCar
            // 
            this.CreateCar.Location = new System.Drawing.Point(713, 423);
            this.CreateCar.Name = "CreateCar";
            this.CreateCar.Size = new System.Drawing.Size(75, 23);
            this.CreateCar.TabIndex = 1;
            this.CreateCar.Text = "Create Car";
            this.CreateCar.UseVisualStyleBackColor = true;
            this.CreateCar.Click += new System.EventHandler(this.CreateCar_Click);
            // 
            // ListViewCar
            // 
            this.ListViewCar.Location = new System.Drawing.Point(12, 43);
            this.ListViewCar.Name = "ListViewCar";
            this.ListViewCar.Size = new System.Drawing.Size(615, 376);
            this.ListViewCar.TabIndex = 2;
            this.ListViewCar.UseCompatibleStateImageBehavior = false;
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(92, 12);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(30, 25);
            this.Button10.TabIndex = 3;
            this.Button10.Text = "10";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // LabelItems
            // 
            this.LabelItems.AutoSize = true;
            this.LabelItems.Location = new System.Drawing.Point(9, 18);
            this.LabelItems.Name = "LabelItems";
            this.LabelItems.Size = new System.Drawing.Size(77, 13);
            this.LabelItems.TabIndex = 4;
            this.LabelItems.Text = "Items per page";
            this.LabelItems.Click += new System.EventHandler(this.LabelItems_Click);
            // 
            // Button20
            // 
            this.Button20.Location = new System.Drawing.Point(128, 12);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(30, 25);
            this.Button20.TabIndex = 5;
            this.Button20.Text = "20";
            this.Button20.UseVisualStyleBackColor = true;
            this.Button20.Click += new System.EventHandler(this.Button20_Click);
            // 
            // Button50
            // 
            this.Button50.Location = new System.Drawing.Point(164, 12);
            this.Button50.Name = "Button50";
            this.Button50.Size = new System.Drawing.Size(30, 25);
            this.Button50.TabIndex = 6;
            this.Button50.Text = "50";
            this.Button50.UseVisualStyleBackColor = true;
            this.Button50.Click += new System.EventHandler(this.Button50_Click);
            // 
            // ButtonNext
            // 
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
            this.TextBoxPage.Location = new System.Drawing.Point(465, 15);
            this.TextBoxPage.Name = "TextBoxPage";
            this.TextBoxPage.Size = new System.Drawing.Size(30, 20);
            this.TextBoxPage.TabIndex = 9;
            this.TextBoxPage.TextChanged += new System.EventHandler(this.TextBoxPage_TextChanged);
            // 
            // LabelPage
            // 
            this.LabelPage.AutoSize = true;
            this.LabelPage.Location = new System.Drawing.Point(427, 18);
            this.LabelPage.Name = "LabelPage";
            this.LabelPage.Size = new System.Drawing.Size(32, 13);
            this.LabelPage.TabIndex = 10;
            this.LabelPage.Text = "Page";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(74, 425);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(553, 20);
            this.TextBoxSearch.TabIndex = 11;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(9, 428);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(59, 13);
            this.LabelSearch.TabIndex = 12;
            this.LabelSearch.Text = "Search car";
            // 
            // pictureMarkomi
            // 
            this.pictureMarkomi.Image = global::CI_Garage_Manager.Properties.Resources.Markomi;
            this.pictureMarkomi.Location = new System.Drawing.Point(633, 43);
            this.pictureMarkomi.Name = "pictureMarkomi";
            this.pictureMarkomi.Size = new System.Drawing.Size(155, 117);
            this.pictureMarkomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMarkomi.TabIndex = 13;
            this.pictureMarkomi.TabStop = false;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureMarkomi);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.LabelPage);
            this.Controls.Add(this.TextBoxPage);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.Button50);
            this.Controls.Add(this.Button20);
            this.Controls.Add(this.LabelItems);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.ListViewCar);
            this.Controls.Add(this.CreateCar);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarkomi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateCar;
        private System.Windows.Forms.ListView ListViewCar;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Label LabelItems;
        private System.Windows.Forms.Button Button20;
        private System.Windows.Forms.Button Button50;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.TextBox TextBoxPage;
        private System.Windows.Forms.Label LabelPage;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.PictureBox pictureMarkomi;
    }
}