using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Entities;

namespace WWA_LAB4.Models
{
    public class Model
    {
        private DBManager bll = new DBManager();

        public List<ContactRecord> getRecords()
        {
            return bll.getRecords();
        }

        public void addRecord(ContactRecord c)
        {
             bll.addRecord(c);
        }

        public ContactRecord Details(int id)
        {
            return bll.Details(id);
        }

        public void deleteRecord(int id)
        {
            bll.deleteRecord(id);
        }

        public void updateRecord(ContactRecord c)
        {
            bll.updateRecord(c);
        }

    }
}