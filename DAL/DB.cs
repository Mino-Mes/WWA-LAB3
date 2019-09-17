using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DB
    {
        public static int LastId = 0;

        public static List<ContactRecord> contactRecord = new List<ContactRecord>();
    }
}
