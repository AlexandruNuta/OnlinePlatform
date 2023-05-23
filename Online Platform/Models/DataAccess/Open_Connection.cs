using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Platform.Models.DataAccess
{
    public static class Open_Connection
    {
        public static SqlConnection Connection
        {
            get
            {
                return new SqlConnection(@"Data Source=DESKTOP-Q7OK8A5;Initial Catalog=Online Platform;Database=Online Platform;Trusted_Connection=Yes;Integrated Security=SSPI;");
            }
        }
    }
}
