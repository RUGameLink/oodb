using oodb.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodb
{
    public partial class Form1 : Form
    {
        #region Настройка формы
        DataBase dataBase;
        static Random random = new Random();
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
        public Form1()
        {
            InitializeComponent();
            dataBase = new DataBase();
            dataBase.dbConnect();
            var service = new Service();
            service.title = "Service" + random.Next(0, 10000);
            service.price = random.Next(100, 1000);
            dataBase.AddService(service);
            bindingSourceSetting();
        }
        void bindingSourceSetting()
        {
            foreach (var s in dataBase.GetService())
            {
                serviceBindingSource.Add(s);
            }
        }
        #endregion
        #region Утилиты
        void messageBoxSuccessAdd()
        {
            MessageBox.Show("Запись успешно добавлена",
                    "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
        void messageBoxError(string message)
        {
            MessageBox.Show(message,
                    "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        DialogResult messageBoxClickResult(string message)
        {
            var dialogResult = MessageBox.Show(message,
                "Предупреждение",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            return dialogResult;
        }
        string generateString(int from, int to)
        {
            return new string(Enumerable.Repeat(chars, random.Next(from, to))
        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //Отменение изменений
        private void tableValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                ((DataGridView)sender).CancelEdit();
                ((DataGridView)sender).EndEdit();
            }

        }
        #endregion
        #region Работа с услугой
        private void cbIsServiceEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(cbIsServiceEdit.Checked == true)
            {
                dgvService.Columns[1].ReadOnly = false;
                dgvService.Columns[2].ReadOnly = false;
                dgvService.Columns[3].Visible = true;
            }
            else
            {
                dgvService.Columns[1].ReadOnly = true;
                dgvService.Columns[2].ReadOnly = true;
                dgvService.Columns[3].Visible = false;
            }
        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvService.Columns[e.ColumnIndex].Index == dgvService.Columns.Count - 1)
            {
                if (messageBoxClickResult("Удалить эту запись?") == DialogResult.Yes)
                {
                    var id = dgvService.Rows[e.RowIndex].Cells[0].Value.ToString();
                    serviceBindingSource.RemoveAt(e.RowIndex);
                    dataBase.DeleteService(id);
                }
            }
        }

        Service selectedService;
        private void dgvService_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            selectedService = new Service();
            selectedService.id = dgvService.Rows[e.RowIndex].Cells[0].Value.ToString();
            selectedService.title = dgvService.Rows[e.RowIndex].Cells[1].Value.ToString();
            selectedService.price = (int)dgvService.Rows[e.RowIndex].Cells[2].Value;
            Console.WriteLine();
        }

        private void dgvService_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var service = new Service();
            if((int)dgvService.Rows[e.RowIndex].Cells[2].Value < 100)
            {
                messageBoxError("Некорректная цена");
                return;
            }
            service.id = dgvService.Rows[e.RowIndex].Cells[0].Value.ToString();
            service.title = dgvService.Rows[e.RowIndex].Cells[1].Value.ToString();
            service.price = (int)dgvService.Rows[e.RowIndex].Cells[2].Value;
            var dialogResult = messageBoxClickResult("Изменить эту запись?");
            if (dialogResult == DialogResult.No)
            {
                dgvService.Rows[e.RowIndex].Cells[1].Value = selectedService.title;
                dgvService.Rows[e.RowIndex].Cells[2].Value = selectedService.price;
                return;
            }
            if (dialogResult == DialogResult.Yes)
            {

                dataBase.UpdateService(dgvService.CurrentRow.DataBoundItem as Service);
            }
        }

        private void dgvService_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            messageBoxError("Введите числовое значение");
            dgvService.Rows[e.RowIndex].Cells[2].Value = selectedService.price;
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceTitle.Text)){
                messageBoxError("Вы не ввели название");
                return;
            }
            var service = new Service();
            service.price = (int)nudServicePrice.Value;
            service.title = txtServiceTitle.Text;
            dataBase.AddService(service);
            txtServiceTitle.Clear();
            serviceBindingSource.Add(service);
            messageBoxSuccessAdd();
        }
        #endregion
    }
}
