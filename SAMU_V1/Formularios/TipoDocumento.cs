using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SAMU_V1.Clases;
using SAMU_V1.Formularios;

namespace SAMU_V1.Formularios
{
    public partial class frmTipoDocumento : Form
    {
        public frmTipoDocumento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTipoDocumento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sAMUDataSet1.s_tipo_documento' Puede moverla o quitarla según sea necesario.
            this.s_tipo_documentoTableAdapter.Fill(this.sAMUDataSet1.s_tipo_documento);
            // TODO: esta línea de código carga datos en la tabla 'sAMUDataSet.s_tipo_documento' Puede moverla o quitarla según sea necesario.
            //this.s_tipo_documentoTableAdapter.Fill(this.sAMUDataSet.s_tipo_documento);
            //this.s_tipo_documentoTableAdapter.Fill(this.sAMUDataSet2.s_tipo_documento);
          //  BindingSource bds1 = new BindingSource();
          //  SqlDataAdapter da1 = new SqlDataAdapter();
          //  //Conexion.abrirConexion();
          //  string datasource = @"Data Source=VIVI-PC2\SQLSERVER;Initial Catalog=SAMU;User ID=sa;Password=1q2w3e4r";
          //  da1 = new SqlDataAdapter("select * from s_tipo_documento", datasource);
          //  SqlCommandBuilder comando = new SqlCommandBuilder(da1);
          //  DataTable tabla = new DataTable();
          //  da1.Fill(tabla);
          //  bds1.DataSource = tabla;
          ////  dgvtipo_documento.DataSource = bds1;
          //  txtcod_tipo_documento.DataBindings.Add("Text", bds1, "cod_tipo_documento");
          //  txtdescripcion_tipo_doc.DataBindings.Add("Text", bds1, "descripcion_tipo_documento");

        }

        private void dgvtipo_documento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvtipo_documento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
     //       txtcod_tipo_documento = dgvtipo_documento.SelectedRows[0].Cells[0].Value.ToString();
              
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            
            txtdescripcion_tipo_doc.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtdescripcion_tipo_doc.Enabled = true;    
        }

        private void tsbguardar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            Conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "s_alta_tipo_documento";
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            //txtdescripcion_tipo_doc.Enabled = true;
            cmd.Parameters.Add(new SqlParameter("@descripcion", txtdescripcion_tipo_doc.Text));
            cmd.ExecuteNonQuery();
          //  Conexion.cerrarConexion();
  
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            txtdescripcion_tipo_doc.Enabled = false;
        }

    }
}
