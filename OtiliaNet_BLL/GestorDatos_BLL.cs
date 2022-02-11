using OtiliaNet.OtiliaNet_DAL;
using OtiliaNet.OtiliaNet_ENT;
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
        public GestorSQL_DAL managerSQL_DAL = new GestorSQL_DAL();

        public DataTable DataTable_FromQuery_WithMySQL(string queryIn)
        {
            try
            {
                return managerSQL_DAL.DataTable_FromQuery_WithMySQL(queryIn);
            }
            catch (Exception Ex) { throw Ex; }
        }
        public void TestConnectionWithSqlServer()
        {
            try
            {
                managerSQL_DAL.TestConnectionWithSqlServer();
            }
            catch (Exception Ex) { throw Ex; }
        }

        public DataTable DataTable_FromQuery_WithSQLServer(string query)
        {
            try
            {
                return managerSQL_DAL.DataTable_FromQuery_WithSQLServer(query);
            }catch(Exception Ex) { throw Ex; }
        }

        internal bool AddNewProduct(Product_ENT product)
        {
            return managerSQL_DAL.AddNewProduct(product);  
        }
    }
}
