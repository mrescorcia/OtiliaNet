using OtiliaNet.OtiliaNet_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtiliaNet.OtiliaNet_GUI
{
    public partial class Productos : Form
    {
        GestorDatos_BLL gestorDatos_BLL = new GestorDatos_BLL();
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            string query = "Select * from tests_Products";
            //dtgProductos.DataSource = gestorDatos_BLL.DataTable_FromQuery_WithMySQL(query);
            
            dtgProducts.DataSource = gestorDatos_BLL.DataTable_FromQuery_WithSQLServer(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestorDatos_BLL.AddNewProduct();
        }
    }
}
