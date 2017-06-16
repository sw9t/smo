namespace SMO_UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сМОСОтказамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сМОСОграниченнойОчередьюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сМОСНеограниченнойОчередьюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызовСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataInputGB = new System.Windows.Forms.GroupBox();
            this.TypeSelectCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SysStatesLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SolveBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SysProbabilitesLV = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_ozh_lbl = new System.Windows.Forms.Label();
            this.t_sist_lbl = new System.Windows.Forms.Label();
            this.r_lbl = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.t_sist = new System.Windows.Forms.Label();
            this.t_ozh = new System.Windows.Forms.Label();
            this.kz = new System.Windows.Forms.Label();
            this.ns = new System.Windows.Forms.Label();
            this.nz = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.p_obs = new System.Windows.Forms.Label();
            this.p_otk = new System.Windows.Forms.Label();
            this.kpr = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.S_lbl = new System.Windows.Forms.Label();
            this.AddChannelBtn = new System.Windows.Forms.Button();
            this.AddRChannelsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.задачаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // задачаToolStripMenuItem
            // 
            this.задачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сМОСОтказамиToolStripMenuItem,
            this.сМОСОграниченнойОчередьюToolStripMenuItem,
            this.сМОСНеограниченнойОчередьюToolStripMenuItem});
            this.задачаToolStripMenuItem.Name = "задачаToolStripMenuItem";
            this.задачаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.задачаToolStripMenuItem.Text = "Задача";
            // 
            // сМОСОтказамиToolStripMenuItem
            // 
            this.сМОСОтказамиToolStripMenuItem.CheckOnClick = true;
            this.сМОСОтказамиToolStripMenuItem.Name = "сМОСОтказамиToolStripMenuItem";
            this.сМОСОтказамиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.сМОСОтказамиToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.сМОСОтказамиToolStripMenuItem.Text = "СМО с отказами";
            this.сМОСОтказамиToolStripMenuItem.Click += new System.EventHandler(this.сМОСОтказамиToolStripMenuItem_Click);
            // 
            // сМОСОграниченнойОчередьюToolStripMenuItem
            // 
            this.сМОСОграниченнойОчередьюToolStripMenuItem.CheckOnClick = true;
            this.сМОСОграниченнойОчередьюToolStripMenuItem.Name = "сМОСОграниченнойОчередьюToolStripMenuItem";
            this.сМОСОграниченнойОчередьюToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.сМОСОграниченнойОчередьюToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.сМОСОграниченнойОчередьюToolStripMenuItem.Text = "СМО с ограниченной очередью";
            this.сМОСОграниченнойОчередьюToolStripMenuItem.Click += new System.EventHandler(this.сМОСОграниченнойОчередьюToolStripMenuItem_Click);
            // 
            // сМОСНеограниченнойОчередьюToolStripMenuItem
            // 
            this.сМОСНеограниченнойОчередьюToolStripMenuItem.CheckOnClick = true;
            this.сМОСНеограниченнойОчередьюToolStripMenuItem.Name = "сМОСНеограниченнойОчередьюToolStripMenuItem";
            this.сМОСНеограниченнойОчередьюToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.сМОСНеограниченнойОчередьюToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.сМОСНеограниченнойОчередьюToolStripMenuItem.Text = "СМО с неограниченной очередью";
            this.сМОСНеограниченнойОчередьюToolStripMenuItem.Click += new System.EventHandler(this.сМОСНеограниченнойОчередьюToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызовСправкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // вызовСправкиToolStripMenuItem
            // 
            this.вызовСправкиToolStripMenuItem.Name = "вызовСправкиToolStripMenuItem";
            this.вызовСправкиToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.вызовСправкиToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.вызовСправкиToolStripMenuItem.Text = "Вызов справки";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // DataInputGB
            // 
            this.DataInputGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataInputGB.BackColor = System.Drawing.Color.Transparent;
            this.DataInputGB.Location = new System.Drawing.Point(12, 67);
            this.DataInputGB.Name = "DataInputGB";
            this.DataInputGB.Size = new System.Drawing.Size(200, 406);
            this.DataInputGB.TabIndex = 1;
            this.DataInputGB.TabStop = false;
            this.DataInputGB.Text = "Данные условия задачи";
            // 
            // TypeSelectCB
            // 
            this.TypeSelectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSelectCB.FormattingEnabled = true;
            this.TypeSelectCB.Items.AddRange(new object[] {
            "С отказами",
            "С ограниченной очередью",
            "С неограниченной очередью"});
            this.TypeSelectCB.Location = new System.Drawing.Point(12, 40);
            this.TypeSelectCB.Name = "TypeSelectCB";
            this.TypeSelectCB.Size = new System.Drawing.Size(200, 21);
            this.TypeSelectCB.TabIndex = 2;
            this.TypeSelectCB.SelectedIndexChanged += new System.EventHandler(this.TypeSelectCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип задачи для СМО:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.SysStatesLV);
            this.groupBox1.Location = new System.Drawing.Point(218, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 250);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возможные состояния системы";
            // 
            // SysStatesLV
            // 
            this.SysStatesLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SysStatesLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SysStatesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.SysStatesLV.FullRowSelect = true;
            this.SysStatesLV.GridLines = true;
            this.SysStatesLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SysStatesLV.Location = new System.Drawing.Point(6, 19);
            this.SysStatesLV.Name = "SysStatesLV";
            this.SysStatesLV.Size = new System.Drawing.Size(386, 225);
            this.SysStatesLV.TabIndex = 0;
            this.SysStatesLV.UseCompatibleStateImageBehavior = false;
            this.SysStatesLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Состояние";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Занято";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Свободно";
            this.columnHeader3.Width = 179;
            // 
            // SolveBtn
            // 
            this.SolveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SolveBtn.Location = new System.Drawing.Point(12, 479);
            this.SolveBtn.Name = "SolveBtn";
            this.SolveBtn.Size = new System.Drawing.Size(200, 41);
            this.SolveBtn.TabIndex = 5;
            this.SolveBtn.Text = "Найти решение задачи";
            this.SolveBtn.UseVisualStyleBackColor = true;
            this.SolveBtn.Click += new System.EventHandler(this.SolveBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ResetBtn.Location = new System.Drawing.Point(12, 526);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(200, 23);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Очистить поля данных";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.SysProbabilitesLV);
            this.groupBox2.Location = new System.Drawing.Point(622, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 250);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вероятности состояний СМО";
            // 
            // SysProbabilitesLV
            // 
            this.SysProbabilitesLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SysProbabilitesLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SysProbabilitesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6});
            this.SysProbabilitesLV.FullRowSelect = true;
            this.SysProbabilitesLV.GridLines = true;
            this.SysProbabilitesLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SysProbabilitesLV.Location = new System.Drawing.Point(6, 19);
            this.SysProbabilitesLV.Name = "SysProbabilitesLV";
            this.SysProbabilitesLV.Size = new System.Drawing.Size(338, 225);
            this.SysProbabilitesLV.TabIndex = 0;
            this.SysProbabilitesLV.UseCompatibleStateImageBehavior = false;
            this.SysProbabilitesLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "P";
            this.columnHeader4.Width = 38;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Значение";
            this.columnHeader6.Width = 277;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(218, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вероятность отказа:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(218, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вероятность обслуживания:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(218, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Абсолютная пропускная способность:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(218, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Среднее число занятых площадок:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(218, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Среднее число свободных площадок:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(218, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Коэффициент загрузки площадки:";
            // 
            // t_ozh_lbl
            // 
            this.t_ozh_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_ozh_lbl.AutoSize = true;
            this.t_ozh_lbl.BackColor = System.Drawing.Color.Transparent;
            this.t_ozh_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_ozh_lbl.Location = new System.Drawing.Point(218, 430);
            this.t_ozh_lbl.Name = "t_ozh_lbl";
            this.t_ozh_lbl.Size = new System.Drawing.Size(248, 16);
            this.t_ozh_lbl.TabIndex = 13;
            this.t_ozh_lbl.Text = "Среднее время ожидания в очереди:";
            // 
            // t_sist_lbl
            // 
            this.t_sist_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_sist_lbl.AutoSize = true;
            this.t_sist_lbl.BackColor = System.Drawing.Color.Transparent;
            this.t_sist_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_sist_lbl.Location = new System.Drawing.Point(218, 450);
            this.t_sist_lbl.Name = "t_sist_lbl";
            this.t_sist_lbl.Size = new System.Drawing.Size(236, 16);
            this.t_sist_lbl.TabIndex = 15;
            this.t_sist_lbl.Text = "Среднее время нахождения в СМО:";
            // 
            // r_lbl
            // 
            this.r_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.r_lbl.AutoSize = true;
            this.r_lbl.BackColor = System.Drawing.Color.Transparent;
            this.r_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_lbl.Location = new System.Drawing.Point(218, 470);
            this.r_lbl.Name = "r_lbl";
            this.r_lbl.Size = new System.Drawing.Size(168, 16);
            this.r_lbl.TabIndex = 16;
            this.r_lbl.Text = "Средняя длина очереди:";
            // 
            // r
            // 
            this.r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.r.AutoSize = true;
            this.r.BackColor = System.Drawing.Color.Transparent;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r.Location = new System.Drawing.Point(499, 470);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(0, 16);
            this.r.TabIndex = 25;
            // 
            // t_sist
            // 
            this.t_sist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_sist.AutoSize = true;
            this.t_sist.BackColor = System.Drawing.Color.Transparent;
            this.t_sist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_sist.Location = new System.Drawing.Point(499, 450);
            this.t_sist.Name = "t_sist";
            this.t_sist.Size = new System.Drawing.Size(0, 16);
            this.t_sist.TabIndex = 24;
            // 
            // t_ozh
            // 
            this.t_ozh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_ozh.AutoSize = true;
            this.t_ozh.BackColor = System.Drawing.Color.Transparent;
            this.t_ozh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_ozh.Location = new System.Drawing.Point(499, 430);
            this.t_ozh.Name = "t_ozh";
            this.t_ozh.Size = new System.Drawing.Size(0, 16);
            this.t_ozh.TabIndex = 23;
            // 
            // kz
            // 
            this.kz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kz.AutoSize = true;
            this.kz.BackColor = System.Drawing.Color.Transparent;
            this.kz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kz.Location = new System.Drawing.Point(499, 390);
            this.kz.Name = "kz";
            this.kz.Size = new System.Drawing.Size(0, 16);
            this.kz.TabIndex = 22;
            // 
            // ns
            // 
            this.ns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ns.AutoSize = true;
            this.ns.BackColor = System.Drawing.Color.Transparent;
            this.ns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ns.Location = new System.Drawing.Point(499, 370);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(0, 16);
            this.ns.TabIndex = 21;
            // 
            // nz
            // 
            this.nz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nz.AutoSize = true;
            this.nz.BackColor = System.Drawing.Color.Transparent;
            this.nz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nz.Location = new System.Drawing.Point(499, 350);
            this.nz.Name = "nz";
            this.nz.Size = new System.Drawing.Size(0, 16);
            this.nz.TabIndex = 20;
            // 
            // A
            // 
            this.A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.A.AutoSize = true;
            this.A.BackColor = System.Drawing.Color.Transparent;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.Location = new System.Drawing.Point(499, 330);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(0, 16);
            this.A.TabIndex = 19;
            // 
            // p_obs
            // 
            this.p_obs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p_obs.AutoSize = true;
            this.p_obs.BackColor = System.Drawing.Color.Transparent;
            this.p_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p_obs.Location = new System.Drawing.Point(499, 310);
            this.p_obs.Name = "p_obs";
            this.p_obs.Size = new System.Drawing.Size(0, 16);
            this.p_obs.TabIndex = 18;
            // 
            // p_otk
            // 
            this.p_otk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p_otk.AutoSize = true;
            this.p_otk.BackColor = System.Drawing.Color.Transparent;
            this.p_otk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p_otk.Location = new System.Drawing.Point(499, 290);
            this.p_otk.Name = "p_otk";
            this.p_otk.Size = new System.Drawing.Size(0, 16);
            this.p_otk.TabIndex = 17;
            // 
            // kpr
            // 
            this.kpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kpr.AutoSize = true;
            this.kpr.BackColor = System.Drawing.Color.Transparent;
            this.kpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kpr.Location = new System.Drawing.Point(499, 410);
            this.kpr.Name = "kpr";
            this.kpr.Size = new System.Drawing.Size(0, 16);
            this.kpr.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(218, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(227, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Коэффициент простоя площадки:";
            // 
            // S
            // 
            this.S.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.S.AutoSize = true;
            this.S.BackColor = System.Drawing.Color.Transparent;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S.Location = new System.Drawing.Point(499, 490);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(0, 16);
            this.S.TabIndex = 29;
            // 
            // S_lbl
            // 
            this.S_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.S_lbl.AutoSize = true;
            this.S_lbl.BackColor = System.Drawing.Color.Transparent;
            this.S_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S_lbl.Location = new System.Drawing.Point(218, 490);
            this.S_lbl.Name = "S_lbl";
            this.S_lbl.Size = new System.Drawing.Size(184, 16);
            this.S_lbl.TabIndex = 28;
            this.S_lbl.Text = "Полезная площадь склада:";
            // 
            // AddChannelBtn
            // 
            this.AddChannelBtn.Location = new System.Drawing.Point(674, 307);
            this.AddChannelBtn.Name = "AddChannelBtn";
            this.AddChannelBtn.Size = new System.Drawing.Size(98, 23);
            this.AddChannelBtn.TabIndex = 30;
            this.AddChannelBtn.Text = "Добавить канал";
            this.AddChannelBtn.UseVisualStyleBackColor = true;
            this.AddChannelBtn.Visible = false;
            this.AddChannelBtn.Click += new System.EventHandler(this.AddChannelBtn_Click);
            // 
            // AddRChannelsBtn
            // 
            this.AddRChannelsBtn.Location = new System.Drawing.Point(674, 467);
            this.AddRChannelsBtn.Name = "AddRChannelsBtn";
            this.AddRChannelsBtn.Size = new System.Drawing.Size(98, 23);
            this.AddRChannelsBtn.TabIndex = 31;
            this.AddRChannelsBtn.Text = "Добавить канал";
            this.AddRChannelsBtn.UseVisualStyleBackColor = true;
            this.AddRChannelsBtn.Visible = false;
            this.AddRChannelsBtn.Click += new System.EventHandler(this.AddChannelBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SMO_UI.Properties.Resources.daemon;
            this.pictureBox1.Location = new System.Drawing.Point(792, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.SolveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMO_UI.Properties.Resources.bg;
            this.CancelButton = this.ResetBtn;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddRChannelsBtn);
            this.Controls.Add(this.AddChannelBtn);
            this.Controls.Add(this.S);
            this.Controls.Add(this.S_lbl);
            this.Controls.Add(this.kpr);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.r);
            this.Controls.Add(this.t_sist);
            this.Controls.Add(this.t_ozh);
            this.Controls.Add(this.kz);
            this.Controls.Add(this.ns);
            this.Controls.Add(this.nz);
            this.Controls.Add(this.A);
            this.Controls.Add(this.p_obs);
            this.Controls.Add(this.p_otk);
            this.Controls.Add(this.r_lbl);
            this.Controls.Add(this.t_sist_lbl);
            this.Controls.Add(this.t_ozh_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SolveBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeSelectCB);
            this.Controls.Add(this.DataInputGB);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "Программа для решения задач с системами массового обслуживания (СМО)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox DataInputGB;
        private System.Windows.Forms.ComboBox TypeSelectCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView SysStatesLV;
        private System.Windows.Forms.Button SolveBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView SysProbabilitesLV;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label t_ozh_lbl;
        private System.Windows.Forms.Label t_sist_lbl;
        private System.Windows.Forms.Label r_lbl;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label t_sist;
        private System.Windows.Forms.Label t_ozh;
        private System.Windows.Forms.Label kz;
        private System.Windows.Forms.Label ns;
        private System.Windows.Forms.Label nz;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label p_obs;
        private System.Windows.Forms.Label p_otk;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вызовСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачаToolStripMenuItem;
        private System.Windows.Forms.Label kpr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label S_lbl;
        private System.Windows.Forms.ToolStripMenuItem сМОСОтказамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сМОСОграниченнойОчередьюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сМОСНеограниченнойОчередьюToolStripMenuItem;
        private System.Windows.Forms.Button AddChannelBtn;
        private System.Windows.Forms.Button AddRChannelsBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}