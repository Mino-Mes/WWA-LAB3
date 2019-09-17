using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using DAL;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DBManager
    {
        public void addRecord(ContactRecord c)
        {
            c.id = DB.LastId++;
            DB.contactRecord.Add(c);
        }

        public List<ContactRecord> getRecords()
        {
            return DB.contactRecord;
        }

        public ContactRecord Details(int id)
        {
            return DB.contactRecord.Where(x => x.id == id).Single();
        }

        public void deleteRecord(int id)
        {
            DB.contactRecord.Remove(Details(id));
        }

        public void updateRecord(ContactRecord c)
        {
            DB.contactRecord[DB.contactRecord.FindIndex(x => x.id == c.id)] = c;
        }
    }
}
