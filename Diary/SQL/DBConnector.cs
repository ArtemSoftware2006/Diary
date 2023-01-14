using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Diary
{
    static class DBConnector
    {
        static public string _connectionStr { get; private set; }
        static public MySqlConnection connect { get; private set; }


        static public void CreateConction(string connectStr)
        {
            connect = new MySqlConnection(connectStr);
            _connectionStr = connectStr;
        }
        static public void Open()
        {
            if (connect.State != System.Data.ConnectionState.Open)
            {
                connect.Open();
            }
        }
        static public void Close()
        {
            if (connect.State != System.Data.ConnectionState.Closed)
            {
                connect.Close();
            }
        }
    }
}
