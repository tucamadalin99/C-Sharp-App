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
            this.bookedListView = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.denCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrZCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrCCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pretCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookedListView
            // 
            this.bookedListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.bookedListView.GridLines = true;
            this.bookedListView.HideSelection = false;
            this.bookedListView.Location = new System.Drawing.Point(12, 38);
            this.bookedListView.Name = "bookedListView";
            this.bookedListView.Size = new System.Drawing.Size(776, 400);
            this.bookedListView.TabIndex = 0;
            this.bookedListView.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.denCol,
            this.locCol,
            this.nrZCol,
            this.nrCCol,
            this.pretCol});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(748, 373);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // denCol
            // 
            this.denCol.Text = "Denumire";
            this.denCol.Width = 94;
            // 
            // locCol
            // 
            this.locCol.Text = "Locatie";
            this.locCol.Width = 76;
            // 
            // nrZCol
            // 
            this.nrZCol.Text = "Nr.Zile";
            // 
            // nrCCol
            // 
            this.nrCCol.Text = "Nr.Camere";
            this.nrCCol.Width = 87;
            // 
            // pretCol
            // 
            this.pretCol.Text = "Pret Mediu";
            this.pretCol.Width = 96;
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(369, 9);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(75, 23);
            this.refBtn.TabIndex = 2;
            this.refBtn.Text = "Refresh";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bookedListView);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bookedListView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader denCol;
        private System.Windows.Forms.ColumnHeader locCol;
        private System.Windows.Forms.ColumnHeader nrZCol;
        private System.Windows.Forms.ColumnHeader nrCCol;
        private System.Windows.Forms.ColumnHeader pretCol;
        private System.Windows.Forms.Button refBtn;
    }
}