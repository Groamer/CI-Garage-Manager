namespace CI_Garage_Manager.Views
{
    partial class JobOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobOverview));
            this.TextBoxRevenue = new System.Windows.Forms.TextBox();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.TextBoxMilage = new System.Windows.Forms.TextBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextBoxSolution = new System.Windows.Forms.TextBox();
            this.TextBoxProblem = new System.Windows.Forms.TextBox();
            this.LabelRevenue = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelMilage = new System.Windows.Forms.Label();
            this.LabelSolution = new System.Windows.Forms.Label();
            this.LabelProblem = new System.Windows.Forms.Label();
            this.LabelEndDate = new System.Windows.Forms.Label();
            this.LabelStartDate = new System.Windows.Forms.Label();
            this.TextBoxEnd = new System.Windows.Forms.TextBox();
            this.TextBoxStart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxRevenue
            // 
            this.TextBoxRevenue.Location = new System.Drawing.Point(73, 428);
            this.TextBoxRevenue.Name = "TextBoxRevenue";
            this.TextBoxRevenue.ReadOnly = true;
            this.TextBoxRevenue.Size = new System.Drawing.Size(699, 20);
            this.TextBoxRevenue.TabIndex = 30;
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.Location = new System.Drawing.Point(73, 402);
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.ReadOnly = true;
            this.TextBoxCost.Size = new System.Drawing.Size(699, 20);
            this.TextBoxCost.TabIndex = 29;
            // 
            // TextBoxMilage
            // 
            this.TextBoxMilage.Location = new System.Drawing.Point(73, 376);
            this.TextBoxMilage.Name = "TextBoxMilage";
            this.TextBoxMilage.ReadOnly = true;
            this.TextBoxMilage.Size = new System.Drawing.Size(699, 20);
            this.TextBoxMilage.TabIndex = 28;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(697, 526);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 27;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextBoxSolution
            // 
            this.TextBoxSolution.AcceptsReturn = true;
            this.TextBoxSolution.AcceptsTab = true;
            this.TextBoxSolution.Location = new System.Drawing.Point(73, 220);
            this.TextBoxSolution.MaxLength = 50000;
            this.TextBoxSolution.Multiline = true;
            this.TextBoxSolution.Name = "TextBoxSolution";
            this.TextBoxSolution.ReadOnly = true;
            this.TextBoxSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxSolution.Size = new System.Drawing.Size(699, 150);
            this.TextBoxSolution.TabIndex = 26;
            // 
            // TextBoxProblem
            // 
            this.TextBoxProblem.AcceptsReturn = true;
            this.TextBoxProblem.AcceptsTab = true;
            this.TextBoxProblem.Location = new System.Drawing.Point(73, 64);
            this.TextBoxProblem.MaxLength = 50000;
            this.TextBoxProblem.Multiline = true;
            this.TextBoxProblem.Name = "TextBoxProblem";
            this.TextBoxProblem.ReadOnly = true;
            this.TextBoxProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxProblem.Size = new System.Drawing.Size(699, 150);
            this.TextBoxProblem.TabIndex = 25;
            // 
            // LabelRevenue
            // 
            this.LabelRevenue.AutoSize = true;
            this.LabelRevenue.Location = new System.Drawing.Point(12, 431);
            this.LabelRevenue.Name = "LabelRevenue";
            this.LabelRevenue.Size = new System.Drawing.Size(51, 13);
            this.LabelRevenue.TabIndex = 22;
            this.LabelRevenue.Text = "Revenue";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(12, 405);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(28, 13);
            this.LabelCost.TabIndex = 21;
            this.LabelCost.Text = "Cost";
            // 
            // LabelMilage
            // 
            this.LabelMilage.AutoSize = true;
            this.LabelMilage.Location = new System.Drawing.Point(12, 379);
            this.LabelMilage.Name = "LabelMilage";
            this.LabelMilage.Size = new System.Drawing.Size(38, 13);
            this.LabelMilage.TabIndex = 20;
            this.LabelMilage.Text = "Milage";
            // 
            // LabelSolution
            // 
            this.LabelSolution.AutoSize = true;
            this.LabelSolution.Location = new System.Drawing.Point(12, 223);
            this.LabelSolution.Name = "LabelSolution";
            this.LabelSolution.Size = new System.Drawing.Size(45, 13);
            this.LabelSolution.TabIndex = 19;
            this.LabelSolution.Text = "Solution";
            // 
            // LabelProblem
            // 
            this.LabelProblem.AutoSize = true;
            this.LabelProblem.Location = new System.Drawing.Point(12, 67);
            this.LabelProblem.Name = "LabelProblem";
            this.LabelProblem.Size = new System.Drawing.Size(45, 13);
            this.LabelProblem.TabIndex = 18;
            this.LabelProblem.Text = "Problem";
            // 
            // LabelEndDate
            // 
            this.LabelEndDate.AutoSize = true;
            this.LabelEndDate.Location = new System.Drawing.Point(12, 41);
            this.LabelEndDate.Name = "LabelEndDate";
            this.LabelEndDate.Size = new System.Drawing.Size(52, 13);
            this.LabelEndDate.TabIndex = 17;
            this.LabelEndDate.Text = "End Date";
            // 
            // LabelStartDate
            // 
            this.LabelStartDate.AutoSize = true;
            this.LabelStartDate.Location = new System.Drawing.Point(12, 15);
            this.LabelStartDate.Name = "LabelStartDate";
            this.LabelStartDate.Size = new System.Drawing.Size(55, 13);
            this.LabelStartDate.TabIndex = 16;
            this.LabelStartDate.Text = "Start Date";
            // 
            // TextBoxEnd
            // 
            this.TextBoxEnd.Location = new System.Drawing.Point(73, 38);
            this.TextBoxEnd.Name = "TextBoxEnd";
            this.TextBoxEnd.ReadOnly = true;
            this.TextBoxEnd.Size = new System.Drawing.Size(699, 20);
            this.TextBoxEnd.TabIndex = 32;
            // 
            // TextBoxStart
            // 
            this.TextBoxStart.Location = new System.Drawing.Point(73, 12);
            this.TextBoxStart.Name = "TextBoxStart";
            this.TextBoxStart.ReadOnly = true;
            this.TextBoxStart.Size = new System.Drawing.Size(699, 20);
            this.TextBoxStart.TabIndex = 31;
            // 
            // JobOverview
            // 
            this.AcceptButton = this.ButtonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TextBoxEnd);
            this.Controls.Add(this.TextBoxStart);
            this.Controls.Add(this.TextBoxRevenue);
            this.Controls.Add(this.TextBoxCost);
            this.Controls.Add(this.TextBoxMilage);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.TextBoxSolution);
            this.Controls.Add(this.TextBoxProblem);
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
            this.Name = "JobOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Job - CI Garage Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxRevenue;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.TextBox TextBoxMilage;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TextBox TextBoxSolution;
        private System.Windows.Forms.TextBox TextBoxProblem;
        private System.Windows.Forms.Label LabelRevenue;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelMilage;
        private System.Windows.Forms.Label LabelSolution;
        private System.Windows.Forms.Label LabelProblem;
        private System.Windows.Forms.Label LabelEndDate;
        private System.Windows.Forms.Label LabelStartDate;
        private System.Windows.Forms.TextBox TextBoxEnd;
        private System.Windows.Forms.TextBox TextBoxStart;
    }
}