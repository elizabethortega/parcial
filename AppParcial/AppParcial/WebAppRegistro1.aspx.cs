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
    public partial class WebAppRegistro1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Conexion con Base De Datos
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc14\documents\visual studio 2012\Projects\AppParcial\AppParcial\App_Data\aspnet-AppParcial-20150424191526.mdf;Initial Catalog=aspnet-AppParcial-20150424191526;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();

            string sqlCommand = "INSERT INTO empleados(cedula, nombre, apellidos, email, domicilio, ciudad, telefono) VALUES (104,'diana', 'sanchez', 'dianasanchez@gmail.com', 'av5centro','cucuta', '3166924973')";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();
        }
    }
}