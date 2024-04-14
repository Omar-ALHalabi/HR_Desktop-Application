namespace HrHammoudCompany.Applications
{
    partial class ListApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListApplications));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbnumrows = new System.Windows.Forms.Label();
            this.dgvallapp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.رؤيةالطلبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.تعديلالطلبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.سجلالعملياتللطلبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.الإجازاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.الملفاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.الإفاداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.سجلالعملياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdUnAcceptable = new System.Windows.Forms.RadioButton();
            this.rdPrevious = new System.Windows.Forms.RadioButton();
            this.rdPinned = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPageNumber = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtstartDate = new System.Windows.Forms.DateTimePicker();
            this.lbForm = new System.Windows.Forms.Label();
            this.lbto = new System.Windows.Forms.Label();
            this.CbUN = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallapp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1460, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = " بحث من خلال : ";
            // 
            // cbSearch
            // 
            this.cbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "لا شيء",
            "الرقم الوظيفي",
            "الإسم الأول",
            "إسم الأب",
            "إسم العائلة",
            "إسم الأم",
            "الجنسية",
            "تاريخ الولادة",
            "محل الولادة",
            "فئة الدم",
            "رقم الهاتف",
            "القسم",
            "ساعات العمل",
            "الوضع العائلي",
            "المستوى العلمي",
            "عدد الأولاد",
            "الشهادات",
            "اللغات",
            "مسجل أمم؟",
            "تاريخ تقديم الطلب",
            "تاريخ بدء العمل",
            "تاريخ التعديل الأخير"});
            this.cbSearch.Location = new System.Drawing.Point(1302, 73);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSearch.Size = new System.Drawing.Size(154, 33);
            this.cbSearch.TabIndex = 2;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(1091, 73);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSearch.Size = new System.Drawing.Size(208, 33);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(688, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "طلبات الموظفين";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "العدد : ";
            // 
            // lbnumrows
            // 
            this.lbnumrows.AutoSize = true;
            this.lbnumrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumrows.Location = new System.Drawing.Point(17, 74);
            this.lbnumrows.Name = "lbnumrows";
            this.lbnumrows.Size = new System.Drawing.Size(24, 25);
            this.lbnumrows.TabIndex = 8;
            this.lbnumrows.Text = "0";
            // 
            // dgvallapp
            // 
            this.dgvallapp.AllowUserToAddRows = false;
            this.dgvallapp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvallapp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvallapp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvallapp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvallapp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvallapp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvallapp.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvallapp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Marlett", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvallapp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvallapp.ColumnHeadersHeight = 60;
            this.dgvallapp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvallapp.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvallapp.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvallapp.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvallapp.Location = new System.Drawing.Point(3, 156);
            this.dgvallapp.Name = "dgvallapp";
            this.dgvallapp.ReadOnly = true;
            this.dgvallapp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvallapp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvallapp.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvallapp.RowHeadersVisible = false;
            this.dgvallapp.RowHeadersWidth = 40;
            this.dgvallapp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Marlett", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvallapp.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvallapp.RowTemplate.Height = 47;
            this.dgvallapp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvallapp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvallapp.ShowCellErrors = false;
            this.dgvallapp.ShowCellToolTips = false;
            this.dgvallapp.ShowEditingIcon = false;
            this.dgvallapp.ShowRowErrors = false;
            this.dgvallapp.Size = new System.Drawing.Size(1600, 619);
            this.dgvallapp.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(100, 50);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.رؤيةالطلبToolStripMenuItem,
            this.toolStripSeparator2,
            this.تعديلالطلبToolStripMenuItem,
            this.toolStripSeparator5,
            this.سجلالعملياتللطلبToolStripMenuItem,
            this.toolStripSeparator1,
            this.الإجازاتToolStripMenuItem,
            this.toolStripSeparator6,
            this.الملفاتToolStripMenuItem,
            this.toolStripSeparator3,
            this.الإفاداتToolStripMenuItem,
            this.toolStripSeparator4,
            this.سجلالعملياتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 313);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // رؤيةالطلبToolStripMenuItem
            // 
            this.رؤيةالطلبToolStripMenuItem.AutoSize = false;
            this.رؤيةالطلبToolStripMenuItem.Image = global::HrHammoudCompany.Resource1.info__1_;
            this.رؤيةالطلبToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.رؤيةالطلبToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.رؤيةالطلبToolStripMenuItem.Name = "رؤيةالطلبToolStripMenuItem";
            this.رؤيةالطلبToolStripMenuItem.Size = new System.Drawing.Size(280, 45);
            this.رؤيةالطلبToolStripMenuItem.Text = "رؤية الطلب";
            this.رؤيةالطلبToolStripMenuItem.Click += new System.EventHandler(this.رؤيةالطلبToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // تعديلالطلبToolStripMenuItem
            // 
            this.تعديلالطلبToolStripMenuItem.Image = global::HrHammoudCompany.Resource1.edit;
            this.تعديلالطلبToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.تعديلالطلبToolStripMenuItem.Name = "تعديلالطلبToolStripMenuItem";
            this.تعديلالطلبToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.تعديلالطلبToolStripMenuItem.Text = "تعديل الطلب";
            this.تعديلالطلبToolStripMenuItem.Click += new System.EventHandler(this.تعديلالطلبToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(209, 6);
            // 
            // سجلالعملياتللطلبToolStripMenuItem
            // 
            this.سجلالعملياتللطلبToolStripMenuItem.Image = global::HrHammoudCompany.Resource1.risk_register__1_;
            this.سجلالعملياتللطلبToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.سجلالعملياتللطلبToolStripMenuItem.Name = "سجلالعملياتللطلبToolStripMenuItem";
            this.سجلالعملياتللطلبToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.سجلالعملياتللطلبToolStripMenuItem.Text = "الإنذارات";
            this.سجلالعملياتللطلبToolStripMenuItem.Click += new System.EventHandler(this.سجلالعملياتللطلبToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // الإجازاتToolStripMenuItem
            // 
            this.الإجازاتToolStripMenuItem.Image = global::HrHammoudCompany.Resource1.appointment;
            this.الإجازاتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.الإجازاتToolStripMenuItem.Name = "الإجازاتToolStripMenuItem";
            this.الإجازاتToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.الإجازاتToolStripMenuItem.Text = "الإجازات";
            this.الإجازاتToolStripMenuItem.Click += new System.EventHandler(this.الإجازاتToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(209, 6);
            // 
            // الملفاتToolStripMenuItem
            // 
            this.الملفاتToolStripMenuItem.Image = global::HrHammoudCompany.Resource1.papers;
            this.الملفاتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.الملفاتToolStripMenuItem.Name = "الملفاتToolStripMenuItem";
            this.الملفاتToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.الملفاتToolStripMenuItem.Text = "الملفات";
            this.الملفاتToolStripMenuItem.Click += new System.EventHandler(this.الملفاتToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // الإفاداتToolStripMenuItem
            // 
            this.الإفاداتToolStripMenuItem.Image = global::HrHammoudCompany.Resource1.library;
            this.الإفاداتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.الإفاداتToolStripMenuItem.Name = "الإفاداتToolStripMenuItem";
            this.الإفاداتToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.الإفاداتToolStripMenuItem.Text = "الإفادات";
            this.الإفاداتToolStripMenuItem.Click += new System.EventHandler(this.الإفاداتToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // سجلالعملياتToolStripMenuItem
            // 
            this.سجلالعملياتToolStripMenuItem.Image = global::HrHammoudCompany.Resource1.log_file__1_;
            this.سجلالعملياتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.سجلالعملياتToolStripMenuItem.Name = "سجلالعملياتToolStripMenuItem";
            this.سجلالعملياتToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.سجلالعملياتToolStripMenuItem.Text = "سجل العمليات";
            this.سجلالعملياتToolStripMenuItem.Click += new System.EventHandler(this.سجلالعملياتToolStripMenuItem_Click);
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Checked = true;
            this.rdAll.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAll.Location = new System.Drawing.Point(1420, 30);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(52, 26);
            this.rdAll.TabIndex = 13;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "الكل";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.Click += new System.EventHandler(this.rdAll_Click);
            // 
            // rdUnAcceptable
            // 
            this.rdUnAcceptable.AutoSize = true;
            this.rdUnAcceptable.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUnAcceptable.Location = new System.Drawing.Point(958, 30);
            this.rdUnAcceptable.Name = "rdUnAcceptable";
            this.rdUnAcceptable.Size = new System.Drawing.Size(192, 26);
            this.rdUnAcceptable.TabIndex = 14;
            this.rdUnAcceptable.Text = "الطلبات المرفوضة والملغية";
            this.rdUnAcceptable.UseVisualStyleBackColor = true;
            this.rdUnAcceptable.Click += new System.EventHandler(this.rdUnAcceptable_Click);
            // 
            // rdPrevious
            // 
            this.rdPrevious.AutoSize = true;
            this.rdPrevious.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPrevious.Location = new System.Drawing.Point(1160, 30);
            this.rdPrevious.Name = "rdPrevious";
            this.rdPrevious.Size = new System.Drawing.Size(119, 26);
            this.rdPrevious.TabIndex = 15;
            this.rdPrevious.Text = "الطلبات السابقة";
            this.rdPrevious.UseVisualStyleBackColor = true;
            this.rdPrevious.Click += new System.EventHandler(this.rdPrevious_Click);
            // 
            // rdPinned
            // 
            this.rdPinned.AutoSize = true;
            this.rdPinned.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPinned.Location = new System.Drawing.Point(1291, 30);
            this.rdPinned.Name = "rdPinned";
            this.rdPinned.Size = new System.Drawing.Size(117, 26);
            this.rdPinned.TabIndex = 16;
            this.rdPinned.Text = "الطلبات المعلقة";
            this.rdPinned.UseVisualStyleBackColor = true;
            this.rdPinned.Click += new System.EventHandler(this.rdPinned_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1494, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "حالة الطلب: ";
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPageNumber.AutoSize = true;
            this.lbPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbPageNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPageNumber.Location = new System.Drawing.Point(743, 799);
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
            this.btback.Location = new System.Drawing.Point(494, 791);
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
            this.btnext.Location = new System.Drawing.Point(874, 791);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(142, 40);
            this.btnext.TabIndex = 93;
            this.btnext.Text = "التالي";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.White;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSearch.Location = new System.Drawing.Point(885, 110);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(135, 40);
            this.btSearch.TabIndex = 114;
            this.btSearch.Text = "بحث";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Visible = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(1040, 114);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(147, 30);
            this.dtEndDate.TabIndex = 113;
            this.dtEndDate.Visible = false;
            // 
            // dtstartDate
            // 
            this.dtstartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtstartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtstartDate.Location = new System.Drawing.Point(1237, 114);
            this.dtstartDate.Name = "dtstartDate";
            this.dtstartDate.Size = new System.Drawing.Size(147, 30);
            this.dtstartDate.TabIndex = 112;
            this.dtstartDate.Visible = false;
            // 
            // lbForm
            // 
            this.lbForm.AutoSize = true;
            this.lbForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForm.Location = new System.Drawing.Point(1411, 114);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(31, 25);
            this.lbForm.TabIndex = 110;
            this.lbForm.Text = "من";
            this.lbForm.Visible = false;
            // 
            // lbto
            // 
            this.lbto.AutoSize = true;
            this.lbto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbto.Location = new System.Drawing.Point(1199, 114);
            this.lbto.Name = "lbto";
            this.lbto.Size = new System.Drawing.Size(32, 25);
            this.lbto.TabIndex = 111;
            this.lbto.Text = "إلى";
            this.lbto.Visible = false;
            // 
            // CbUN
            // 
            this.CbUN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbUN.FormattingEnabled = true;
            this.CbUN.Items.AddRange(new object[] {
            "لا",
            "نعم"});
            this.CbUN.Location = new System.Drawing.Point(1175, 72);
            this.CbUN.Name = "CbUN";
            this.CbUN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbUN.Size = new System.Drawing.Size(51, 33);
            this.CbUN.TabIndex = 115;
            this.CbUN.Visible = false;
            this.CbUN.SelectedIndexChanged += new System.EventHandler(this.CbUN_SelectedIndexChanged);
            // 
            // ListApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 837);
            this.Controls.Add(this.CbUN);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtstartDate);
            this.Controls.Add(this.lbForm);
            this.Controls.Add(this.lbto);
            this.Controls.Add(this.lbPageNumber);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdPinned);
            this.Controls.Add(this.rdPrevious);
            this.Controls.Add(this.rdUnAcceptable);
            this.Controls.Add(this.rdAll);
            this.Controls.Add(this.dgvallapp);
            this.Controls.Add(this.lbnumrows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.label1);
            this.Name = "ListApplications";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListApplications";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvallapp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvallapp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem رؤيةالطلبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلالطلبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سجلالعملياتللطلبToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdUnAcceptable;
        private System.Windows.Forms.RadioButton rdPrevious;
        private System.Windows.Forms.RadioButton rdPinned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem الإجازاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem الملفاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem الإفاداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem سجلالعملياتToolStripMenuItem;
        private System.Windows.Forms.Label lbPageNumber;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtstartDate;
        private System.Windows.Forms.Label lbForm;
        private System.Windows.Forms.Label lbto;
        private System.Windows.Forms.Label lbnumrows;
        private System.Windows.Forms.ComboBox CbUN;
    }
}