﻿namespace CarsProject
{
    partial class MainForm
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
            this.BreakButton = new System.Windows.Forms.Button();
            this.GasButton = new System.Windows.Forms.Button();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BreakButton
            // 
            this.BreakButton.Location = new System.Drawing.Point(12, 225);
            this.BreakButton.Name = "BreakButton";
            this.BreakButton.Size = new System.Drawing.Size(57, 24);
            this.BreakButton.TabIndex = 0;
            this.BreakButton.Text = "break";
            this.BreakButton.UseVisualStyleBackColor = true;
            this.BreakButton.Click += new System.EventHandler(this.BreakButtonClick);
            // 
            // GasButton
            // 
            this.GasButton.Location = new System.Drawing.Point(75, 225);
            this.GasButton.Name = "GasButton";
            this.GasButton.Size = new System.Drawing.Size(57, 24);
            this.GasButton.TabIndex = 1;
            this.GasButton.Text = "gas";
            this.GasButton.UseVisualStyleBackColor = true;
            this.GasButton.Click += new System.EventHandler(this.GasButtonClick);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(138, 231);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(0, 13);
            this.SpeedLabel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.GasButton);
            this.Controls.Add(this.BreakButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BreakButton;
        private System.Windows.Forms.Button GasButton;
        private System.Windows.Forms.Label SpeedLabel;
    }
}

