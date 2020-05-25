namespace ProjectPaw_1048_TucaMadalin
{
    partial class client
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbuName = new System.Windows.Forms.TextBox();
            this.tbPassLog = new System.Windows.Forms.TextBox();
            this.logBtn = new System.Windows.Forms.Button();
            this.currentTime1 = new ProjectPaw_1048_TucaMadalin.CurrentTime();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(215, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 189);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(265, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // tbuName
            // 
            this.tbuName.Location = new System.Drawing.Point(239, 32);
            this.tbuName.Name = "tbuName";
            this.tbuName.Size = new System.Drawing.Size(135, 22);
            this.tbuName.TabIndex = 4;
            // 
            // tbPassLog
            // 
            this.tbPassLog.Location = new System.Drawing.Point(239, 90);
            this.tbPassLog.Name = "tbPassLog";
            this.tbPassLog.Size = new System.Drawing.Size(135, 22);
            this.tbPassLog.TabIndex = 5;
            this.tbPassLog.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbPassLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassLog_KeyDown);
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.logBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logBtn.FlatAppearance.BorderSize = 0;
            this.logBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.Color.White;
            this.logBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.login2;
            this.logBtn.Location = new System.Drawing.Point(215, 127);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(186, 67);
            this.logBtn.TabIndex = 6;
            this.logBtn.Text = "Login";
            this.logBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            this.logBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logBtn_KeyPress);
            // 
            // currentTime1
            // 
            this.currentTime1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.currentTime1.Location = new System.Drawing.Point(215, 189);
            this.currentTime1.Name = "currentTime1";
            this.currentTime1.Size = new System.Drawing.Size(186, 27);
            this.currentTime1.TabIndex = 7;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.appBg;
            this.Controls.Add(this.currentTime1);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.tbPassLog);
            this.Controls.Add(this.tbuName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "client";
            this.Size = new System.Drawing.Size(622, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbuName;
        private System.Windows.Forms.TextBox tbPassLog;
        private System.Windows.Forms.Button logBtn;
        private CurrentTime currentTime1;
    }
}
