namespace HrHammoudCompany.BlackList
{
    partial class AddToBlackList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.tbAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 46);
            this.label1.TabIndex = 100;
            this.label1.Text = "إضافة إلى القائمة السوداء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 86);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 101;
            this.label2.Text = "الإسم الثلاثي :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(705, 170);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 103;
            this.label4.Text = "السبب :";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(484, 86);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(0, 32);
            this.FullName.TabIndex = 104;
            // 
            // tbReason
            // 
            this.tbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReason.Location = new System.Drawing.Point(11, 138);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReason.Size = new System.Drawing.Size(670, 125);
            this.tbReason.TabIndex = 105;
            // 
            // tbAdd
            // 
            this.tbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbAdd.Font = new System.Drawing.Font("Arial Black", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdd.Image = global::HrHammoudCompany.Resource1.Save_32;
            this.tbAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbAdd.Location = new System.Drawing.Point(301, 292);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(200, 52);
            this.tbAdd.TabIndex = 106;
            this.tbAdd.Text = "حفظ";
            this.tbAdd.UseVisualStyleBackColor = false;
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(293, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(340, 32);
            this.textBox1.TabIndex = 107;
            // 
            // AddToBlackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 347);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddToBlackList";
            this.Text = "AddToBlackList";
            this.Load += new System.EventHandler(this.AddToBlackList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.Button tbAdd;
        private System.Windows.Forms.TextBox textBox1;
    }
}