using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Hospital_Management_System.Database
{
    class DataAccess
    {
        
        public string ConnectionString { get; set; }
        public DataAccess()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\AIUB\HMS\db\hospital.mdf;Integrated Security=True;Connect Timeout=30";
        }
        public SqlCommand GetComand(string sqlQuery)
        {

        }
    }
}
