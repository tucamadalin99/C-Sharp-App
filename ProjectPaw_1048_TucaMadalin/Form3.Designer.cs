namespace ProjectPaw_1048_TucaMadalin
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDatabseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yearsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCurr = new System.Windows.Forms.TextBox();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loadBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsBmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.loadDataToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDatabseToolStripMenuItem,
            this.openDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // deleteDatabseToolStripMenuItem
            // 
            this.deleteDatabseToolStripMenuItem.Name = "deleteDatabseToolStripMenuItem";
            this.deleteDatabseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteDatabseToolStripMenuItem.Text = "Delete database";
            this.deleteDatabseToolStripMenuItem.Click += new System.EventHandler(this.deleteDatabseToolStripMenuItem_Click);
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openDatabaseToolStripMenuItem.Text = "Open database";
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.yearsBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbCurr);
            this.panel1.Controls.Add(this.tbRef);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(135, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 79);
            this.panel1.TabIndex = 6;
            // 
            // yearsBtn
            // 
            this.yearsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearsBtn.FlatAppearance.BorderSize = 0;
            this.yearsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.yearsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearsBtn.ForeColor = System.Drawing.Color.White;
            this.yearsBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.check;
            this.yearsBtn.Location = new System.Drawing.Point(371, 6);
            this.yearsBtn.Name = "yearsBtn";
            this.yearsBtn.Size = new System.Drawing.Size(118, 68);
            this.yearsBtn.TabIndex = 4;
            this.yearsBtn.Text = "OK";
            this.yearsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.yearsBtn.UseVisualStyleBackColor = true;
            this.yearsBtn.Click += new System.EventHandler(this.yearsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Refference year";
            // 
            // tbCurr
            // 
            this.tbCurr.Location = new System.Drawing.Point(188, 54);
            this.tbCurr.Name = "tbCurr";
            this.tbCurr.Size = new System.Drawing.Size(100, 23);
            this.tbCurr.TabIndex = 1;
            // 
            // tbRef
            // 
            this.tbRef.Location = new System.Drawing.Point(188, 6);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(100, 23);
            this.tbRef.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.loadBtn);
            this.panel2.Location = new System.Drawing.Point(135, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 315);
            this.panel2.TabIndex = 5;
            // 
            // loadBtn
            // 
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.graphic;
            this.loadBtn.Location = new System.Drawing.Point(371, 239);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(118, 73);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "Show Graph";
            this.loadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.changeFontToolStripMenuItem,
            this.saveAsBmpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 76);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.changeColorToolStripMenuItem.Text = "Change color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.changeFontToolStripMenuItem.Text = "Change font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // saveAsBmpToolStripMenuItem
            // 
            this.saveAsBmpToolStripMenuItem.Name = "saveAsBmpToolStripMenuItem";
            this.saveAsBmpToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.saveAsBmpToolStripMenuItem.Text = "Save as bmp. . .";
            this.saveAsBmpToolStripMenuItem.Click += new System.EventHandler(this.saveAsBmpToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.left_arrow;
            this.button1.Location = new System.Drawing.Point(761, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 36);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::ProjectPaw_1048_TucaMadalin.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(750, 27);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 37);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button yearsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurr;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsBmpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDatabseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
    }
}