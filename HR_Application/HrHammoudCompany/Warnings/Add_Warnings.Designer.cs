namespace HrHammoudCompany
{
    partial class Add_Warnings
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
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btPrint = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.tbexplaination = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.LBTopic = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.cbWarning = new System.Windows.Forms.ComboBox();
            this.label125 = new System.Windows.Forms.Label();
            this.NumberWarning = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btAdd = new System.Windows.Forms.Button();
            this.AddImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 819);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "إضافة";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(679, 563);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(170, 45);
            this.btPrint.TabIndex = 40;
            this.btPrint.Text = "طباعة";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(265, 139);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(92, 29);
            this.lbDate.TabIndex = 51;
            this.lbDate.Text = "بيروت في";
            // 
            // tbexplaination
            // 
            this.tbexplaination.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.tbexplaination.Location = new System.Drawing.Point(297, 244);
            this.tbexplaination.Multiline = true;
            this.tbexplaination.Name = "tbexplaination";
            this.tbexplaination.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbexplaination.Size = new System.Drawing.Size(773, 181);
            this.tbexplaination.TabIndex = 45;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Marlett", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(291, 204);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(205, 32);
            this.lb2.TabIndex = 44;
            this.lb2.Text = ": وذلك للأسباب التالية";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(1056, 150);
            this.lbName.Name = "lbName";
            this.lbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbName.Size = new System.Drawing.Size(82, 29);
            this.lbName.TabIndex = 43;
            this.lbName.Text = "السيد :  ";
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Marlett", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(553, 204);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(556, 32);
            this.Lb1.TabIndex = 42;
            this.Lb1.Text = " بعد الإجتماع الذي تم بيننا اليوم , يؤسفنا إنذاركم خطيا للمرة  ";
            // 
            // LBTopic
            // 
            this.LBTopic.AutoSize = true;
            this.LBTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTopic.Location = new System.Drawing.Point(1030, 78);
            this.LBTopic.Name = "LBTopic";
            this.LBTopic.Size = new System.Drawing.Size(97, 29);
            this.LBTopic.TabIndex = 41;
            this.LBTopic.Text = " الموضوع ";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Marlett", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(334, 437);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(794, 64);
            this.lb3.TabIndex = 46;
            this.lb3.Text = " علما أن هذا التصرف يتعارض مع سياسة المؤسسة الداخلية ويشكل خرقا جسيما لأنظمتها \r\n" +
    "                هذا الإنذار سوف يحفظ في ملفك الخاص وسيستعمل ضدك إذا دعت الحاجة ";
            // 
            // cbWarning
            // 
            this.cbWarning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cbWarning.FormattingEnabled = true;
            this.cbWarning.Items.AddRange(new object[] {
            "إنذار خطي",
            "لفت نظر"});
            this.cbWarning.Location = new System.Drawing.Point(859, 74);
            this.cbWarning.Name = "cbWarning";
            this.cbWarning.Size = new System.Drawing.Size(164, 37);
            this.cbWarning.TabIndex = 52;
            this.cbWarning.SelectedIndexChanged += new System.EventHandler(this.cbWarning_SelectedIndexChanged);
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label125.Location = new System.Drawing.Point(472, 9);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(177, 46);
            this.label125.TabIndex = 53;
            this.label125.Text = " توجيه إنذار";
            // 
            // NumberWarning
            // 
            this.NumberWarning.AutoSize = true;
            this.NumberWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.NumberWarning.Location = new System.Drawing.Point(750, 78);
            this.NumberWarning.Name = "NumberWarning";
            this.NumberWarning.Size = new System.Drawing.Size(45, 29);
            this.NumberWarning.TabIndex = 54;
            this.NumberWarning.Text = "رقم ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Location = new System.Drawing.Point(77, 444);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 25);
            this.linkLabel1.TabIndex = 56;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تحميل الملف";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(425, 563);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(170, 45);
            this.btAdd.TabIndex = 57;
            this.btAdd.Text = "إضافة";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // AddImage
            // 
            this.AddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddImage.Location = new System.Drawing.Point(47, 563);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(170, 45);
            this.AddImage.TabIndex = 58;
            this.AddImage.Text = "إضافة الصورة";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Visible = false;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(9, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Warnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 620);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NumberWarning);
            this.Controls.Add(this.label125);
            this.Controls.Add(this.cbWarning);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.tbexplaination);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.LBTopic);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Add_Warnings";
            this.Text = "Warnings";
            this.Load += new System.EventHandler(this.Warnings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbexplaination;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label LBTopic;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.ComboBox cbWarning;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label NumberWarning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button AddImage;
    }
}