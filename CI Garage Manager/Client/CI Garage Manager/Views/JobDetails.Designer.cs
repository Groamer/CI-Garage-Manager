namespace CI_Garage_Manager.Views
{
    partial class JobDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobDetails));
            this.LabelStartDate = new System.Windows.Forms.Label();
            this.LabelEndDate = new System.Windows.Forms.Label();
            this.LabelProblem = new System.Windows.Forms.Label();
            this.LabelSolution = new System.Windows.Forms.Label();
            this.LabelMilage = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelRevenue = new System.Windows.Forms.Label();
            this.DateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.DateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.TextBoxProblem = new System.Windows.Forms.TextBox();
            this.TextBoxSolution = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TextBoxMilage = new System.Windows.Forms.TextBox();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.TextBoxRevenue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelStartDate
            // 
            this.LabelStartDate.AutoSize = true;
            this.LabelStartDate.Location = new System.Drawing.Point(12, 18);
            this.LabelStartDate.Name = "LabelStartDate";
            this.LabelStartDate.Size = new System.Drawing.Size(55, 13);
            this.LabelStartDate.TabIndex = 0;
            this.LabelStartDate.Text = "Start Date";
            // 
            // LabelEndDate
            // 
            this.LabelEndDate.AutoSize = true;
            this.LabelEndDate.Location = new System.Drawing.Point(12, 44);
            this.LabelEndDate.Name = "LabelEndDate";
            this.LabelEndDate.Size = new System.Drawing.Size(52, 13);
            this.LabelEndDate.TabIndex = 1;
            this.LabelEndDate.Text = "End Date";
            // 
            // LabelProblem
            // 
            this.LabelProblem.AutoSize = true;
            this.LabelProblem.Location = new System.Drawing.Point(12, 67);
            this.LabelProblem.Name = "LabelProblem";
            this.LabelProblem.Size = new System.Drawing.Size(45, 13);
            this.LabelProblem.TabIndex = 2;
            this.LabelProblem.Text = "Problem";
            // 
            // LabelSolution
            // 
            this.LabelSolution.AutoSize = true;
            this.LabelSolution.Location = new System.Drawing.Point(12, 223);
            this.LabelSolution.Name = "LabelSolution";
            this.LabelSolution.Size = new System.Drawing.Size(45, 13);
            this.LabelSolution.TabIndex = 3;
            this.LabelSolution.Text = "Solution";
            // 
            // LabelMilage
            // 
            this.LabelMilage.AutoSize = true;
            this.LabelMilage.Location = new System.Drawing.Point(12, 379);
            this.LabelMilage.Name = "LabelMilage";
            this.LabelMilage.Size = new System.Drawing.Size(38, 13);
            this.LabelMilage.TabIndex = 4;
            this.LabelMilage.Text = "Milage";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(12, 405);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(28, 13);
            this.LabelCost.TabIndex = 5;
            this.LabelCost.Text = "Cost";
            // 
            // LabelRevenue
            // 
            this.LabelRevenue.AutoSize = true;
            this.LabelRevenue.Location = new System.Drawing.Point(12, 431);
            this.LabelRevenue.Name = "LabelRevenue";
            this.LabelRevenue.Size = new System.Drawing.Size(51, 13);
            this.LabelRevenue.TabIndex = 6;
            this.LabelRevenue.Text = "Revenue";
            // 
            // DateTimeStart
            // 
            this.DateTimeStart.Location = new System.Drawing.Point(73, 12);
            this.DateTimeStart.Name = "DateTimeStart";
            this.DateTimeStart.Size = new System.Drawing.Size(699, 20);
            this.DateTimeStart.TabIndex = 7;
            // 
            // DateTimeEnd
            // 
            this.DateTimeEnd.Location = new System.Drawing.Point(73, 38);
            this.DateTimeEnd.Name = "DateTimeEnd";
            this.DateTimeEnd.Size = new System.Drawing.Size(699, 20);
            this.DateTimeEnd.TabIndex = 8;
            // 
            // TextBoxProblem
            // 
            this.TextBoxProblem.AcceptsReturn = true;
            this.TextBoxProblem.AcceptsTab = true;
            this.TextBoxProblem.Location = new System.Drawing.Point(73, 64);
            this.TextBoxProblem.MaxLength = 50000;
            this.TextBoxProblem.Multiline = true;
            this.TextBoxProblem.Name = "TextBoxProblem";
            this.TextBoxProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxProblem.Size = new System.Drawing.Size(699, 150);
            this.TextBoxProblem.TabIndex = 9;
            // 
            // TextBoxSolution
            // 
            this.TextBoxSolution.AcceptsReturn = true;
            this.TextBoxSolution.AcceptsTab = true;
            this.TextBoxSolution.Location = new System.Drawing.Point(73, 220);
            this.TextBoxSolution.MaxLength = 50000;
            this.TextBoxSolution.Multiline = true;
            this.TextBoxSolution.Name = "TextBoxSolution";
            this.TextBoxSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxSolution.Size = new System.Drawing.Size(699, 150);
            this.TextBoxSolution.TabIndex = 10;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(697, 526);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(616, 526);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TextBoxMilage
            // 
            this.TextBoxMilage.Location = new System.Drawing.Point(73, 376);
            this.TextBoxMilage.Name = "TextBoxMilage";
            this.TextBoxMilage.Size = new System.Drawing.Size(699, 20);
            this.TextBoxMilage.TabIndex = 13;
            this.TextBoxMilage.TextChanged += new System.EventHandler(this.TextBoxMilage_TextChanged);
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.Location = new System.Drawing.Point(73, 402);
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.Size = new System.Drawing.Size(699, 20);
            this.TextBoxCost.TabIndex = 14;
            this.TextBoxCost.TextChanged += new System.EventHandler(this.TextBoxCost_TextChanged);
            // 
            // TextBoxRevenue
            // 
            this.TextBoxRevenue.Location = new System.Drawing.Point(73, 428);
            this.TextBoxRevenue.Name = "TextBoxRevenue";
            this.TextBoxRevenue.Size = new System.Drawing.Size(699, 20);
            this.TextBoxRevenue.TabIndex = 15;
            this.TextBoxRevenue.TextChanged += new System.EventHandler(this.TextBoxRevenue_TextChanged);
            // 
            // JobDetails
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TextBoxRevenue);
            this.Controls.Add(this.TextBoxCost);
            this.Controls.Add(this.TextBoxMilage);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxSolution);
            this.Controls.Add(this.TextBoxProblem);
            this.Controls.Add(this.DateTimeEnd);
            this.Controls.Add(this.DateTimeStart);
            this.Controls.Add(this.LabelRevenue);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.LabelMilage);
            this.Controls.Add(this.LabelSolution);
            this.Controls.Add(this.LabelProblem);
            this.Controls.Add(this.LabelEndDate);
            this.Controls.Add(this.LabelStartDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "JobDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Job Details - CI Garage Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStartDate;
        private System.Windows.Forms.Label LabelEndDate;
        private System.Windows.Forms.Label LabelProblem;
        private System.Windows.Forms.Label LabelSolution;
        private System.Windows.Forms.Label LabelMilage;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelRevenue;
        private System.Windows.Forms.DateTimePicker DateTimeStart;
        private System.Windows.Forms.DateTimePicker DateTimeEnd;
        private System.Windows.Forms.TextBox TextBoxProblem;
        private System.Windows.Forms.TextBox TextBoxSolution;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextBoxMilage;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.TextBox TextBoxRevenue;
    }
}