using System;
using System.Data.SQLite;

namespace AntonysApps.HouseShare
{
    class connection
    {
        private static string connString = @"Data Source=datastore.dat;";
        public static SQLiteConnection conn = new SQLiteConnection(connString);
    }


}
