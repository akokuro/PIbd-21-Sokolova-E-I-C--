﻿namespace WindowsFormsCars
{
    partial class FormDock
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
            this.pictureBoxDock = new System.Windows.Forms.PictureBox();
            this.SetShip = new System.Windows.Forms.Button();
            this.SetLiner = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            this.TakeShip = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxDock.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(660, 450);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // SetShip
            // 
            this.SetShip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SetShip.Location = new System.Drawing.Point(681, 6);
            this.SetShip.Name = "SetShip";
            this.SetShip.Size = new System.Drawing.Size(103, 44);
            this.SetShip.TabIndex = 1;
            this.SetShip.Text = "Швартовать корабль";
            this.SetShip.UseVisualStyleBackColor = false;
            this.SetShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // SetLiner
            // 
            this.SetLiner.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SetLiner.Location = new System.Drawing.Point(681, 56);
            this.SetLiner.Name = "SetLiner";
            this.SetLiner.Size = new System.Drawing.Size(103, 43);
            this.SetLiner.TabIndex = 2;
            this.SetLiner.Text = "Швартовать лайнер";
            this.SetLiner.UseVisualStyleBackColor = false;
            this.SetLiner.Click += new System.EventHandler(this.buttonSetLiner_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTakeShip);
            this.groupBox1.Controls.Add(this.TakeShip);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(671, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать корабль";
            // 
            // pictureBoxTakeShip
            // 
            this.pictureBoxTakeShip.Location = new System.Drawing.Point(0, 85);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShip";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(127, 126);
            this.pictureBoxTakeShip.TabIndex = 3;
            this.pictureBoxTakeShip.TabStop = false;
            // 
            // TakeShip
            // 
            this.TakeShip.Location = new System.Drawing.Point(22, 54);
            this.TakeShip.Name = "TakeShip";
            this.TakeShip.Size = new System.Drawing.Size(94, 25);
            this.TakeShip.TabIndex = 2;
            this.TakeShip.Text = "Забрать";
            this.TakeShip.UseVisualStyleBackColor = true;
            this.TakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(51, 22);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SetLiner);
            this.Controls.Add(this.SetShip);
            this.Controls.Add(this.pictureBoxDock);
            this.Name = "FormDock";
            this.Text = "Док";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.Button SetShip;
        private System.Windows.Forms.Button SetLiner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTakeShip;
        private System.Windows.Forms.Button TakeShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
    }
}