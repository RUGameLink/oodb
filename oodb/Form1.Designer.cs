﻿namespace oodb
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.nudServicePrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceTitle = new System.Windows.Forms.TextBox();
            this.cbIsServiceEdit = new System.Windows.Forms.CheckBox();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.serviceDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbHallIsEdit = new System.Windows.Forms.CheckBox();
            this.btnHallAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHallTitle = new System.Windows.Forms.TextBox();
            this.dgvHall = new System.Windows.Forms.DataGridView();
            this.hallDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.cbClientIsEdit = new System.Windows.Forms.CheckBox();
            this.gdvCliet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientSecondName = new System.Windows.Forms.TextBox();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cbIsServiceEdit);
            this.tabPage1.Controls.Add(this.dgvService);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Услуги";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnServiceAdd);
            this.groupBox1.Controls.Add(this.nudServicePrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtServiceTitle);
            this.groupBox1.Location = new System.Drawing.Point(676, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Location = new System.Drawing.Point(125, 159);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(99, 38);
            this.btnServiceAdd.TabIndex = 4;
            this.btnServiceAdd.Text = "Добавить";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            this.btnServiceAdd.Click += new System.EventHandler(this.btnServiceAdd_Click);
            // 
            // nudServicePrice
            // 
            this.nudServicePrice.Location = new System.Drawing.Point(114, 124);
            this.nudServicePrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudServicePrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudServicePrice.Name = "nudServicePrice";
            this.nudServicePrice.Size = new System.Drawing.Size(120, 20);
            this.nudServicePrice.TabIndex = 3;
            this.nudServicePrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // txtServiceTitle
            // 
            this.txtServiceTitle.Location = new System.Drawing.Point(114, 61);
            this.txtServiceTitle.Name = "txtServiceTitle";
            this.txtServiceTitle.Size = new System.Drawing.Size(120, 20);
            this.txtServiceTitle.TabIndex = 0;
            // 
            // cbIsServiceEdit
            // 
            this.cbIsServiceEdit.AutoSize = true;
            this.cbIsServiceEdit.Location = new System.Drawing.Point(770, 34);
            this.cbIsServiceEdit.Name = "cbIsServiceEdit";
            this.cbIsServiceEdit.Size = new System.Drawing.Size(161, 17);
            this.cbIsServiceEdit.TabIndex = 1;
            this.cbIsServiceEdit.Text = "Включить редактирование";
            this.cbIsServiceEdit.UseVisualStyleBackColor = true;
            this.cbIsServiceEdit.CheckedChanged += new System.EventHandler(this.cbIsServiceEdit_CheckedChanged);
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AutoGenerateColumns = false;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.serviceDelete});
            this.dgvService.DataSource = this.serviceBindingSource;
            this.dgvService.Location = new System.Drawing.Point(20, 18);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(619, 480);
            this.dgvService.TabIndex = 0;
            this.dgvService.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvService_CellBeginEdit);
            this.dgvService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellContentClick);
            this.dgvService.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellEndEdit);
            this.dgvService.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tableValidating);
            this.dgvService.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvService_DataError);
            // 
            // serviceDelete
            // 
            this.serviceDelete.HeaderText = "Удаление";
            this.serviceDelete.Name = "serviceDelete";
            this.serviceDelete.Text = "Удалить";
            this.serviceDelete.UseColumnTextForButtonValue = true;
            this.serviceDelete.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbHallIsEdit);
            this.tabPage2.Controls.Add(this.btnHallAdd);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtHallTitle);
            this.tabPage2.Controls.Add(this.dgvHall);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Залы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbHallIsEdit
            // 
            this.cbHallIsEdit.AutoSize = true;
            this.cbHallIsEdit.Location = new System.Drawing.Point(691, 25);
            this.cbHallIsEdit.Name = "cbHallIsEdit";
            this.cbHallIsEdit.Size = new System.Drawing.Size(161, 17);
            this.cbHallIsEdit.TabIndex = 4;
            this.cbHallIsEdit.Text = "Включить редактирование";
            this.cbHallIsEdit.UseVisualStyleBackColor = true;
            this.cbHallIsEdit.CheckedChanged += new System.EventHandler(this.cbHallIsEdit_CheckedChanged);
            // 
            // btnHallAdd
            // 
            this.btnHallAdd.Location = new System.Drawing.Point(715, 148);
            this.btnHallAdd.Name = "btnHallAdd";
            this.btnHallAdd.Size = new System.Drawing.Size(104, 49);
            this.btnHallAdd.TabIndex = 3;
            this.btnHallAdd.Text = "Добавить";
            this.btnHallAdd.UseVisualStyleBackColor = true;
            this.btnHallAdd.Click += new System.EventHandler(this.btnHallAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название зала";
            // 
            // txtHallTitle
            // 
            this.txtHallTitle.Location = new System.Drawing.Point(675, 105);
            this.txtHallTitle.Name = "txtHallTitle";
            this.txtHallTitle.Size = new System.Drawing.Size(175, 20);
            this.txtHallTitle.TabIndex = 1;
            // 
            // dgvHall
            // 
            this.dgvHall.AllowUserToAddRows = false;
            this.dgvHall.AutoGenerateColumns = false;
            this.dgvHall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.hallDelete});
            this.dgvHall.DataSource = this.hallBindingSource;
            this.dgvHall.Location = new System.Drawing.Point(30, 37);
            this.dgvHall.Name = "dgvHall";
            this.dgvHall.Size = new System.Drawing.Size(483, 463);
            this.dgvHall.TabIndex = 0;
            this.dgvHall.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvHall_CellBeginEdit);
            this.dgvHall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHall_CellContentClick);
            this.dgvHall.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHall_CellEndEdit);
            this.dgvHall.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tableValidating);
            // 
            // hallDelete
            // 
            this.hallDelete.HeaderText = "Удаление";
            this.hallDelete.Name = "hallDelete";
            this.hallDelete.Text = "Удалить";
            this.hallDelete.UseColumnTextForButtonValue = true;
            this.hallDelete.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClientAdd);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtClientPhone);
            this.tabPage3.Controls.Add(this.txtClientAddress);
            this.tabPage3.Controls.Add(this.txtClientLastName);
            this.tabPage3.Controls.Add(this.txtClientSecondName);
            this.tabPage3.Controls.Add(this.txtClientName);
            this.tabPage3.Controls.Add(this.cbClientIsEdit);
            this.tabPage3.Controls.Add(this.dgvClient);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1031, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Клиент";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.adressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.gdvCliet});
            this.dgvClient.DataSource = this.clientBindingSource;
            this.dgvClient.Location = new System.Drawing.Point(21, 18);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(730, 482);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvClient_CellBeginEdit);
            this.dgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellContentClick);
            this.dgvClient.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellEndEdit);
            this.dgvClient.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tableValidating);
            // 
            // cbClientIsEdit
            // 
            this.cbClientIsEdit.AutoSize = true;
            this.cbClientIsEdit.Location = new System.Drawing.Point(807, 29);
            this.cbClientIsEdit.Name = "cbClientIsEdit";
            this.cbClientIsEdit.Size = new System.Drawing.Size(161, 17);
            this.cbClientIsEdit.TabIndex = 1;
            this.cbClientIsEdit.Text = "Включить редактирование";
            this.cbClientIsEdit.UseVisualStyleBackColor = true;
            this.cbClientIsEdit.CheckedChanged += new System.EventHandler(this.cbClientIsEdit_CheckedChanged);
            // 
            // gdvCliet
            // 
            this.gdvCliet.HeaderText = "Удаление";
            this.gdvCliet.Name = "gdvCliet";
            this.gdvCliet.Text = "Удалить";
            this.gdvCliet.UseColumnTextForButtonValue = true;
            this.gdvCliet.Visible = false;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(813, 89);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(155, 20);
            this.txtClientName.TabIndex = 2;
            // 
            // txtClientSecondName
            // 
            this.txtClientSecondName.Location = new System.Drawing.Point(813, 148);
            this.txtClientSecondName.Name = "txtClientSecondName";
            this.txtClientSecondName.Size = new System.Drawing.Size(155, 20);
            this.txtClientSecondName.TabIndex = 3;
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(813, 209);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(155, 20);
            this.txtClientLastName.TabIndex = 4;
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(813, 273);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(155, 20);
            this.txtClientAddress.TabIndex = 5;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(813, 332);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(155, 20);
            this.txtClientPhone.TabIndex = 6;
            this.txtClientPhone.TextChanged += new System.EventHandler(this.txtClientPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(863, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Фамилия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(871, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(864, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Телефон";
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.Location = new System.Drawing.Point(837, 386);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(106, 48);
            this.btnClientAdd.TabIndex = 12;
            this.btnClientAdd.Text = "Добавить";
            this.btnClientAdd.UseVisualStyleBackColor = true;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название услуги";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(oodb.Classes.Service);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Зал";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hallBindingSource
            // 
            this.hallBindingSource.DataSource = typeof(oodb.Classes.Hall);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес клиента";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон клиента";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя клиента";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия клиента";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество клиента";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(oodb.Classes.Client);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 565);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.CheckBox cbIsServiceEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn serviceDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.NumericUpDown nudServicePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceTitle;
        private System.Windows.Forms.DataGridView dgvHall;
        private System.Windows.Forms.BindingSource hallBindingSource;
        private System.Windows.Forms.Button btnHallAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHallTitle;
        private System.Windows.Forms.CheckBox cbHallIsEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn hallDelete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbClientIsEdit;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn gdvCliet;
        private System.Windows.Forms.Button btnClientAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtClientSecondName;
        private System.Windows.Forms.TextBox txtClientName;
    }
}

