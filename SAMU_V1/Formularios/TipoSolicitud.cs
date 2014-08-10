using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMU_V1.Formularios
{
    public partial class TipoSolicitud : Form
    {
        public TipoSolicitud()
        {
            InitializeComponent();
        }

        private void s_tipo_solicitudBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.s_tipo_solicitudBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sAMUDataSet);

        }

        private void TipoSolicitud_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sAMUDataSet.s_tipo_solicitud' Puede moverla o quitarla según sea necesario.
            this.s_tipo_solicitudTableAdapter.Fill(this.sAMUDataSet.s_tipo_solicitud);

        }
    }
}
