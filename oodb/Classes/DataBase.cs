using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oodb.Classes
{
    internal class DataBase
    {
        const String filename = @"gym.yap";
        IObjectContainer db;
        public void dbConnect()
        {
            db = Db4oFactory.OpenFile(filename);
        }
        public void dbClose()
        {
            db.Close();
        }
        #region Работа с услугой
        public void AddService(Service service)
        {
            db.Store(service);
        }
        public List<Service> GetService()
        {
            return db.Query<Service>().ToList();
        }
        public void DeleteService(string id)
        {
            var service = db.Query<Service>(src => src.id == id)[0];
            db.Delete(service);
        }
        public void UpdateService(Service service)
        {
            var found = db.Query<Service>(src => src.id == service.id)[0];
            found.price = service.price;
            found.title = service.title;
            db.Store(found);
        }
        #endregion
        #region Работа с залами
        public void AddHall(Hall hall)
        {
            db.Store(hall);
        }
        public void DeleteHall(string id)
        {
            var found = db.Query<Hall>(hl => id == hl.id)[0];
            db.Delete(found);
        }
        public List<Hall> GetHall()
        {
            var list = db.Query<Hall>().ToList();
            return list;
        }
        public void UpdateHall(Hall hall)
        {
            var found = db.Query<Hall>(hl => hl.id == hall.id)[0];
            found.title = hall.title;
            db.Store(found);
        }
        #endregion
        #region работа с клиентами
        public void AddClient(Client client)
        {
            db.Store(client);
        }
        public List<Client> GetClient()
        {
            return db.Query<Client>().ToList();
        }

        public void DeleteClient(string id)
        {
            var found = db.Query<Client>(clt => clt.id == id)[0];
            db.Delete(found);
        }
        
        public void UpdateClient(Client client)
        {
            var found = db.Query<Client>(clt => clt.id == client.id)[0];
            found.phone = client.phone;
            found.adress = client.adress;
            found.surname = client.surname;
            found.name = client.name;
            found.patronymic = client.patronymic;
            db.Store(found);
        }
        #endregion
        #region Работа с абониментом
        public void AddClubCard(ClubCard clubCard)
        {
            db.Store(clubCard);
        }
        public void DeleteClubCard(string id)
        {
            var found = db.Query<ClubCard>(cc => cc.id == id)[0];
            db.Delete(found);
        }
        public List<ClubCard> GetClubCard()
        {
            return db.Query<ClubCard>().ToList();
        }
        #endregion
        #region
        public void AddStaff(Staff staff)
        {
            db.Store(staff);
        }
        public List<Staff> GetStaff() => db.Query<Staff>().ToList();
        public void DeleteStaff(string id)
        {
            var found = db.Query<Staff>(stf => stf.id == id)[0];
            db.Delete(found);
        }
        public void UpdateStaff(Staff staff)
        {
            var found = db.Query<Staff>(stf => stf.id == staff.id)[0];
            found.name = staff.name;
            found.phone = staff.phone;
            found.surname = staff.surname;
            found.adress = staff.adress;
            found.patronymic = staff.patronymic;
            db.Store(found);
        }
        #endregion
    }
}
