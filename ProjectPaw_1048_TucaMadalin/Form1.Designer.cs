namespace ProiectPAW_Tuca_Madalin_1048
{
    partial class firstPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstPanel));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.home1 = new ProiectPAW_Tuca_Madalin_1048.home();
            this.login1 = new ProiectPAW_Tuca_Madalin_1048.login();
            this.client2 = new ProjectPaw_1048_TucaMadalin.client();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.home1);
            this.panel1.Controls.Add(this.login1);
            this.panel1.Controls.Add(this.client2);
            this.panel1.Location = new System.Drawing.Point(195, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 454);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(-197, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 10);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(543, 13);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 37);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.ctBtn);
            this.panel2.Controls.Add(this.logBtn);
            this.panel2.Controls.Add(this.regBtn);
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 454);
            this.panel2.TabIndex = 0;
            // 
            // ctBtn
            // 
            this.ctBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctBtn.FlatAppearance.BorderSize = 0;
            this.ctBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ctBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctBtn.ForeColor = System.Drawing.Color.White;
            this.ctBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.contact;
            this.ctBtn.Location = new System.Drawing.Point(0, 344);
            this.ctBtn.Name = "ctBtn";
            this.ctBtn.Size = new System.Drawing.Size(196, 69);
            this.ctBtn.TabIndex = 9;
            this.ctBtn.Text = "Contact";
            this.ctBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ctBtn.UseVisualStyleBackColor = true;
            this.ctBtn.Click += new System.EventHandler(this.ctBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logBtn.FlatAppearance.BorderSize = 0;
            this.logBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.Color.White;
            this.logBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.login;
            this.logBtn.Location = new System.Drawing.Point(-1, 237);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(197, 69);
            this.logBtn.TabIndex = 8;
            this.logBtn.Text = "Login";
            this.logBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.regBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.White;
            this.regBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.note;
            this.regBtn.Location = new System.Drawing.Point(-1, 137);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(197, 69);
            this.regBtn.TabIndex = 7;
            this.regBtn.Text = "Register";
            this.regBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.home_run;
            this.homeBtn.Location = new System.Drawing.Point(-1, 34);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(197, 69);
            this.homeBtn.TabIndex = 6;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // home1
            // 
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(607, 454);
            this.home1.TabIndex = 0;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.login1.BackgroundImage = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.appBg;
            this.login1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(607, 454);
            this.login1.TabIndex = 1;
            // 
            // client2
            // 
            this.client2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("client2.BackgroundImage")));
            this.client2.Location = new System.Drawing.Point(0, 3);
            this.client2.Name = "client2";
            this.client2.Size = new System.Drawing.Size(626, 451);
            this.client2.TabIndex = 1;
            // 
            // firstPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "firstPanel";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private login login1;
        private home home1;
        private System.Windows.Forms.Button ctBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel3;
        private ProjectPaw_1048_TucaMadalin.client client2;
        private System.Windows.Forms.Timer timer1;
    }
}

