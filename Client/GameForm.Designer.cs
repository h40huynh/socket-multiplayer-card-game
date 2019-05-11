﻿namespace Client
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.ptbCards = new System.Windows.Forms.PictureBox();
            this.ptbCardLeft = new System.Windows.Forms.PictureBox();
            this.ptbCardRight = new System.Windows.Forms.PictureBox();
            this.ptbCardUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCardLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCardRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCardUp)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCards
            // 
            this.ptbCards.Location = new System.Drawing.Point(426, 158);
            this.ptbCards.Name = "ptbCards";
            this.ptbCards.Size = new System.Drawing.Size(98, 133);
            this.ptbCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCards.TabIndex = 0;
            this.ptbCards.TabStop = false;
            // 
            // ptbCardLeft
            // 
            this.ptbCardLeft.Location = new System.Drawing.Point(12, 158);
            this.ptbCardLeft.Name = "ptbCardLeft";
            this.ptbCardLeft.Size = new System.Drawing.Size(98, 133);
            this.ptbCardLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCardLeft.TabIndex = 1;
            this.ptbCardLeft.TabStop = false;
            // 
            // ptbCardRight
            // 
            this.ptbCardRight.Location = new System.Drawing.Point(822, 158);
            this.ptbCardRight.Name = "ptbCardRight";
            this.ptbCardRight.Size = new System.Drawing.Size(98, 133);
            this.ptbCardRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCardRight.TabIndex = 2;
            this.ptbCardRight.TabStop = false;
            // 
            // ptbCardUp
            // 
            this.ptbCardUp.Location = new System.Drawing.Point(426, -30);
            this.ptbCardUp.Name = "ptbCardUp";
            this.ptbCardUp.Size = new System.Drawing.Size(98, 133);
            this.ptbCardUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCardUp.TabIndex = 3;
            this.ptbCardUp.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 545);
            this.Controls.Add(this.ptbCardUp);
            this.Controls.Add(this.ptbCardRight);
            this.Controls.Add(this.ptbCardLeft);
            this.Controls.Add(this.ptbCards);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCardLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCardRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCardUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCards;
        private System.Windows.Forms.PictureBox ptbCardLeft;
        private System.Windows.Forms.PictureBox ptbCardRight;
        private System.Windows.Forms.PictureBox ptbCardUp;
    }
}