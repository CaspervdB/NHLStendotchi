using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MySql.Data.MySqlClient;

namespace Wardrobe.Resources.Database
{
    public class DbConnection : IDisposable
    {
        public MySqlConnection Connection { get; protected set; }
        public DbConnection()
        {
            Connection = new MySqlConnection("server = localhost; user = root; database = stendotchi; port = 3306; password =");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}