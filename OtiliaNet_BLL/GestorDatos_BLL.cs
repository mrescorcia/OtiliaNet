using OtiliaNet.OtiliaNet_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtiliaNet.OtiliaNet_BLL
{
    public class GestorDatos_BLL
    {
        public GestorSQL_DAL gestorMySql = new GestorSQL_DAL();

        public DataTable DataTable_FromQuery_WithMySQL(string queryIn)
        {
            try
            {
                return gestorMySql.DataTable_FromQuery_WithMySQL(queryIn);
            }
            catch (Exception Ex) { throw Ex; }
        }
        public void TestConnectionWithSqlServer()
        {
            try
            {
                gestorMySql.TestConnectionWithSqlServer();
            }
            catch (Exception Ex) { throw Ex; }
        }

        public DataTable DataTable_FromQuery_WithSQLServer(string query)
        {
            try
            {
                return gestorMySql.DataTable_FromQuery_WithSQLServer(query);
            }catch(Exception Ex) { throw Ex; }
        }
    }
}
