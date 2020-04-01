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
            this.UserRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UserRTB
            // 
            this.UserRTB.Location = new System.Drawing.Point(106, 57);
            this.UserRTB.Name = "UserRTB";
            this.UserRTB.Size = new System.Drawing.Size(388, 248);
            this.UserRTB.TabIndex = 0;
            this.UserRTB.Text = "";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.UserRTB);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(619, 392);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox UserRTB;
    }
}
