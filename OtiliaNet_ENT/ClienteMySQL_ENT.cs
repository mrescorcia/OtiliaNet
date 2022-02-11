using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtiliaNet.OtiliaNet_ENT
{
    public class ClienteMySQL_ENT
    {
        public string serverName { get; set; }
        public string serverPort { get; set; }
        public string userName { get; set; }
        public string serverPwd { get; set; }
        public string dataBase { get; set; }

        public string ConnectionString()
        {
            /*string connectionString =
                "Server=" + serverName + ";" +
                "Port=" + serverPort + ";" +
                "Database=" + dataBase + ";" +
                "Uid=" + userName + ";" +
                "Pwd=" + serverPwd + ";";*/

            string connectionString =
                "Database=" + dataBase + ";" +
                "Server=" + serverName + ";" +
                "Uid=" + userName + ";" +
                "Pwd=" + serverPwd + ";" +
                "Port=" + serverPort + ";"+
                "SSL Mode=None";

            return connectionString;
        }
    }
}
