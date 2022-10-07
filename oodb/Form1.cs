using oodb.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Db4objects.Db4o.Internal.Metadata.HierarchyAnalyzer;

namespace oodb
{
    /// <summary>
    /// Мысли в слух
    /// Поиск абониментов, чьи абонименты заканчиваются или закончились(готово)(linq)
    /// Нельзя оставлять пустой ячейку в сотруднике(понятия не имею почему)(ПОЧИНИЛОСЬ)
    /// Выдача человек у каждого тренера(linq)
    /// Выдача услуги по названию и стоимости(soda)
    /// </summary>
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
            bindingSourceSetting();
            cmbTaskTableDuraction.SelectedIndex = 0;
            dtpClubCardStart.MinDate = DateTime.Now;
            dtpClubCardEnd.MinDate = DateTime.Now.AddDays(1);
            dtpTaskTableDate.Format = DateTimePickerFormat.Custom;
            dtpTaskTableDate.CustomFormat = "MM/dd/yyyy HH:mm";
            dtpTaskTableDate.MinDate = DateTime.Now;
            dgvSearch.DataSource = dataBase.Search();
        }
        void bindingSourceSetting()
        {
            foreach (var s in dataBase.GetService())
            {
                serviceBindingSource.Add(s);
            }
            foreach(var h in dataBase.GetHall())
            {
                hallBindingSource.Add(h);
            }
            foreach(var c in dataBase.GetClient())
            {
                clientBindingSource.Add(c);
            }
            foreach(var cc in dataBase.GetClubCard())
            {
                clubCardBindingSource.Add(cc);
            }
            foreach (var staff in dataBase.GetStaff())
            {
                staffBindingSource.Add(staff);
            }
            foreach(var tt in dataBase.GetTaskTable())
            {
                taskTableBindingSource.Add(tt);
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
            selectedService.Title = dgvService.Rows[e.RowIndex].Cells[1].Value.ToString();
            selectedService.Price = (int)dgvService.Rows[e.RowIndex].Cells[2].Value;
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
            service.Title = dgvService.Rows[e.RowIndex].Cells[1].Value.ToString();
            service.Price = (int)dgvService.Rows[e.RowIndex].Cells[2].Value;
            if (service.Equals(selectedService))
            {
                return;
            }
            var dialogResult = messageBoxClickResult("Изменить эту запись?");
            if (dialogResult == DialogResult.No)
            {
                dgvService.Rows[e.RowIndex].Cells[1].Value = selectedService.Title;
                dgvService.Rows[e.RowIndex].Cells[2].Value = selectedService.Price;
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
            dgvService.Rows[e.RowIndex].Cells[2].Value = selectedService.Price;
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceTitle.Text)){
                messageBoxError("Вы не ввели название");
                return;
            }
            var service = new Service();
            service.Price = (int)nudServicePrice.Value;
            service.Title = txtServiceTitle.Text;
            dataBase.AddService(service);
            txtServiceTitle.Clear();
            serviceBindingSource.Add(service);
            messageBoxSuccessAdd();
        }
        #endregion
        #region работа с залами

        private void dgvHall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvHall.Columns[e.ColumnIndex].Index == dgvHall.Columns.Count - 1)
            {
                if (messageBoxClickResult("Удалить эту запись?") == DialogResult.Yes)
                {
                    var id = dgvHall.Rows[e.RowIndex].Cells[0].Value.ToString();
                    hallBindingSource.RemoveAt(e.RowIndex);
                    dataBase.DeleteHall(id);
                }
            }
        }

        private void btnHallAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHallTitle.Text))
            {
                messageBoxError("Вы не ввели название");
                return;
            }
            var hall = new Hall();
            hall.title = txtHallTitle.Text;
            dataBase.AddHall(hall);
            hallBindingSource.Add(hall);
            txtHallTitle.Clear();
            messageBoxSuccessAdd();
        }

        private void cbHallIsEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHallIsEdit.Checked)
            {
                dgvHall.Columns[1].ReadOnly = false;
                dgvHall.Columns[2].Visible = true;
            }
            else
            {
                dgvHall.Columns[1].ReadOnly = true;
                dgvHall.Columns[2].Visible = false;
            }
        }

        private void dgvHall_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var hall = new Hall();
            hall.id = dgvHall.Rows[e.RowIndex].Cells[0].Value.ToString();
            hall.title = dgvHall.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (hall.Equals(selectedHall))
            {
                return;
            }
            var dialogResult = messageBoxClickResult("Изменить эту запись?");
            if (dialogResult == DialogResult.No)
            {
                dgvHall.Rows[e.RowIndex].Cells[1].Value = selectedHall.title;
                return;
            }
            if (dialogResult == DialogResult.Yes)
            {

                dataBase.UpdateHall(dgvHall.CurrentRow.DataBoundItem as Hall);
            }
        }
        Hall selectedHall;
        private void dgvHall_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            selectedHall = new Hall();
            selectedHall.id = dgvHall.Rows[e.RowIndex].Cells[0].Value.ToString();
            selectedHall.title = dgvHall.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        #endregion
        #region работа с клиентом
        private void cbClientIsEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(cbClientIsEdit.Checked == true)
            {
                dgvClient.Columns[1].ReadOnly = false;
                dgvClient.Columns[2].ReadOnly = false;
                dgvClient.Columns[3].ReadOnly = false;
                dgvClient.Columns[4].ReadOnly = false;
                dgvClient.Columns[5].ReadOnly = false;
                dgvClient.Columns[6].Visible = true;
            }
            else
            {
                dgvClient.Columns[1].ReadOnly = true;
                dgvClient.Columns[2].ReadOnly = true;
                dgvClient.Columns[3].ReadOnly = true;
                dgvClient.Columns[4].ReadOnly = true;
                dgvClient.Columns[5].ReadOnly = true;
                dgvClient.Columns[6].Visible = false;
            }
        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvClient.Columns[e.ColumnIndex].Index == dgvClient.Columns.Count - 1)
            {
                if (messageBoxClickResult("Удалить эту запись?") == DialogResult.Yes)
                {
                    var id = dgvClient.Rows[e.RowIndex].Cells[0].Value.ToString();
                    clientBindingSource.RemoveAt(e.RowIndex);
                    dataBase.DeleteClient(id);
                }
            }
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientName.Text))
            {
                messageBoxError("Вы не ввели имя");
                return;
            }
            if (string.IsNullOrEmpty(txtClientSecondName.Text))
            {
                messageBoxError("Вы не ввели отчество");
                return;
            }
            if (string.IsNullOrEmpty(txtClientLastName.Text))
            {
                messageBoxError("Вы не ввели фамилию");
                return;
            }
            if (string.IsNullOrEmpty(txtClientAddress.Text))
            {
                messageBoxError("Вы не ввели адрес");
                return;
            }
            if (string.IsNullOrEmpty(txtClientPhone.Text))
            {
                messageBoxError("Вы не ввели телефон");
                return;
            }
            Regex phoneRegex = new Regex(@"^[+]{0,1}[7-8]{1}[(]9{1}\d{2}[)]\d{3}[-]\d{2}[-]\d{2}$");
            MatchCollection matches = phoneRegex.Matches(txtClientPhone.Text);
            if (matches.Count == 0)
            {
                messageBoxError("Не верный формат телефона");
                return;
            }
            var client = new Client();
            client.adress = txtClientAddress.Text;
            client.surname = txtClientLastName.Text;
            client.phone = txtClientPhone.Text;
            client.patronymic = txtClientSecondName.Text;
            client.name = txtClientName.Text;
            dataBase.AddClient(client);
            clientBindingSource.Add(client);
            txtClientAddress.Clear();
            txtClientLastName.Clear();
            txtClientPhone.Clear();
            txtClientSecondName.Clear();
            txtClientName.Clear();
            messageBoxSuccessAdd();
        }

        private void txtClientPhone_TextChanged(object sender, EventArgs e)
        {
            //Добавление первой скобки
            if (txtClientPhone.Text.Length == 1 && (txtClientPhone.Text[0] != '+'))
            {
                txtClientPhone.Text += "(9";
                txtClientPhone.SelectionStart = 3;
            }
            else if (txtClientPhone.Text.Length == 2 && txtClientPhone.Text[1] == '7')
            {
                txtClientPhone.Text += "(9";
                txtClientPhone.SelectionStart = 4;
            }
            //Добавление второй скобки
            if (txtClientPhone.Text.Length == 5 && (txtClientPhone.Text[0] != '+'))
            {
                txtClientPhone.Text += ")";
                txtClientPhone.SelectionStart = 6;
            }
            else if (txtClientPhone.Text.Length == 6 && txtClientPhone.Text[0] == '+')
            {
                txtClientPhone.Text += ")";
                txtClientPhone.SelectionStart = 7;
            }
            //Добавление -
            if (txtClientPhone.Text.Length == 9 && (txtClientPhone.Text[0] != '+'))
            {
                txtClientPhone.Text += "-";
                txtClientPhone.SelectionStart = 10;
            }
            else if (txtClientPhone.Text.Length == 10 && txtClientPhone.Text[0] == '+')
            {
                txtClientPhone.Text += "-";
                txtClientPhone.SelectionStart = 11;
            }
            //Добавление -
            if (txtClientPhone.Text.Length == 12 && (txtClientPhone.Text[0] != '+'))
            {
                txtClientPhone.Text += "-";
                txtClientPhone.SelectionStart = 13;
            }
            else if (txtClientPhone.Text.Length == 13 && txtClientPhone.Text[0] == '+')
            {
                txtClientPhone.Text += "-";
                txtClientPhone.SelectionStart = 14;
            }
        }

        Client selectedClient;
        private void dgvClient_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            selectedClient = new Client();
            selectedClient.id = dgvClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            selectedClient.adress = dgvClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            selectedClient.phone = dgvClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            selectedClient.name = dgvClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            selectedClient.patronymic = dgvClient.Rows[e.RowIndex].Cells[4].Value.ToString();
            selectedClient.surname = dgvClient.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dgvClient_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var client = new Client();
            client.id = dgvClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            client.adress = dgvClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            client.phone = dgvClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            client.name = dgvClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            client.patronymic = dgvClient.Rows[e.RowIndex].Cells[4].Value.ToString();
            client.surname = dgvClient.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (selectedClient.Equals(client))
            {
                return;
            }
            if (selectedClient.phone != client.phone)
            {
                Regex phoneRegex = new Regex(@"^[+]{0,1}[7-8]{1}[(]9{1}\d{2}[)]\d{3}[-]\d{2}[-]\d{2}$");
                MatchCollection matches = phoneRegex.Matches(client.phone);
                if (matches.Count == 0)
                {
                    messageBoxError("Не верный формат телефона");
                    dgvClient[2, e.RowIndex].Value = selectedClient.phone;
                    return;
                }
            }
            var dialogResult = messageBoxClickResult("Изменить эту запись?");
            if (dialogResult == DialogResult.No)
            {
                dgvClient[1, e.RowIndex].Value = selectedClient.adress;
                dgvClient[2, e.RowIndex].Value = selectedClient.phone;
                dgvClient[3, e.RowIndex].Value = selectedClient.name;
                dgvClient[4, e.RowIndex].Value = selectedClient.patronymic;
                dgvClient[5, e.RowIndex].Value = selectedClient.surname;
                return;
            }
            if (dialogResult == DialogResult.Yes)
            {
                dataBase.UpdateClient(dgvClient.CurrentRow.DataBoundItem as Client);
            }
        }
        #endregion
        #region Работа с абониментом
        private void dgvClubCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvClubCard.Columns[e.ColumnIndex].Index == dgvClubCard.Columns.Count - 1)
            {
                if (messageBoxClickResult("Удалить эту запись?") == DialogResult.Yes)
                {
                    var id = dgvClubCard.Rows[e.RowIndex].Cells[0].Value.ToString();
                    clubCardBindingSource.RemoveAt(e.RowIndex);
                    dataBase.DeleteClubCard(id);
                }
            }
        }

        private void cbIsClubCardEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsClubCardEdit.Checked)
            {
                dgvClubCard.Columns[6].Visible = true;
            }
            else
            {
                dgvClubCard.Columns[6].Visible = false;
            }
        }

        private void btnClubCardAdd_Click(object sender, EventArgs e)
        {
            var dateStart = dtpClubCardStart.Value;
            var dateEnd = dtpClubCardEnd.Value;
            if (dateStart.Day == dateEnd.Day 
                && dateStart.Month == dateEnd.Month
                && dateStart.Year == dateEnd.Year)
            {
                messageBoxError("Не верные даты");
                return;
            }
            var clubCard = new ClubCard();
            clubCard.price = (int)nudClubCardPrice.Value;
            clubCard.client = cmbClubCardClient.SelectedItem as Client;
            clubCard.startCard = dateStart;
            clubCard.endCard = dateEnd;
            clubCard.service = cmbClubCardService.SelectedItem as Service;
            dataBase.AddClubCard(clubCard);
            clubCardBindingSource.Add(clubCard);
            messageBoxSuccessAdd();
        }
        #endregion
        #region Работа с сотрудником
        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvStaff.Columns[e.ColumnIndex].Index == dgvStaff.Columns.Count - 1)
            {
                if (messageBoxClickResult("Удалить эту запись?") == DialogResult.Yes)
                {
                    var id = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
                    staffBindingSource.RemoveAt(e.RowIndex);
                    dataBase.DeleteStaff(id);
                }
            }
        }

        private void cbIsStaffEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsStaffEdit.Checked)
            {
                dgvStaff.Columns[1].ReadOnly = false;
                dgvStaff.Columns[2].ReadOnly = false;
                dgvStaff.Columns[3].ReadOnly = false;
                dgvStaff.Columns[4].ReadOnly = false;
                dgvStaff.Columns[5].ReadOnly = false;
                dgvStaff.Columns[6].Visible = true;
            }
            else
            {
                dgvStaff.Columns[1].ReadOnly = true;
                dgvStaff.Columns[2].ReadOnly = true;
                dgvStaff.Columns[3].ReadOnly = true;
                dgvStaff.Columns[4].ReadOnly = true;
                dgvStaff.Columns[5].ReadOnly = true;
                dgvStaff.Columns[6].Visible = false;
            }
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                messageBoxError("Вы не ввели имя");
                return;
            }
            if (string.IsNullOrEmpty(txtStaffSecondName.Text))
            {
                messageBoxError("Вы не ввели отчество");
                return;
            }
            if (string.IsNullOrEmpty(txtStaffLastName.Text))
            {
                messageBoxError("Вы не ввели фамилию");
                return;
            }
            if (string.IsNullOrEmpty(txtStaffAddress.Text))
            {
                messageBoxError("Вы не ввели адрес");
                return;
            }
            if (string.IsNullOrEmpty(txtStaffPhone.Text))
            {
                messageBoxError("Вы не ввели телефон");
                return;
            }
            Regex phoneRegex = new Regex(@"^[+]{0,1}[7-8]{1}[(]9{1}\d{2}[)]\d{3}[-]\d{2}[-]\d{2}$");
            MatchCollection matches = phoneRegex.Matches(txtStaffPhone.Text);
            if (matches.Count == 0)
            {
                messageBoxError("Не верный формат телефона");
                return;
            }
            var staff = new Staff();
            staff.adress = txtStaffAddress.Text;
            staff.surname = txtStaffLastName.Text;
            staff.phone = txtStaffPhone.Text;
            staff.patronymic = txtStaffSecondName.Text;
            staff.name = txtStaffName.Text;
            dataBase.AddStaff(staff);
            staffBindingSource.Add(staff);
            txtStaffAddress.Clear();
            txtStaffPhone.Clear();
            txtStaffSecondName.Clear();
            txtStaffName.Clear();
            txtStaffLastName.Clear();
            messageBoxSuccessAdd();
        }

        private void txtStaffPhone_TextChanged(object sender, EventArgs e)
        {
            //Добавление первой скобки
            if (txtStaffPhone.Text.Length == 1 && (txtStaffPhone.Text[0] != '+'))
            {
                txtStaffPhone.Text += "(9";
                txtStaffPhone.SelectionStart = 3;
            }
            else if (txtStaffPhone.Text.Length == 2 && txtStaffPhone.Text[1] == '7')
            {
                txtStaffPhone.Text += "(9";
                txtStaffPhone.SelectionStart = 4;
            }
            //Добавление второй скобки
            if (txtStaffPhone.Text.Length == 5 && (txtStaffPhone.Text[0] != '+'))
            {
                txtStaffPhone.Text += ")";
                txtStaffPhone.SelectionStart = 6;
            }
            else if (txtStaffPhone.Text.Length == 6 && txtStaffPhone.Text[0] == '+')
            {
                txtStaffPhone.Text += ")";
                txtStaffPhone.SelectionStart = 7;
            }
            //Добавление -
            if (txtStaffPhone.Text.Length == 9 && (txtStaffPhone.Text[0] != '+'))
            {
                txtStaffPhone.Text += "-";
                txtStaffPhone.SelectionStart = 10;
            }
            else if (txtStaffPhone.Text.Length == 10 && txtStaffPhone.Text[0] == '+')
            {
                txtStaffPhone.Text += "-";
                txtStaffPhone.SelectionStart = 11;
            }
            //Добавление -
            if (txtStaffPhone.Text.Length == 12 && (txtStaffPhone.Text[0] != '+'))
            {
                txtStaffPhone.Text += "-";
                txtStaffPhone.SelectionStart = 13;
            }
            else if (txtStaffPhone.Text.Length == 13 && txtStaffPhone.Text[0] == '+')
            {
                txtStaffPhone.Text += "-";
                txtStaffPhone.SelectionStart = 14;
            }
        }

        Staff selectedStaff;
        private void dgvStaff_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            selectedStaff = new Staff();
            selectedStaff.id = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
            selectedStaff.adress = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
            selectedStaff.phone = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
            selectedStaff.name = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
            selectedStaff.patronymic = dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
            selectedStaff.surname = dgvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dgvStaff_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var staff = new Staff();
            staff.id = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
            staff.adress = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
            staff.phone = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
            staff.name = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
            staff.patronymic = dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
            staff.surname = dgvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (selectedStaff.Equals(staff))
            {
                return;
            }
            if (selectedStaff.phone != staff.phone)
            {
                Regex phoneRegex = new Regex(@"^[+]{0,1}[7-8]{1}[(]9{1}\d{2}[)]\d{3}[-]\d{2}[-]\d{2}$");
                MatchCollection matches = phoneRegex.Matches(staff.phone);
                if (matches.Count == 0)
                {
                    messageBoxError("Не верный формат телефона");
                    dgvStaff[2, e.RowIndex].Value = selectedStaff.phone;
                    return;
                }
            }
            var dialogResult = messageBoxClickResult("Изменить эту запись?");
            if (dialogResult == DialogResult.No)
            {
                dgvStaff[1, e.RowIndex].Value = selectedStaff.adress;
                dgvStaff[2, e.RowIndex].Value = selectedStaff.phone;
                dgvStaff[3, e.RowIndex].Value = selectedStaff.name;
                dgvStaff[4, e.RowIndex].Value = selectedStaff.patronymic;
                dgvStaff[5, e.RowIndex].Value = selectedStaff.surname;
                return;
            }
            if (dialogResult == DialogResult.Yes)
            {
                dataBase.UpdateStaff(dgvStaff.CurrentRow.DataBoundItem as Staff);
            }
        }
        #endregion

        #region Работа с расписанием
        private void btnTaskTabkeAdd_Click(object sender, EventArgs e)
        {
            var tt = new TaskTable();
            tt.staff = cmbTaskTableStaff.SelectedItem as Staff;
            tt.client = cmbTaskTableClient.SelectedItem as Client;
            tt.dateLesson = dtpTaskTableDate.Value;
            tt.duration = int.Parse(cmbTaskTableDuraction.Text);
            tt.hall = cmbTaskTableHall.SelectedItem as Hall;
            dataBase.AddTaskTable(tt);
            taskTableBindingSource.Add(tt);
            messageBoxSuccessAdd();
            dgvSearch.DataSource = dataBase.Search();
        }

        private void cbIsTaskTableEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsTaskTableEdit.Checked)
            {
                dgvTaskTable.Columns[6].Visible = true;
            }
            else
            {
                dgvTaskTable.Columns[6].Visible = false;
            }
        }

        private void dgvTaskTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvTaskTable.Columns[e.ColumnIndex].Index == dgvTaskTable.Columns.Count - 1)
            {
                if (messageBoxClickResult("Удалить эту запись?") == DialogResult.Yes)
                {
                    var id = dgvTaskTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                    taskTableBindingSource.RemoveAt(e.RowIndex);
                    dataBase.DeleteTaskTable(id);
                }
            }
        }
        #endregion

        private void nudClubCardSearch_ValueChanged(object sender, EventArgs e)
        {
            var ans = dataBase.ClubCardSearch((int)nudClubCardSearch.Value);
            clubCardBindingSource.Clear();
            foreach(var cc in ans)
            {
                clubCardBindingSource.Add(cc);
            }
            Console.WriteLine();
        }

        private void btnClubCardReset_Click(object sender, EventArgs e)
        {
            nudClubCardSearch.Value = 0;
            clubCardBindingSource.Clear();
            foreach (var cc in dataBase.GetClubCard())
            {
                clubCardBindingSource.Add(cc);
            }

        }

        private void nudServiceSerach_ValueChanged(object sender, EventArgs e)
        {
            var ans = dataBase.ServiceSearch((int)nudServiceSerach.Value, txtServiceSearch.Text);
            serviceBindingSource.Clear();
            foreach(var a in ans)
            {
                serviceBindingSource.Add(a);
            }
        }

        private void txtServiceSearch_TextChanged(object sender, EventArgs e)
        {
            var ans = dataBase.ServiceSearch((int)nudServiceSerach.Value, txtServiceSearch.Text);
            serviceBindingSource.Clear();
            foreach (var a in ans)
            {
                serviceBindingSource.Add(a);
            }
        }

        private void ResetServiceBtn_Click(object sender, EventArgs e)
        {
            nudServiceSerach.Value = 100;
            txtServiceSearch.Text = "";
            serviceBindingSource.Clear();
            foreach (var serv in dataBase.GetService())
            {
                serviceBindingSource.Add(serv);
            }
        }
    }
}
