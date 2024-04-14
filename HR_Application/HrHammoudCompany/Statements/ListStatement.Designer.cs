namespace HrHammoudCompany.Statements
{
    partial class ListStatement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStatement));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ShowImage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPageNumber = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeight = 50;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowImage});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.Location = new System.Drawing.Point(0, 214);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1049, 437);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ShowImage
            // 
            this.ShowImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShowImage.HeaderText = "الصور";
            this.ShowImage.Name = "ShowImage";
            this.ShowImage.ReadOnly = true;
            this.ShowImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowImage.Text = "عرض الصورة";
            this.ShowImage.UseColumnTextForButtonValue = true;
            this.ShowImage.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marlett", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "الإفادات";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(970, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 56);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPageNumber.AutoSize = true;
            this.lbPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbPageNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPageNumber.Location = new System.Drawing.Point(512, 665);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Size = new System.Drawing.Size(23, 25);
            this.lbPageNumber.TabIndex = 95;
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
            this.btback.Location = new System.Drawing.Point(263, 657);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(142, 40);
            this.btback.TabIndex = 94;
            this.btback.Text = "السابق";
            this.btback.UseVisualStyleBackColor = false;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btnext
            // 
            this.btnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnext.BackColor = System.Drawing.Color.White;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnext.Image = global::HrHammoudCompany.Resource1.next;
            this.btnext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnext.Location = new System.Drawing.Point(643, 657);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(142, 40);
            this.btnext.TabIndex = 93;
            this.btnext.Text = "التالي";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // ListStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 701);
            this.Controls.Add(this.lbPageNumber);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ListStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListStatement";
            this.Load += new System.EventHandler(this.ListStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn ShowImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPageNumber;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btnext;
    }
}