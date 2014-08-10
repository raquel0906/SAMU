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
using System.Data.OleDb;
using SAMU_V1.Clases;

namespace SAMU_V1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
       
        public bool logueado = false;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //logueado = true;
            string resultado = Conexion.IniciarSesion(txtUsuario.Text, txtContrasenha.Text);
            if (resultado != " ")
            {
                logueado = true;
                MessageBox.Show(resultado, "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado, intente nuevamente", "Error", MessageBoxButtons.OK);
                txtUsuario.Text = "";
                txtContrasenha.Text = "";
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sAMUDataSet.s_tipo_documento' Puede moverla o quitarla según sea necesario.
            //this.s_tipo_documentoTableAdapter.Fill(this.sAMUDataSet.s_tipo_documento);
            //// TODO: esta línea de código carga datos en la tabla 'sAMUDataSet.usuarios' Puede moverla o quitarla según sea necesario.
           // this.usuariosTableAdapter.Fill(this.sAMUDataSet.usuarios);

        }

        private void btnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //logueado = true;
            string resultado = Conexion.IniciarSesion(txtUsuario.Text, txtContrasenha.Text);
            if (resultado != " ")
            {
                logueado = true;
                MessageBox.Show(resultado, "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado, intente nuevamente", "Error", MessageBoxButtons.OK);
                txtUsuario.Text = "";
                txtContrasenha.Text = "";
                txtUsuario.Focus();
            }
        }
  

    }
}
