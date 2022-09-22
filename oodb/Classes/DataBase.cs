using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
    }
}
