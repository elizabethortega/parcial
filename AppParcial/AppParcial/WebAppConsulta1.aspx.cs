using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AppParcial
{
    public partial class WebAppConsulta1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Conexion con Base De Datos
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc14\documents\visual studio 2012\Projects\AppParcial\AppParcial\App_Data\aspnet-AppParcial-20150424191526.mdf;Initial Catalog=aspnet-AppParcial-20150424191526;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);


            string sqlCommand = "SELECT * FROM EMPLEADOS";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            //SqlCommand comando = new SqlCommand(sqlCommand, cn);
            //comando.ExecuteNonQuery();
            DataTable datatable = new DataTable();

            cn.Open();
            int recordsAffected = da.Fill(datatable);
            GridView1.DataSource = datatable;
            GridView1.DataBind();
            cn.Close();
        }
    }
}