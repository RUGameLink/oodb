namespace oodb
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.cbIsServiceEdit = new System.Windows.Forms.CheckBox();
            this.serviceDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServiceTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudServicePrice = new System.Windows.Forms.NumericUpDown();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // serviceDelete
            // 
            this.serviceDelete.HeaderText = "Удаление";
            this.serviceDelete.Name = "serviceDelete";
            this.serviceDelete.Text = "Удалить";
            this.serviceDelete.UseColumnTextForButtonValue = true;
            this.serviceDelete.Visible = false;
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
            // txtServiceTitle
            // 
            this.txtServiceTitle.Location = new System.Drawing.Point(114, 61);
            this.txtServiceTitle.Name = "txtServiceTitle";
            this.txtServiceTitle.Size = new System.Drawing.Size(120, 20);
            this.txtServiceTitle.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicePrice)).EndInit();
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
    }
}

