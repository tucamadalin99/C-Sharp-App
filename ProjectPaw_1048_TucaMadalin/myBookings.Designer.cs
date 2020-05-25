namespace ProjectPaw_1048_TucaMadalin
{
    partial class myBookings
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.denCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrZCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pretCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.denCol,
            this.locCol,
            this.nrZCol,
            this.nrCol,
            this.pretCol});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(735, 373);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // idCol
            // 
            this.idCol.Text = "Index";
            this.idCol.Width = 48;
            // 
            // denCol
            // 
            this.denCol.Text = "Denumire";
            this.denCol.Width = 119;
            // 
            // locCol
            // 
            this.locCol.Text = "Locatie";
            this.locCol.Width = 108;
            // 
            // nrZCol
            // 
            this.nrZCol.Text = "Nr. Zile";
            // 
            // nrCol
            // 
            this.nrCol.Text = "Nr.Camere";
            this.nrCol.Width = 87;
            // 
            // pretCol
            // 
            this.pretCol.Text = "Pret Mediu";
            this.pretCol.Width = 78;
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(351, 373);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(75, 51);
            this.refBtn.TabIndex = 3;
            this.refBtn.Text = "Refresh List";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // myBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.listView1);
            this.Name = "myBookings";
            this.Size = new System.Drawing.Size(827, 376);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idCol;
        private System.Windows.Forms.ColumnHeader denCol;
        private System.Windows.Forms.ColumnHeader locCol;
        private System.Windows.Forms.ColumnHeader nrZCol;
        private System.Windows.Forms.ColumnHeader nrCol;
        private System.Windows.Forms.ColumnHeader pretCol;
        private System.Windows.Forms.Button refBtn;
    }
}
