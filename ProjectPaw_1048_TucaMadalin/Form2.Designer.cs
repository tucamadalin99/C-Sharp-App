﻿namespace ProiectPAW_Tuca_Madalin_1048
{
    partial class Form2
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.accBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.bookedBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.accBtn);
            this.panel2.Controls.Add(this.logBtn);
            this.panel2.Controls.Add(this.bookedBtn);
            this.panel2.Controls.Add(this.bookBtn);
            this.panel2.Location = new System.Drawing.Point(-1, -13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 454);
            this.panel2.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(341, 156);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(137, 28);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Welcome, ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(730, 11);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 37);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // accBtn
            // 
            this.accBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accBtn.FlatAppearance.BorderSize = 0;
            this.accBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.accBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBtn.ForeColor = System.Drawing.Color.White;
            this.accBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.myAcc;
            this.accBtn.Location = new System.Drawing.Point(3, 227);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(196, 69);
            this.accBtn.TabIndex = 9;
            this.accBtn.Text = "My Account";
            this.accBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accBtn.UseVisualStyleBackColor = true;
            this.accBtn.Click += new System.EventHandler(this.accBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logBtn.FlatAppearance.BorderSize = 0;
            this.logBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.Color.White;
            this.logBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.logout;
            this.logBtn.Location = new System.Drawing.Point(3, 338);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(197, 69);
            this.logBtn.TabIndex = 8;
            this.logBtn.Text = "Logout";
            this.logBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // bookedBtn
            // 
            this.bookedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.bookedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookedBtn.FlatAppearance.BorderSize = 0;
            this.bookedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.bookedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookedBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedBtn.ForeColor = System.Drawing.Color.White;
            this.bookedBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.hotel;
            this.bookedBtn.Location = new System.Drawing.Point(2, 130);
            this.bookedBtn.Name = "bookedBtn";
            this.bookedBtn.Size = new System.Drawing.Size(198, 69);
            this.bookedBtn.TabIndex = 7;
            this.bookedBtn.Text = "My bookings";
            this.bookedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bookedBtn.UseVisualStyleBackColor = false;
            // 
            // bookBtn
            // 
            this.bookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookBtn.FlatAppearance.BorderSize = 0;
            this.bookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.Color.White;
            this.bookBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.calendar;
            this.bookBtn.Location = new System.Drawing.Point(1, 29);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(197, 69);
            this.bookBtn.TabIndex = 6;
            this.bookBtn.Text = "Book now!";
            this.bookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bookBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(782, 424);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button accBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button bookedBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button exitBtn;
    }
}