namespace HrHammoudCompany.ManageOfficialDocuments
{
    partial class ManageDocuments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDocuments));
            this.label44 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbRows = new System.Windows.Forms.Label();
            this.BtEdit = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.linkSaveImage = new System.Windows.Forms.LinkLabel();
            this.LinkDownloadImage = new System.Windows.Forms.LinkLabel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtImage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmsSave = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(408, 261);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(86, 29);
            this.label44.TabIndex = 87;
            this.label44.Text = ": الصورة";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(414, 48);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(75, 29);
            this.label42.TabIndex = 89;
            this.label42.Text = ": الإسم ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(100, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.lbRows);
            this.groupBox1.Controls.Add(this.BtEdit);
            this.groupBox1.Controls.Add(this.BtAdd);
            this.groupBox1.Controls.Add(this.linkSaveImage);
            this.groupBox1.Controls.Add(this.LinkDownloadImage);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(960, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 570);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 101;
            this.label1.Text = ":العدد#";
            // 
            // btDelete
            // 
            this.btDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(193, 504);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(114, 54);
            this.btDelete.TabIndex = 100;
            this.btDelete.Text = "حذف";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbRows
            // 
            this.lbRows.AutoSize = true;
            this.lbRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRows.ForeColor = System.Drawing.Color.Black;
            this.lbRows.Location = new System.Drawing.Point(6, 11);
            this.lbRows.Name = "lbRows";
            this.lbRows.Size = new System.Drawing.Size(0, 29);
            this.lbRows.TabIndex = 99;
            // 
            // BtEdit
            // 
            this.BtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEdit.Location = new System.Drawing.Point(35, 504);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(114, 54);
            this.BtEdit.TabIndex = 97;
            this.BtEdit.Text = "تعديل ";
            this.BtEdit.UseVisualStyleBackColor = false;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.Location = new System.Drawing.Point(356, 504);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(114, 54);
            this.BtAdd.TabIndex = 96;
            this.BtAdd.Text = "إضافة";
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // linkSaveImage
            // 
            this.linkSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkSaveImage.AutoSize = true;
            this.linkSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSaveImage.Location = new System.Drawing.Point(100, 425);
            this.linkSaveImage.Name = "linkSaveImage";
            this.linkSaveImage.Size = new System.Drawing.Size(44, 29);
            this.linkSaveImage.TabIndex = 94;
            this.linkSaveImage.TabStop = true;
            this.linkSaveImage.Text = "حفظ";
            // 
            // LinkDownloadImage
            // 
            this.LinkDownloadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkDownloadImage.AutoSize = true;
            this.LinkDownloadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkDownloadImage.Location = new System.Drawing.Point(351, 425);
            this.LinkDownloadImage.Name = "LinkDownloadImage";
            this.LinkDownloadImage.Size = new System.Drawing.Size(58, 29);
            this.LinkDownloadImage.TabIndex = 93;
            this.LinkDownloadImage.TabStop = true;
            this.LinkDownloadImage.Text = "تحميل";
            this.LinkDownloadImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(105, 47);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbName.Size = new System.Drawing.Size(292, 33);
            this.tbName.TabIndex = 90;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtImage});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(960, 570);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtImage
            // 
            this.BtImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtImage.HeaderText = "الصور";
            this.BtImage.Name = "BtImage";
            this.BtImage.ReadOnly = true;
            this.BtImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtImage.Text = "عرض الصور";
            this.BtImage.UseColumnTextForButtonValue = true;
            this.BtImage.Width = 160;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsSave});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 39);
            // 
            // CmsSave
            // 
            this.CmsSave.AutoSize = false;
            this.CmsSave.Image = ((System.Drawing.Image)(resources.GetObject("CmsSave.Image")));
            this.CmsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmsSave.Name = "CmsSave";
            this.CmsSave.Size = new System.Drawing.Size(200, 35);
            this.CmsSave.Text = "حفظ";
            this.CmsSave.Click += new System.EventHandler(this.CmsSave_Click);
            // 
            // ManageDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageDocuments";
            this.Text = "الملفات المرفقة";
            this.Load += new System.EventHandler(this.ManageOfficialDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkSaveImage;
        private System.Windows.Forms.LinkLabel LinkDownloadImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Label lbRows;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button BtEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CmsSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn BtImage;
    }
}