namespace CI_Garage_Manager.Views
{
    partial class CarDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDetails));
            this.LabelMake = new System.Windows.Forms.Label();
            this.LabelModel = new System.Windows.Forms.Label();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelEngine = new System.Windows.Forms.Label();
            this.LabelVIN = new System.Windows.Forms.Label();
            this.LabelPlate = new System.Windows.Forms.Label();
            this.TextBoxMake = new System.Windows.Forms.TextBox();
            this.TextBoxModel = new System.Windows.Forms.TextBox();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.TextBoxEngine = new System.Windows.Forms.TextBox();
            this.TextBoxVehicleID = new System.Windows.Forms.TextBox();
            this.TextBoxPlate = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelMake
            // 
            this.LabelMake.AutoSize = true;
            this.LabelMake.Location = new System.Drawing.Point(12, 15);
            this.LabelMake.Name = "LabelMake";
            this.LabelMake.Size = new System.Drawing.Size(34, 13);
            this.LabelMake.TabIndex = 0;
            this.LabelMake.Text = "Make";
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(12, 41);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(36, 13);
            this.LabelModel.TabIndex = 1;
            this.LabelModel.Text = "Model";
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Location = new System.Drawing.Point(12, 67);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(29, 13);
            this.LabelYear.TabIndex = 2;
            this.LabelYear.Text = "Year";
            // 
            // LabelEngine
            // 
            this.LabelEngine.AutoSize = true;
            this.LabelEngine.Location = new System.Drawing.Point(12, 93);
            this.LabelEngine.Name = "LabelEngine";
            this.LabelEngine.Size = new System.Drawing.Size(40, 13);
            this.LabelEngine.TabIndex = 3;
            this.LabelEngine.Text = "Engine";
            // 
            // LabelVIN
            // 
            this.LabelVIN.AutoSize = true;
            this.LabelVIN.Location = new System.Drawing.Point(12, 119);
            this.LabelVIN.Name = "LabelVIN";
            this.LabelVIN.Size = new System.Drawing.Size(25, 13);
            this.LabelVIN.TabIndex = 4;
            this.LabelVIN.Text = "VIN";
            // 
            // LabelPlate
            // 
            this.LabelPlate.AutoSize = true;
            this.LabelPlate.Location = new System.Drawing.Point(12, 145);
            this.LabelPlate.Name = "LabelPlate";
            this.LabelPlate.Size = new System.Drawing.Size(71, 13);
            this.LabelPlate.TabIndex = 5;
            this.LabelPlate.Text = "License Plate";
            // 
            // TextBoxMake
            // 
            this.TextBoxMake.Location = new System.Drawing.Point(89, 12);
            this.TextBoxMake.Name = "TextBoxMake";
            this.TextBoxMake.Size = new System.Drawing.Size(283, 20);
            this.TextBoxMake.TabIndex = 6;
            // 
            // TextBoxModel
            // 
            this.TextBoxModel.Location = new System.Drawing.Point(89, 38);
            this.TextBoxModel.Name = "TextBoxModel";
            this.TextBoxModel.Size = new System.Drawing.Size(283, 20);
            this.TextBoxModel.TabIndex = 7;
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Location = new System.Drawing.Point(89, 64);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(283, 20);
            this.TextBoxYear.TabIndex = 8;
            this.TextBoxYear.TextChanged += new System.EventHandler(this.TextBoxYear_TextChanged);
            // 
            // TextBoxEngine
            // 
            this.TextBoxEngine.Location = new System.Drawing.Point(89, 90);
            this.TextBoxEngine.Name = "TextBoxEngine";
            this.TextBoxEngine.Size = new System.Drawing.Size(283, 20);
            this.TextBoxEngine.TabIndex = 9;
            // 
            // TextBoxVehicleID
            // 
            this.TextBoxVehicleID.Location = new System.Drawing.Point(89, 116);
            this.TextBoxVehicleID.Name = "TextBoxVehicleID";
            this.TextBoxVehicleID.Size = new System.Drawing.Size(283, 20);
            this.TextBoxVehicleID.TabIndex = 10;
            // 
            // TextBoxPlate
            // 
            this.TextBoxPlate.Location = new System.Drawing.Point(89, 142);
            this.TextBoxPlate.Name = "TextBoxPlate";
            this.TextBoxPlate.Size = new System.Drawing.Size(283, 20);
            this.TextBoxPlate.TabIndex = 11;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(297, 226);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(214, 226);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 13;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // CarDetails
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxPlate);
            this.Controls.Add(this.TextBoxVehicleID);
            this.Controls.Add(this.TextBoxEngine);
            this.Controls.Add(this.TextBoxYear);
            this.Controls.Add(this.TextBoxModel);
            this.Controls.Add(this.TextBoxMake);
            this.Controls.Add(this.LabelPlate);
            this.Controls.Add(this.LabelVIN);
            this.Controls.Add(this.LabelEngine);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.LabelModel);
            this.Controls.Add(this.LabelMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "CarDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car Details - CI Garage Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMake;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelEngine;
        private System.Windows.Forms.Label LabelVIN;
        private System.Windows.Forms.Label LabelPlate;
        private System.Windows.Forms.TextBox TextBoxMake;
        private System.Windows.Forms.TextBox TextBoxModel;
        private System.Windows.Forms.TextBox TextBoxYear;
        private System.Windows.Forms.TextBox TextBoxEngine;
        private System.Windows.Forms.TextBox TextBoxVehicleID;
        private System.Windows.Forms.TextBox TextBoxPlate;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
    }
}