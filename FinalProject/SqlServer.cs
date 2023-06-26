using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.TextFormatting;

namespace FinalProject
{
    internal class SqlServer
    {
        static string Path = "Data Source = DESKTOP-7M23CVC\\ABOLFAZL;Initial Catalog = People;Integrated Security = true";
        public static void Insert(string id, string name, string family)
        {
            SqlConnection Connection = new SqlConnection(Path);
            string query = $"insert into Contacts (ID,name,family) values ({int.Parse(id)},'{name}', '{family}')";

            Connection.Open();
            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.ExecuteNonQuery();
        }
    }
}

