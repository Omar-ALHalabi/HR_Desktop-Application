namespace HrHammoudCompany
{
    partial class Add_EditUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_EditUsers));
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.PerformSearch = new System.Windows.Forms.Button();
            this.comboboxsearch = new System.Windows.Forms.ComboBox();
            this.tbsearch1 = new System.Windows.Forms.TextBox();
            this.userCard1 = new HrHammoudCompany.UserCard();
            this.SuspendLayout();
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "الرقم الوظيفي",
            "الإسم الثلاثي",
            "إسم المستخدم"});
            this.cbSearch.Location = new System.Drawing.Point(806, 117);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSearch.Size = new System.Drawing.Size(154, 33);
            this.cbSearch.TabIndex = 8;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(977, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = ": بحث من خلال ";
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(475, 737);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(161, 46);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "إضافة";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(442, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(237, 39);
            this.lbTitle.TabIndex = 11;
            this.lbTitle.Text = "إضافة مستخدم جديد";
            // 
            // PerformSearch
            // 
            this.PerformSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PerformSearch.BackgroundImage")));
            this.PerformSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PerformSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformSearch.Location = new System.Drawing.Point(552, 117);
            this.PerformSearch.Name = "PerformSearch";
            this.PerformSearch.Size = new System.Drawing.Size(42, 32);
            this.PerformSearch.TabIndex = 12;
            this.PerformSearch.UseVisualStyleBackColor = true;
            this.PerformSearch.Click += new System.EventHandler(this.PerformSearch_Click);
            // 
            // comboboxsearch
            // 
            this.comboboxsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxsearch.DropDownHeight = 400;
            this.comboboxsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxsearch.FormattingEnabled = true;
            this.comboboxsearch.IntegralHeight = false;
            this.comboboxsearch.Location = new System.Drawing.Point(600, 117);
            this.comboboxsearch.Name = "comboboxsearch";
            this.comboboxsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboboxsearch.Size = new System.Drawing.Size(200, 32);
            this.comboboxsearch.TabIndex = 14;
            this.comboboxsearch.Visible = false;
            // 
            // tbsearch1
            // 
            this.tbsearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch1.Location = new System.Drawing.Point(600, 116);
            this.tbsearch1.Multiline = true;
            this.tbsearch1.Name = "tbsearch1";
            this.tbsearch1.Size = new System.Drawing.Size(200, 35);
            this.tbsearch1.TabIndex = 15;
            this.tbsearch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbsearch1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbsearch1_KeyDown);
            this.tbsearch1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsearch1_KeyPress);
            // 
            // userCard1
            // 
            this.userCard1.BackColor = System.Drawing.Color.Lavender;
            this.userCard1.Location = new System.Drawing.Point(16, 154);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(1091, 577);
            this.userCard1.TabIndex = 13;
            // 
            // Add_EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1111, 787);
            this.Controls.Add(this.tbsearch1);
            this.Controls.Add(this.comboboxsearch);
            this.Controls.Add(this.userCard1);
            this.Controls.Add(this.PerformSearch);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSave);
            this.MaximizeBox = false;
            this.Name = "Add_EditUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_EditUsers";
            this.Load += new System.EventHandler(this.Add_EditUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button PerformSearch;
        private UserCard userCard1;
        private System.Windows.Forms.ComboBox comboboxsearch;
        private System.Windows.Forms.TextBox tbsearch1;
    }
}