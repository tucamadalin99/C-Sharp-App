namespace ProjectPaw_1048_TucaMadalin
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.listView1 = new System.Windows.Forms.ListView();
            this.idC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.denC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.confPnl = new System.Windows.Forms.Panel();
            this.cbCam = new System.Windows.Forms.ComboBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbZile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confBtn = new System.Windows.Forms.Button();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbPers = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.confPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idC,
            this.denC,
            this.locC,
            this.nrCC});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 54);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idC
            // 
            this.idC.Text = "ID";
            this.idC.Width = 38;
            // 
            // denC
            // 
            this.denC.Text = "Denumire";
            this.denC.Width = 106;
            // 
            // locC
            // 
            this.locC.Text = "Locatie";
            this.locC.Width = 77;
            // 
            // nrCC
            // 
            this.nrCC.Text = "Camere disp";
            this.nrCC.Width = 81;
            // 
            // selectBtn
            // 
            this.selectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectBtn.Location = new System.Drawing.Point(11, 2);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(90, 46);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "Show bookings";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Location = new System.Drawing.Point(180, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 46);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Confirm Selected";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.Location = new System.Drawing.Point(355, 2);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(90, 46);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Deleted booking";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // confPnl
            // 
            this.confPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.confPnl.Controls.Add(this.cbCam);
            this.confPnl.Controls.Add(this.priceLbl);
            this.confPnl.Controls.Add(this.label5);
            this.confPnl.Controls.Add(this.label4);
            this.confPnl.Controls.Add(this.tbZile);
            this.confPnl.Controls.Add(this.label3);
            this.confPnl.Controls.Add(this.label2);
            this.confPnl.Controls.Add(this.label1);
            this.confPnl.Controls.Add(this.confBtn);
            this.confPnl.Controls.Add(this.tbCNP);
            this.confPnl.Controls.Add(this.tbPers);
            this.confPnl.Controls.Add(this.tbFName);
            this.confPnl.Location = new System.Drawing.Point(504, 71);
            this.confPnl.Name = "confPnl";
            this.confPnl.Size = new System.Drawing.Size(254, 355);
            this.confPnl.TabIndex = 4;
            // 
            // cbCam
            // 
            this.cbCam.FormattingEnabled = true;
            this.cbCam.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbCam.Location = new System.Drawing.Point(55, 161);
            this.cbCam.Name = "cbCam";
            this.cbCam.Size = new System.Drawing.Size(121, 24);
            this.cbCam.TabIndex = 12;
            this.cbCam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCam_KeyPress);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLbl.Location = new System.Drawing.Point(3, 4);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(46, 17);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(52, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Rooms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(52, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Days:";
            // 
            // tbZile
            // 
            this.tbZile.Location = new System.Drawing.Point(55, 270);
            this.tbZile.Name = "tbZile";
            this.tbZile.Size = new System.Drawing.Size(132, 22);
            this.tbZile.TabIndex = 8;
            this.tbZile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbZile_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Persons:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "CNP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Full Name:";
            // 
            // confBtn
            // 
            this.confBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confBtn.Location = new System.Drawing.Point(77, 298);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(89, 42);
            this.confBtn.TabIndex = 5;
            this.confBtn.Text = "Confirm";
            this.confBtn.UseVisualStyleBackColor = true;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(55, 104);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(132, 22);
            this.tbCNP.TabIndex = 2;
            this.tbCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNP_KeyPress);
            // 
            // tbPers
            // 
            this.tbPers.Location = new System.Drawing.Point(55, 214);
            this.tbPers.Name = "tbPers";
            this.tbPers.Size = new System.Drawing.Size(132, 22);
            this.tbPers.TabIndex = 1;
            this.tbPers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPers_KeyPress);
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(55, 50);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(132, 22);
            this.tbFName.TabIndex = 0;
            this.tbFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFName_KeyPress);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confPnl);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Booking page";
            this.confPnl.ResumeLayout(false);
            this.confPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idC;
        private System.Windows.Forms.ColumnHeader denC;
        private System.Windows.Forms.ColumnHeader locC;
        private System.Windows.Forms.ColumnHeader nrCC;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Panel confPnl;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbPers;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbZile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.ComboBox cbCam;
    }
}