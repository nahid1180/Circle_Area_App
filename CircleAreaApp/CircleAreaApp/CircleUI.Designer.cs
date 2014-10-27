﻿namespace CircleAreaApp
{
    partial class CircleUI
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
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.areaButton = new System.Windows.Forms.Button();
            this.diameterButton = new System.Windows.Forms.Button();
            this.perimeterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(116, 13);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius";
            // 
            // areaButton
            // 
            this.areaButton.Location = new System.Drawing.Point(53, 97);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(75, 23);
            this.areaButton.TabIndex = 2;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // diameterButton
            // 
            this.diameterButton.Location = new System.Drawing.Point(161, 97);
            this.diameterButton.Name = "diameterButton";
            this.diameterButton.Size = new System.Drawing.Size(75, 23);
            this.diameterButton.TabIndex = 3;
            this.diameterButton.Text = "Diameter";
            this.diameterButton.UseVisualStyleBackColor = true;
            this.diameterButton.Click += new System.EventHandler(this.diameterButton_Click);
            // 
            // perimeterButton
            // 
            this.perimeterButton.Location = new System.Drawing.Point(267, 97);
            this.perimeterButton.Name = "perimeterButton";
            this.perimeterButton.Size = new System.Drawing.Size(75, 23);
            this.perimeterButton.TabIndex = 4;
            this.perimeterButton.Text = "Perimeter";
            this.perimeterButton.UseVisualStyleBackColor = true;
            this.perimeterButton.Click += new System.EventHandler(this.perimeterButton_Click);
            // 
            // CircleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 158);
            this.Controls.Add(this.perimeterButton);
            this.Controls.Add(this.diameterButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radiusTextBox);
            this.Name = "CircleUI";
            this.Text = "Circle  Area UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button diameterButton;
        private System.Windows.Forms.Button perimeterButton;
    }
}

