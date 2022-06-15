using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt6Gearhart
{
    public class StudentDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Zack\Desktop\School\C#\Assignemnt6Gearhart\Assignemnt6Gearhart\SchoolData.mdf; Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
