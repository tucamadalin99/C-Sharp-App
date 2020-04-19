namespace ProjectPaw_1048_TucaMadalin
{
    partial class UserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminBtn = new System.Windows.Forms.Button();
            this.UserRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.adminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtn.FlatAppearance.BorderSize = 0;
            this.adminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.White;
            this.adminBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.wrench;
            this.adminBtn.Location = new System.Drawing.Point(209, 32);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(197, 69);
            this.adminBtn.TabIndex = 4;
            this.adminBtn.Text = "Hotel administration";
            this.adminBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // UserRTB
            // 
            this.UserRTB.Location = new System.Drawing.Point(112, 137);
            this.UserRTB.Name = "UserRTB";
            this.UserRTB.Size = new System.Drawing.Size(392, 199);
            this.UserRTB.TabIndex = 0;
            this.UserRTB.Text = "";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.UserRTB);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(619, 392);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.RichTextBox UserRTB;
    }
}
