using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAMU_V1.Clases;
using SAMU_V1.Formularios;

namespace SAMU_V1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public bool UsuarioLogueado = false;
        private void Menu_Load(object sender, EventArgs e)
        {
           // Conexion.abrirConexion();
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (login.logueado == true)
            {
                this.Show();
                UsuarioLogueado = true;
            }
            else 
            {
                this.Close();
            }
        }


        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UsuarioLogueado == true)
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea salir del sistema?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDocumento tipoDoc = new frmTipoDocumento();
            tipoDoc.ShowDialog();
        }
    }
}
