using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SAMU_V1.Formularios
{
    public partial class frmRol : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public frmRol()
        {
            InitializeComponent();
        }

        private void u_rolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            cod_rolTextBox.Enabled = false;
            descripcionTextBox.Enabled = false;
            this.Validate();
            this.u_rolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sAMUDataSet);

        }

        private void Rol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sAMUDataSet.u_rol' Puede moverla o quitarla según sea necesario.
            con.Open();
            this.u_rolTableAdapter.Fill(this.sAMUDataSet.u_rol);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            cod_rolTextBox.Text = " ";
            descripcionTextBox.Text = " ";
            descripcionTextBox.Enabled = true;

                //string string_sql;
            //int rolmax;
            //SqlCommand cmd = new SqlCommand();
            //string_sql = "SELECT max(cod_rol)+1 FROM dbo.u_rol;";
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = string_sql;
            //rolmax= (Int32) cmd.ExecuteScalar();
            //cod_rolTextBox.Text = rolmax.ToString();
           
        }
    }
}
