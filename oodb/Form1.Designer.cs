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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbHallIsEdit = new System.Windows.Forms.CheckBox();
            this.btnHallAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHallTitle = new System.Windows.Forms.TextBox();
            this.dgvHall = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientSecondName = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.cbClientIsEdit = new System.Windows.Forms.CheckBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdvCliet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClubCardAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudClubCardPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpClubCardEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpClubCardStart = new System.Windows.Forms.DateTimePicker();
            this.cmbClubCardService = new System.Windows.Forms.ComboBox();
            this.cmbClubCardClient = new System.Windows.Forms.ComboBox();
            this.cbIsClubCardEdit = new System.Windows.Forms.CheckBox();
            this.dgvClubCard = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubCardDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clubCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.txtStaffLastName = new System.Windows.Forms.TextBox();
            this.txtStaffSecondName = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.cbIsStaffEdit = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClubCardPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubCardBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
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
            // serviceDelete
            // 
            this.serviceDelete.HeaderText = "Удаление";
            this.serviceDelete.Name = "serviceDelete";
            this.serviceDelete.Text = "Удалить";
            this.serviceDelete.UseColumnTextForButtonValue = true;
            this.serviceDelete.Visible = false;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(oodb.Classes.Service);
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
            // hallDelete
            // 
            this.hallDelete.HeaderText = "Удаление";
            this.hallDelete.Name = "hallDelete";
            this.hallDelete.Text = "Удалить";
            this.hallDelete.UseColumnTextForButtonValue = true;
            this.hallDelete.Visible = false;
            // 
            // hallBindingSource
            // 
            this.hallBindingSource.DataSource = typeof(oodb.Classes.Hall);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(864, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Телефон";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Фамилия";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя";
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(813, 332);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(155, 20);
            this.txtClientPhone.TabIndex = 6;
            this.txtClientPhone.TextChanged += new System.EventHandler(this.txtClientPhone_TextChanged);
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(813, 273);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(155, 20);
            this.txtClientAddress.TabIndex = 5;
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(813, 209);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(155, 20);
            this.txtClientLastName.TabIndex = 4;
            // 
            // txtClientSecondName
            // 
            this.txtClientSecondName.Location = new System.Drawing.Point(813, 148);
            this.txtClientSecondName.Name = "txtClientSecondName";
            this.txtClientSecondName.Size = new System.Drawing.Size(155, 20);
            this.txtClientSecondName.TabIndex = 3;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(813, 89);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(155, 20);
            this.txtClientName.TabIndex = 2;
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
            // gdvCliet
            // 
            this.gdvCliet.HeaderText = "Удаление";
            this.gdvCliet.Name = "gdvCliet";
            this.gdvCliet.Text = "Удалить";
            this.gdvCliet.UseColumnTextForButtonValue = true;
            this.gdvCliet.Visible = false;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(oodb.Classes.Client);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClubCardAdd);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.nudClubCardPrice);
            this.tabPage4.Controls.Add(this.dtpClubCardEnd);
            this.tabPage4.Controls.Add(this.dtpClubCardStart);
            this.tabPage4.Controls.Add(this.cmbClubCardService);
            this.tabPage4.Controls.Add(this.cmbClubCardClient);
            this.tabPage4.Controls.Add(this.cbIsClubCardEdit);
            this.tabPage4.Controls.Add(this.dgvClubCard);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1031, 526);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Абонименты";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnClubCardAdd
            // 
            this.btnClubCardAdd.Location = new System.Drawing.Point(855, 359);
            this.btnClubCardAdd.Name = "btnClubCardAdd";
            this.btnClubCardAdd.Size = new System.Drawing.Size(91, 39);
            this.btnClubCardAdd.TabIndex = 12;
            this.btnClubCardAdd.Text = "Добавить";
            this.btnClubCardAdd.UseVisualStyleBackColor = true;
            this.btnClubCardAdd.Click += new System.EventHandler(this.btnClubCardAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(869, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Стоимость";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(867, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Дата конца";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(865, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Дата начала";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(879, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Услуга";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(879, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Клиент";
            // 
            // nudClubCardPrice
            // 
            this.nudClubCardPrice.Location = new System.Drawing.Point(831, 321);
            this.nudClubCardPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudClubCardPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClubCardPrice.Name = "nudClubCardPrice";
            this.nudClubCardPrice.Size = new System.Drawing.Size(139, 20);
            this.nudClubCardPrice.TabIndex = 6;
            this.nudClubCardPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpClubCardEnd
            // 
            this.dtpClubCardEnd.Location = new System.Drawing.Point(831, 268);
            this.dtpClubCardEnd.Name = "dtpClubCardEnd";
            this.dtpClubCardEnd.Size = new System.Drawing.Size(139, 20);
            this.dtpClubCardEnd.TabIndex = 5;
            // 
            // dtpClubCardStart
            // 
            this.dtpClubCardStart.Location = new System.Drawing.Point(831, 215);
            this.dtpClubCardStart.Name = "dtpClubCardStart";
            this.dtpClubCardStart.Size = new System.Drawing.Size(139, 20);
            this.dtpClubCardStart.TabIndex = 4;
            // 
            // cmbClubCardService
            // 
            this.cmbClubCardService.DataSource = this.serviceBindingSource;
            this.cmbClubCardService.DisplayMember = "title";
            this.cmbClubCardService.FormattingEnabled = true;
            this.cmbClubCardService.Location = new System.Drawing.Point(831, 161);
            this.cmbClubCardService.Name = "cmbClubCardService";
            this.cmbClubCardService.Size = new System.Drawing.Size(139, 21);
            this.cmbClubCardService.TabIndex = 3;
            this.cmbClubCardService.ValueMember = "id";
            // 
            // cmbClubCardClient
            // 
            this.cmbClubCardClient.DataSource = this.clientBindingSource;
            this.cmbClubCardClient.DisplayMember = "surname";
            this.cmbClubCardClient.FormattingEnabled = true;
            this.cmbClubCardClient.Location = new System.Drawing.Point(831, 107);
            this.cmbClubCardClient.Name = "cmbClubCardClient";
            this.cmbClubCardClient.Size = new System.Drawing.Size(139, 21);
            this.cmbClubCardClient.TabIndex = 2;
            this.cmbClubCardClient.ValueMember = "id";
            // 
            // cbIsClubCardEdit
            // 
            this.cbIsClubCardEdit.AutoSize = true;
            this.cbIsClubCardEdit.Location = new System.Drawing.Point(847, 53);
            this.cbIsClubCardEdit.Name = "cbIsClubCardEdit";
            this.cbIsClubCardEdit.Size = new System.Drawing.Size(125, 17);
            this.cbIsClubCardEdit.TabIndex = 1;
            this.cbIsClubCardEdit.Text = "Включить удаление";
            this.cbIsClubCardEdit.UseVisualStyleBackColor = true;
            this.cbIsClubCardEdit.CheckedChanged += new System.EventHandler(this.cbIsClubCardEdit_CheckedChanged);
            // 
            // dgvClubCard
            // 
            this.dgvClubCard.AllowUserToAddRows = false;
            this.dgvClubCard.AutoGenerateColumns = false;
            this.dgvClubCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.clientDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.startCardDataGridViewTextBoxColumn,
            this.endCardDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.clubCardDelete});
            this.dgvClubCard.DataSource = this.clubCardBindingSource;
            this.dgvClubCard.Location = new System.Drawing.Point(28, 38);
            this.dgvClubCard.Name = "dgvClubCard";
            this.dgvClubCard.ReadOnly = true;
            this.dgvClubCard.Size = new System.Drawing.Size(728, 468);
            this.dgvClubCard.TabIndex = 0;
            this.dgvClubCard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClubCard_CellContentClick);
            this.dgvClubCard.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tableValidating);
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startCardDataGridViewTextBoxColumn
            // 
            this.startCardDataGridViewTextBoxColumn.DataPropertyName = "startCard";
            this.startCardDataGridViewTextBoxColumn.HeaderText = "Старт карты";
            this.startCardDataGridViewTextBoxColumn.Name = "startCardDataGridViewTextBoxColumn";
            this.startCardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endCardDataGridViewTextBoxColumn
            // 
            this.endCardDataGridViewTextBoxColumn.DataPropertyName = "endCard";
            this.endCardDataGridViewTextBoxColumn.HeaderText = "Конец карты";
            this.endCardDataGridViewTextBoxColumn.Name = "endCardDataGridViewTextBoxColumn";
            this.endCardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена абонемента";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clubCardDelete
            // 
            this.clubCardDelete.HeaderText = "Удаление";
            this.clubCardDelete.Name = "clubCardDelete";
            this.clubCardDelete.ReadOnly = true;
            this.clubCardDelete.Text = "Удалить";
            this.clubCardDelete.UseColumnTextForButtonValue = true;
            this.clubCardDelete.Visible = false;
            // 
            // clubCardBindingSource
            // 
            this.clubCardBindingSource.DataSource = typeof(oodb.Classes.ClubCard);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvStaff);
            this.tabPage5.Controls.Add(this.btnStaffAdd);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.txtStaffPhone);
            this.tabPage5.Controls.Add(this.txtStaffAddress);
            this.tabPage5.Controls.Add(this.txtStaffLastName);
            this.tabPage5.Controls.Add(this.txtStaffSecondName);
            this.tabPage5.Controls.Add(this.txtStaffName);
            this.tabPage5.Controls.Add(this.cbIsStaffEdit);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1031, 526);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Сотрудники";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AutoGenerateColumns = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.adressDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.patronymicDataGridViewTextBoxColumn1,
            this.staffDelete});
            this.dgvStaff.DataSource = this.staffBindingSource;
            this.dgvStaff.Location = new System.Drawing.Point(12, 16);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(730, 482);
            this.dgvStaff.TabIndex = 23;
            this.dgvStaff.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvStaff_CellBeginEdit);
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            this.dgvStaff.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellEndEdit);
            this.dgvStaff.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tableValidating);
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            // 
            // adressDataGridViewTextBoxColumn1
            // 
            this.adressDataGridViewTextBoxColumn1.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn1.HeaderText = "Адрес сотрудника";
            this.adressDataGridViewTextBoxColumn1.Name = "adressDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Телефон сотрудника";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Имя сотрудника";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Фамилия сотрудника";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            // 
            // patronymicDataGridViewTextBoxColumn1
            // 
            this.patronymicDataGridViewTextBoxColumn1.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn1.HeaderText = "Отчество сотрудника";
            this.patronymicDataGridViewTextBoxColumn1.Name = "patronymicDataGridViewTextBoxColumn1";
            // 
            // staffDelete
            // 
            this.staffDelete.HeaderText = "Удаление";
            this.staffDelete.Name = "staffDelete";
            this.staffDelete.Text = "Удалить";
            this.staffDelete.UseColumnTextForButtonValue = true;
            this.staffDelete.Visible = false;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(oodb.Classes.Staff);
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Location = new System.Drawing.Point(842, 383);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(106, 48);
            this.btnStaffAdd.TabIndex = 22;
            this.btnStaffAdd.Text = "Добавить";
            this.btnStaffAdd.UseVisualStyleBackColor = true;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(865, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Телефон";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(872, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Адрес";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(863, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Фамилия";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(864, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Отчество";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(877, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Имя";
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(814, 333);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(155, 20);
            this.txtStaffPhone.TabIndex = 16;
            this.txtStaffPhone.TextChanged += new System.EventHandler(this.txtStaffPhone_TextChanged);
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Location = new System.Drawing.Point(814, 274);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(155, 20);
            this.txtStaffAddress.TabIndex = 15;
            // 
            // txtStaffLastName
            // 
            this.txtStaffLastName.Location = new System.Drawing.Point(814, 210);
            this.txtStaffLastName.Name = "txtStaffLastName";
            this.txtStaffLastName.Size = new System.Drawing.Size(155, 20);
            this.txtStaffLastName.TabIndex = 14;
            // 
            // txtStaffSecondName
            // 
            this.txtStaffSecondName.Location = new System.Drawing.Point(814, 149);
            this.txtStaffSecondName.Name = "txtStaffSecondName";
            this.txtStaffSecondName.Size = new System.Drawing.Size(155, 20);
            this.txtStaffSecondName.TabIndex = 13;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(814, 90);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(155, 20);
            this.txtStaffName.TabIndex = 12;
            // 
            // cbIsStaffEdit
            // 
            this.cbIsStaffEdit.AutoSize = true;
            this.cbIsStaffEdit.Location = new System.Drawing.Point(807, 16);
            this.cbIsStaffEdit.Name = "cbIsStaffEdit";
            this.cbIsStaffEdit.Size = new System.Drawing.Size(161, 17);
            this.cbIsStaffEdit.TabIndex = 1;
            this.cbIsStaffEdit.Text = "Включить редактирование";
            this.cbIsStaffEdit.UseVisualStyleBackColor = true;
            this.cbIsStaffEdit.CheckedChanged += new System.EventHandler(this.cbIsStaffEdit_CheckedChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClubCardPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubCardBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvClubCard;
        private System.Windows.Forms.BindingSource clubCardBindingSource;
        private System.Windows.Forms.CheckBox cbIsClubCardEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn clubCardDelete;
        private System.Windows.Forms.ComboBox cmbClubCardService;
        private System.Windows.Forms.ComboBox cmbClubCardClient;
        private System.Windows.Forms.DateTimePicker dtpClubCardStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudClubCardPrice;
        private System.Windows.Forms.DateTimePicker dtpClubCardEnd;
        private System.Windows.Forms.Button btnClubCardAdd;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.CheckBox cbIsStaffEdit;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.TextBox txtStaffLastName;
        private System.Windows.Forms.TextBox txtStaffSecondName;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn staffDelete;
    }
}

