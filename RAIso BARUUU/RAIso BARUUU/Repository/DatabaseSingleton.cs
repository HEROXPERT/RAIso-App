using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAIso_BARUUU.Repository 
{
    public class DatabaseSingleton
    {
        public static Database1Entities2 db = null;

        public static Database1Entities2 getInstance()
        {
            if (db == null)
            {
                db = new Database1Entities2();
            }
            return db;
        }
    }
}