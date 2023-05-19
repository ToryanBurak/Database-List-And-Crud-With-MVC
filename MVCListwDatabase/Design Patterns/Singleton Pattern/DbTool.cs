using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCListwDatabase.Design_Patterns.Singleton_Pattern
{
    using Models;
    public class DbTool
    {

        DbTool() { }
        static NorthwindEntities _dbInstance;
        public static NorthwindEntities DbInstance()
        {
            if (_dbInstance == null)
            {
                _dbInstance = new NorthwindEntities();
            }
            return _dbInstance;
        }
    }
}