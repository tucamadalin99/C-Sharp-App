namespace ProjectPaw_1048_TucaMadalin
{
    partial class hotels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hotels));
            this.login1 = new ProiectPAW_Tuca_Madalin_1048.login();
            this.home1 = new ProiectPAW_Tuca_Madalin_1048.home();
            this.client1 = new ProjectPaw_1048_TucaMadalin.client();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.login1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login1.BackgroundImage")));
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(622, 416);
            this.login1.TabIndex = 0;
            // 
            // home1
            // 
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(619, 392);
            this.home1.TabIndex = 1;
            // 
            // client1
            // 
            this.client1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("client1.BackgroundImage")));
            this.client1.Location = new System.Drawing.Point(0, 0);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(622, 416);
            this.client1.TabIndex = 2;
            // 
            // hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.client1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.login1);
            this.Name = "hotels";
            this.Size = new System.Drawing.Size(619, 392);
            this.ResumeLayout(false);

        }

        #endregion

        private ProiectPAW_Tuca_Madalin_1048.login login1;
        private ProiectPAW_Tuca_Madalin_1048.home home1;
        private client client1;
    }
}
