namespace SQLAnalysis
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshColumns = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefreshTables = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefreshDb = new System.Windows.Forms.Button();
            this.lbDatabases = new System.Windows.Forms.ListBox();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.dgvColumns = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCreateSql = new System.Windows.Forms.Button();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.txDatabaseServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSemicolon = new System.Windows.Forms.RadioButton();
            this.rbComma = new System.Windows.Forms.RadioButton();
            this.btnFindFile1 = new System.Windows.Forms.Button();
            this.txCsvFile1 = new System.Windows.Forms.TextBox();
            this.btnReadCsv = new System.Windows.Forms.Button();
            this.dgvExt1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFillDatabases = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFillTables = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFillColumn = new System.Windows.Forms.ComboBox();
            this.btnFillInit = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFillDataTypes = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txFillMin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txFillMax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txFillStep = new System.Windows.Forms.TextBox();
            this.btnFillExec = new System.Windows.Forms.Button();
            this.btnTestCommand = new System.Windows.Forms.Button();
            this.txFillCmd = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExt1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.91088F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.91088F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.8886F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.8886F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.20051F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.20051F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefreshColumns, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefreshTables, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefreshDb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDatabases, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTables, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvColumns, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 567);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnRefreshColumns
            // 
            this.btnRefreshColumns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefreshColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefreshColumns.Location = new System.Drawing.Point(789, 7);
            this.btnRefreshColumns.Name = "btnRefreshColumns";
            this.btnRefreshColumns.Size = new System.Drawing.Size(119, 25);
            this.btnRefreshColumns.TabIndex = 8;
            this.btnRefreshColumns.Text = "Refresh";
            this.btnRefreshColumns.UseVisualStyleBackColor = true;
            this.btnRefreshColumns.Click += new System.EventHandler(this.btnRefreshColumns_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(589, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Columns:";
            // 
            // btnRefreshTables
            // 
            this.btnRefreshTables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefreshTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefreshTables.Location = new System.Drawing.Point(387, 7);
            this.btnRefreshTables.Name = "btnRefreshTables";
            this.btnRefreshTables.Size = new System.Drawing.Size(110, 25);
            this.btnRefreshTables.TabIndex = 5;
            this.btnRefreshTables.Text = "Refresh";
            this.btnRefreshTables.UseVisualStyleBackColor = true;
            this.btnRefreshTables.Click += new System.EventHandler(this.btnRefreshTables_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(269, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tables:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Databases:";
            // 
            // btnRefreshDb
            // 
            this.btnRefreshDb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefreshDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefreshDb.Location = new System.Drawing.Point(117, 7);
            this.btnRefreshDb.Name = "btnRefreshDb";
            this.btnRefreshDb.Size = new System.Drawing.Size(108, 25);
            this.btnRefreshDb.TabIndex = 1;
            this.btnRefreshDb.Text = "Refresh";
            this.btnRefreshDb.UseVisualStyleBackColor = true;
            this.btnRefreshDb.Click += new System.EventHandler(this.btnRefreshDb_Click);
            // 
            // lbDatabases
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbDatabases, 2);
            this.lbDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDatabases.FormattingEnabled = true;
            this.lbDatabases.ItemHeight = 16;
            this.lbDatabases.Location = new System.Drawing.Point(3, 43);
            this.lbDatabases.Name = "lbDatabases";
            this.lbDatabases.Size = new System.Drawing.Size(222, 362);
            this.lbDatabases.TabIndex = 9;
            // 
            // lbTables
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbTables, 2);
            this.lbTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTables.FormattingEnabled = true;
            this.lbTables.ItemHeight = 16;
            this.lbTables.Location = new System.Drawing.Point(231, 43);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(280, 362);
            this.lbTables.TabIndex = 10;
            // 
            // dgvColumns
            // 
            this.dgvColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvColumns, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumns.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumns.Location = new System.Drawing.Point(517, 43);
            this.dgvColumns.Name = "dgvColumns";
            this.dgvColumns.RowHeadersWidth = 5;
            this.dgvColumns.Size = new System.Drawing.Size(441, 362);
            this.dgvColumns.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCreateSql);
            this.tabPage2.Controls.Add(this.txPassword);
            this.tabPage2.Controls.Add(this.txUserName);
            this.tabPage2.Controls.Add(this.txDatabaseServer);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Credentials";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCreateSql
            // 
            this.btnCreateSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateSql.Location = new System.Drawing.Point(157, 133);
            this.btnCreateSql.Name = "btnCreateSql";
            this.btnCreateSql.Size = new System.Drawing.Size(207, 32);
            this.btnCreateSql.TabIndex = 9;
            this.btnCreateSql.Text = "Create SQL Connection";
            this.btnCreateSql.UseVisualStyleBackColor = true;
            this.btnCreateSql.Click += new System.EventHandler(this.btnCreateSql_Click);
            // 
            // txPassword
            // 
            this.txPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txPassword.Location = new System.Drawing.Point(157, 89);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(393, 22);
            this.txPassword.TabIndex = 8;
            this.txPassword.Text = "Zdenek01Klar";
            // 
            // txUserName
            // 
            this.txUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txUserName.Location = new System.Drawing.Point(157, 52);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(393, 22);
            this.txUserName.TabIndex = 7;
            this.txUserName.Text = "sa";
            // 
            // txDatabaseServer
            // 
            this.txDatabaseServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txDatabaseServer.Location = new System.Drawing.Point(157, 15);
            this.txDatabaseServer.Name = "txDatabaseServer";
            this.txDatabaseServer.Size = new System.Drawing.Size(393, 22);
            this.txDatabaseServer.TabIndex = 6;
            this.txDatabaseServer.Text = "ZDENDAHP\\SQLEXPRESS";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database Server:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(967, 573);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logger";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClearLog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbLog);
            this.splitContainer1.Size = new System.Drawing.Size(961, 567);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearLog.Location = new System.Drawing.Point(12, 11);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 0;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(0, 0);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(957, 518);
            this.lbLog.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(967, 573);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "External Data Source";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.btnFindFile1);
            this.splitContainer2.Panel1.Controls.Add(this.txCsvFile1);
            this.splitContainer2.Panel1.Controls.Add(this.btnReadCsv);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvExt1);
            this.splitContainer2.Size = new System.Drawing.Size(961, 567);
            this.splitContainer2.SplitterDistance = 81;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSemicolon);
            this.groupBox1.Controls.Add(this.rbComma);
            this.groupBox1.Location = new System.Drawing.Point(3, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 40);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delimiter";
            // 
            // rbSemicolon
            // 
            this.rbSemicolon.AutoSize = true;
            this.rbSemicolon.Location = new System.Drawing.Point(72, 17);
            this.rbSemicolon.Name = "rbSemicolon";
            this.rbSemicolon.Size = new System.Drawing.Size(82, 17);
            this.rbSemicolon.TabIndex = 5;
            this.rbSemicolon.Text = "Semmicolon";
            this.rbSemicolon.UseVisualStyleBackColor = true;
            // 
            // rbComma
            // 
            this.rbComma.AutoSize = true;
            this.rbComma.Checked = true;
            this.rbComma.Location = new System.Drawing.Point(6, 17);
            this.rbComma.Name = "rbComma";
            this.rbComma.Size = new System.Drawing.Size(60, 17);
            this.rbComma.TabIndex = 4;
            this.rbComma.TabStop = true;
            this.rbComma.Text = "Comma";
            this.rbComma.UseVisualStyleBackColor = true;
            // 
            // btnFindFile1
            // 
            this.btnFindFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFindFile1.Location = new System.Drawing.Point(924, 3);
            this.btnFindFile1.Name = "btnFindFile1";
            this.btnFindFile1.Size = new System.Drawing.Size(30, 28);
            this.btnFindFile1.TabIndex = 2;
            this.btnFindFile1.Text = "...";
            this.btnFindFile1.UseVisualStyleBackColor = true;
            this.btnFindFile1.Click += new System.EventHandler(this.btnFindFile1_Click);
            // 
            // txCsvFile1
            // 
            this.txCsvFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txCsvFile1.Location = new System.Drawing.Point(111, 6);
            this.txCsvFile1.Name = "txCsvFile1";
            this.txCsvFile1.Size = new System.Drawing.Size(807, 22);
            this.txCsvFile1.TabIndex = 1;
            // 
            // btnReadCsv
            // 
            this.btnReadCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReadCsv.Location = new System.Drawing.Point(3, 3);
            this.btnReadCsv.Name = "btnReadCsv";
            this.btnReadCsv.Size = new System.Drawing.Size(102, 28);
            this.btnReadCsv.TabIndex = 0;
            this.btnReadCsv.Text = "Read CSV";
            this.btnReadCsv.UseVisualStyleBackColor = true;
            this.btnReadCsv.Click += new System.EventHandler(this.btnReadCsv_Click);
            // 
            // dgvExt1
            // 
            this.dgvExt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExt1.Location = new System.Drawing.Point(0, 0);
            this.dgvExt1.Name = "dgvExt1";
            this.dgvExt1.RowHeadersWidth = 8;
            this.dgvExt1.Size = new System.Drawing.Size(957, 478);
            this.dgvExt1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(967, 573);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Filling";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnFillInit);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(961, 567);
            this.splitContainer3.SplitterDistance = 69;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.cbFillColumn);
            this.splitContainer4.Panel1.Controls.Add(this.label9);
            this.splitContainer4.Panel1.Controls.Add(this.cbFillTables);
            this.splitContainer4.Panel1.Controls.Add(this.label8);
            this.splitContainer4.Panel1.Controls.Add(this.cbFillDatabases);
            this.splitContainer4.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer4.Size = new System.Drawing.Size(961, 494);
            this.splitContainer4.SplitterDistance = 313;
            this.splitContainer4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Database:";
            // 
            // cbFillDatabases
            // 
            this.cbFillDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFillDatabases.FormattingEnabled = true;
            this.cbFillDatabases.Location = new System.Drawing.Point(15, 31);
            this.cbFillDatabases.Name = "cbFillDatabases";
            this.cbFillDatabases.Size = new System.Drawing.Size(277, 24);
            this.cbFillDatabases.TabIndex = 4;
            this.cbFillDatabases.SelectedIndexChanged += new System.EventHandler(this.cbFillDatabaseSelIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Table:";
            // 
            // cbFillTables
            // 
            this.cbFillTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFillTables.FormattingEnabled = true;
            this.cbFillTables.Location = new System.Drawing.Point(15, 94);
            this.cbFillTables.Name = "cbFillTables";
            this.cbFillTables.Size = new System.Drawing.Size(277, 24);
            this.cbFillTables.TabIndex = 6;
            this.cbFillTables.SelectedIndexChanged += new System.EventHandler(this.cbFillTableSelIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Column:";
            // 
            // cbFillColumn
            // 
            this.cbFillColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFillColumn.FormattingEnabled = true;
            this.cbFillColumn.Location = new System.Drawing.Point(15, 160);
            this.cbFillColumn.Name = "cbFillColumn";
            this.cbFillColumn.Size = new System.Drawing.Size(277, 24);
            this.cbFillColumn.TabIndex = 8;
            // 
            // btnFillInit
            // 
            this.btnFillInit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFillInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFillInit.Location = new System.Drawing.Point(3, 3);
            this.btnFillInit.Name = "btnFillInit";
            this.btnFillInit.Size = new System.Drawing.Size(62, 25);
            this.btnFillInit.TabIndex = 2;
            this.btnFillInit.Text = "Init";
            this.btnFillInit.UseVisualStyleBackColor = true;
            this.btnFillInit.Click += new System.EventHandler(this.btnFillInit_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(640, 490);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txFillCmd);
            this.tabPage6.Controls.Add(this.btnTestCommand);
            this.tabPage6.Controls.Add(this.btnFillExec);
            this.tabPage6.Controls.Add(this.txFillStep);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.txFillMax);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.txFillMin);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.cbFillDataTypes);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(632, 464);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "1 Column Auto Index";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(632, 464);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(581, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Filling single coumn with given data type, assuming the (potential) primary key i" +
    "s autoincremented";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(6, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Data Type:";
            // 
            // cbFillDataTypes
            // 
            this.cbFillDataTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFillDataTypes.FormattingEnabled = true;
            this.cbFillDataTypes.Items.AddRange(new object[] {
            "Numeric",
            "String",
            "Date / Time"});
            this.cbFillDataTypes.Location = new System.Drawing.Point(97, 38);
            this.cbFillDataTypes.Name = "cbFillDataTypes";
            this.cbFillDataTypes.Size = new System.Drawing.Size(200, 24);
            this.cbFillDataTypes.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(55, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Min:";
            // 
            // txFillMin
            // 
            this.txFillMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txFillMin.Location = new System.Drawing.Point(97, 77);
            this.txFillMin.Name = "txFillMin";
            this.txFillMin.Size = new System.Drawing.Size(78, 22);
            this.txFillMin.TabIndex = 12;
            this.txFillMin.Text = "0";
            this.txFillMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(225, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Min:";
            // 
            // txFillMax
            // 
            this.txFillMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txFillMax.Location = new System.Drawing.Point(267, 77);
            this.txFillMax.Name = "txFillMax";
            this.txFillMax.Size = new System.Drawing.Size(78, 22);
            this.txFillMax.TabIndex = 14;
            this.txFillMax.Text = "100";
            this.txFillMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(390, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Step:";
            // 
            // txFillStep
            // 
            this.txFillStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txFillStep.Location = new System.Drawing.Point(440, 77);
            this.txFillStep.Name = "txFillStep";
            this.txFillStep.Size = new System.Drawing.Size(78, 22);
            this.txFillStep.TabIndex = 16;
            this.txFillStep.Text = "1";
            this.txFillStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFillExec
            // 
            this.btnFillExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFillExec.Location = new System.Drawing.Point(168, 223);
            this.btnFillExec.Name = "btnFillExec";
            this.btnFillExec.Size = new System.Drawing.Size(93, 27);
            this.btnFillExec.TabIndex = 17;
            this.btnFillExec.Text = "Execute";
            this.btnFillExec.UseVisualStyleBackColor = true;
            this.btnFillExec.Click += new System.EventHandler(this.btnFillExec_Click);
            // 
            // btnTestCommand
            // 
            this.btnTestCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTestCommand.Location = new System.Drawing.Point(23, 223);
            this.btnTestCommand.Name = "btnTestCommand";
            this.btnTestCommand.Size = new System.Drawing.Size(128, 27);
            this.btnTestCommand.TabIndex = 18;
            this.btnTestCommand.Text = "Generate CMD";
            this.btnTestCommand.UseVisualStyleBackColor = true;
            this.btnTestCommand.Click += new System.EventHandler(this.btnTestCommand_Click);
            // 
            // txFillCmd
            // 
            this.txFillCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txFillCmd.Location = new System.Drawing.Point(23, 119);
            this.txFillCmd.Multiline = true;
            this.txFillCmd.Name = "txFillCmd";
            this.txFillCmd.Size = new System.Drawing.Size(588, 98);
            this.txFillCmd.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 599);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExt1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefreshDb;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.TextBox txDatabaseServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateSql;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnRefreshTables;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefreshColumns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbDatabases;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.DataGridView dgvColumns;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSemicolon;
        private System.Windows.Forms.RadioButton rbComma;
        private System.Windows.Forms.Button btnFindFile1;
        private System.Windows.Forms.TextBox txCsvFile1;
        private System.Windows.Forms.Button btnReadCsv;
        private System.Windows.Forms.DataGridView dgvExt1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ComboBox cbFillColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFillTables;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbFillDatabases;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFillInit;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox cbFillDataTypes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnFillExec;
        private System.Windows.Forms.TextBox txFillStep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txFillMax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txFillMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txFillCmd;
        private System.Windows.Forms.Button btnTestCommand;
    }
}

