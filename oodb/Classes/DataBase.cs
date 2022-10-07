using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using Db4objects.Db4o.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Db4objects.Db4o.Internal.Metadata.HierarchyAnalyzer;

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
            found.Price = service.Price;
            found.Title = service.Title;
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
        #region
        public void AddTaskTable(TaskTable taskTable)
        {
            db.Store(taskTable);
        }
        public void DeleteTaskTable(string id)
        {
            var found = db.Query<TaskTable>(tt => tt.id == id)[0];
            db.Delete(found);
        }
        public List<TaskTable> GetTaskTable() => db.Query<TaskTable>().ToList();
        #endregion
        #region Поиски
        public List<ClubCard> ClubCardSearch(int dayCount)
        {
            var ans = (from ClubCard cc in db.Cast<ClubCard>()
                      where (cc.endCard - DateTime.Now).TotalDays <= dayCount
                      select cc).ToList<ClubCard>();


            return ans;
        }
        public List<Service> ServiceSearch(int price, string title)
        {
            IQuery query = db.Query();
            query.Constrain(typeof(Service));
            IQuery titleQuery = query.Descend("_title");
            query.Descend("_price").Constrain(price).Greater().Equal().And(
                titleQuery.Constrain(title).Like());
            IObjectSet result = query.Execute();
            var soda = new List<Service>();
            foreach (var r in result)
            {
                soda.Add(r as Service);
            }
            return soda;
        }
        public List<Search> Search() { 
            var asn = from TaskTable tt in db.Cast<TaskTable>()
                                 group tt by tt.staff into t
                                 select new { Name = t.Key,
                                     Count = t.Count() }; ;
            List<Search> lists = new List<Search>();
            foreach(var an in asn)
            {
                lists.Add(new Classes.Search(an.Count, an.Name));
            }
            return lists;
        }

        internal void ServiceSearch(decimal value)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
