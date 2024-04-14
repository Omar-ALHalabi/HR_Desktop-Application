namespace HrHammoudCompany
{
    partial class AddVaccations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.showImage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRows = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPageNumber = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.ColumnHeadersHeight = 40;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showImage});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV.RowTemplate.Height = 30;
            this.DGV.Size = new System.Drawing.Size(915, 517);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // showImage
            // 
            this.showImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.showImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showImage.HeaderText = "الصورة";
            this.showImage.Name = "showImage";
            this.showImage.ReadOnly = true;
            this.showImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.showImage.Text = "عرض الصورة";
            this.showImage.UseColumnTextForButtonValue = true;
            this.showImage.Width = 197;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(99, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(278, 383);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 29);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تحميل صورة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(155, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 54);
            this.button1.TabIndex = 90;
            this.button1.Text = "إضافة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 92;
            this.label1.Text = ":العدد#";
            // 
            // lbRows
            // 
            this.lbRows.AutoSize = true;
            this.lbRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRows.Location = new System.Drawing.Point(13, 29);
            this.lbRows.Name = "lbRows";
            this.lbRows.Size = new System.Drawing.Size(27, 29);
            this.lbRows.TabIndex = 93;
            this.lbRows.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lbRows);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(921, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 570);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPageNumber.AutoSize = true;
            this.lbPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbPageNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPageNumber.Location = new System.Drawing.Point(461, 531);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Size = new System.Drawing.Size(23, 25);
            this.lbPageNumber.TabIndex = 97;
            this.lbPageNumber.Text = "1";
            // 
            // btback
            // 
            this.btback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btback.BackColor = System.Drawing.Color.White;
            this.btback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btback.Image = global::HrHammoudCompany.Resource1.back;
            this.btback.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btback.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btback.Location = new System.Drawing.Point(212, 523);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(142, 40);
            this.btback.TabIndex = 96;
            this.btback.Text = "السابق";
            this.btback.UseVisualStyleBackColor = false;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btnext
            // 
            this.btnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnext.BackColor = System.Drawing.Color.White;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnext.Image = global::HrHammoudCompany.Resource1.next;
            this.btnext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnext.Location = new System.Drawing.Point(592, 523);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(142, 40);
            this.btnext.TabIndex = 95;
            this.btnext.Text = "التالي";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // AddVaccations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 570);
            this.Controls.Add(this.lbPageNumber);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.Name = "AddVaccations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVaccations";
            this.Load += new System.EventHandler(this.AddVaccations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewButtonColumn showImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPageNumber;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btnext;
    }
}