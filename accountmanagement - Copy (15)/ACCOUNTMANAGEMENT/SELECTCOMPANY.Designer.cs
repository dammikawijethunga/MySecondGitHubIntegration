namespace ACCOUNTMANAGEMENT
{
    partial class SELECTCOMPANY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SELECTCOMPANY));
            this.dgvselectcompany = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_fyear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectcompany)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvselectcompany
            // 
            this.dgvselectcompany.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvselectcompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvselectcompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.PATH});
            this.dgvselectcompany.Location = new System.Drawing.Point(26, 88);
            this.dgvselectcompany.Name = "dgvselectcompany";
            this.dgvselectcompany.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvselectcompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvselectcompany.Size = new System.Drawing.Size(1046, 327);
            this.dgvselectcompany.TabIndex = 0;
            this.dgvselectcompany.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvselectcompany_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "COMPANYNAME";
            this.Column2.Name = "Column2";
            this.Column2.Width = 500;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FINANCIALYEARFROM";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // PATH
            // 
            this.PATH.HeaderText = "PATH";
            this.PATH.Name = "PATH";
            this.PATH.Width = 250;
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(110, 433);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(265, 73);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "&N";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_Backup
            // 
            this.btn_Backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backup.Image = ((System.Drawing.Image)(resources.GetObject("btn_Backup.Image")));
            this.btn_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Backup.Location = new System.Drawing.Point(392, 433);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(237, 73);
            this.btn_Backup.TabIndex = 2;
            this.btn_Backup.Text = "&B";
            this.btn_Backup.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_fyear
            // 
            this.btn_fyear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fyear.Image = ((System.Drawing.Image)(resources.GetObject("btn_fyear.Image")));
            this.btn_fyear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fyear.Location = new System.Drawing.Point(647, 433);
            this.btn_fyear.Name = "btn_fyear";
            this.btn_fyear.Size = new System.Drawing.Size(246, 73);
            this.btn_fyear.TabIndex = 3;
            this.btn_fyear.Text = "&Y";
            this.btn_fyear.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_fyear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(70, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 73);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SELECTCOMPANY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_fyear);
            this.Controls.Add(this.btn_Backup);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dgvselectcompany);
            this.Name = "SELECTCOMPANY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECTCOMPANY";
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectcompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvselectcompany;
        internal System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATH;
        internal System.Windows.Forms.Button btn_Backup;
        internal System.Windows.Forms.Button btn_fyear;
        internal System.Windows.Forms.Button button1;
    }
}