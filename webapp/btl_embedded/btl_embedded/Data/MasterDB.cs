using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace btl_embedded.Data
{
    public class MasterDB
    {
        static BsonData.DataBase _db;
        public static BsonData.DataBase MainDB => _db;
        public static void Register(string path)
        {
            _db = new BsonData.DataBase(path, "AppData");
        }

    }
}
