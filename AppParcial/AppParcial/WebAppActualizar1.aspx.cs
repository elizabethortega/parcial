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
    public partial class WebAppActualizar1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string buscar;
            buscar = txtCedula.Text;

            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc14\documents\visual studio 2012\Projects\AppParcial\AppParcial\App_Data\aspnet-AppParcial-20150424191526.mdf;Initial Catalog=aspnet-AppParcial-20150424191526;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);


            string consulta = "SELECT * FROM empleados where cedula='" + buscar + "'";

            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
            DataTable datatable = new DataTable();

            cn.Open();

            int recordsAffected = da.Fill(datatable);
            GridView1.DataSource = datatable;
            GridView1.DataBind();
            cn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre=txtnombre1.Text;
            string apellido = txtapellido1.Text;
            string email = txtemail1.Text;
            string domicilio = txtdomicilio1.Text;
            string ciudad = txtciudad1.Text;
            string telefono = txttelefono1.Text;


            // Conexion con Base De Datos
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc14\documents\visual studio 2012\Projects\AppParcial\AppParcial\App_Data\aspnet-AppParcial-20150424191526.mdf;Initial Catalog=aspnet-AppParcial-20150424191526;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();

            string sqlCommand = " update empleados set nombre='" + nombre + "',apellidos='" + apellido + "',email='" + email + "',domicilio='" + domicilio + "',ciudad='" + ciudad + "',telefono='" + telefono + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();

        }
    }
}