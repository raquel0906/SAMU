namespace SAMU_V1.Formularios
{
    partial class TipoSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoSolicitud));
            System.Windows.Forms.Label cod_tipo_solicitudLabel;
            System.Windows.Forms.Label descripcion_tipo_solicitudLabel;
            this.sAMUDataSet = new SAMU_V1.SAMUDataSet();
            this.s_tipo_solicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_tipo_solicitudTableAdapter = new SAMU_V1.SAMUDataSetTableAdapters.s_tipo_solicitudTableAdapter();
            this.tableAdapterManager = new SAMU_V1.SAMUDataSetTableAdapters.TableAdapterManager();
            this.s_tipo_solicitudBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.s_tipo_solicitudBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_tipo_solicitudTextBox = new System.Windows.Forms.TextBox();
            this.descripcion_tipo_solicitudTextBox = new System.Windows.Forms.TextBox();
            cod_tipo_solicitudLabel = new System.Windows.Forms.Label();
            descripcion_tipo_solicitudLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_tipo_solicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_tipo_solicitudBindingNavigator)).BeginInit();
            this.s_tipo_solicitudBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sAMUDataSet
            // 
            this.sAMUDataSet.DataSetName = "SAMUDataSet";
            this.sAMUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s_tipo_solicitudBindingSource
            // 
            this.s_tipo_solicitudBindingSource.DataMember = "s_tipo_solicitud";
            this.s_tipo_solicitudBindingSource.DataSource = this.sAMUDataSet;
            // 
            // s_tipo_solicitudTableAdapter
            // 
            this.s_tipo_solicitudTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_categoria_tarifaTableAdapter = null;
            this.tableAdapterManager.c_categoriaTableAdapter = null;
            this.tableAdapterManager.c_conexionTableAdapter = null;
            this.tableAdapterManager.c_contratoTableAdapter = null;
            this.tableAdapterManager.c_estado_civilTableAdapter = null;
            this.tableAdapterManager.c_estado_conexionTableAdapter = null;
            this.tableAdapterManager.c_estado_lecturaTableAdapter = null;
            this.tableAdapterManager.c_estado_medidorTableAdapter = null;
            this.tableAdapterManager.c_medidor_lecturaTableAdapter = null;
            this.tableAdapterManager.c_medidorTableAdapter = null;
            this.tableAdapterManager.c_modifica_lecturaTableAdapter = null;
            this.tableAdapterManager.c_situacion_conexionTableAdapter = null;
            this.tableAdapterManager.c_socioTableAdapter = null;
            this.tableAdapterManager.c_zonaTableAdapter = null;
            this.tableAdapterManager.f_cobranzaTableAdapter = null;
            this.tableAdapterManager.f_consumo_x_socioTableAdapter = null;
            this.tableAdapterManager.f_cuenta_especial_cabeceraTableAdapter = null;
            this.tableAdapterManager.f_cuenta_especial_cuotaTableAdapter = null;
            this.tableAdapterManager.f_estado_cobranzaTableAdapter = null;
            this.tableAdapterManager.f_estado_cuenta_especialTableAdapter = null;
            this.tableAdapterManager.f_estado_facturaTableAdapter = null;
            this.tableAdapterManager.f_estado_nota_creditoTableAdapter = null;
            this.tableAdapterManager.f_fact_numeracionTableAdapter = null;
            this.tableAdapterManager.f_factura_detalleTableAdapter = null;
            this.tableAdapterManager.f_facturaTableAdapter = null;
            this.tableAdapterManager.f_nota_creditoTableAdapter = null;
            this.tableAdapterManager.f_tarifa_especialTableAdapter = null;
            this.tableAdapterManager.f_tipo_facturaTableAdapter = null;
            this.tableAdapterManager.o_orden_servicio_detalleTableAdapter = null;
            this.tableAdapterManager.o_orden_servicioTableAdapter = null;
            this.tableAdapterManager.o_tipo_orden_servicioTableAdapter = null;
            this.tableAdapterManager.s_actaTableAdapter = null;
            this.tableAdapterManager.s_mandatoTableAdapter = null;
            this.tableAdapterManager.s_motivo_desconexionTableAdapter = null;
            this.tableAdapterManager.s_solicitud_cambio_nombreTableAdapter = null;
            this.tableAdapterManager.s_solicitud_conexionTableAdapter = null;
            this.tableAdapterManager.s_solicitud_desconexionTableAdapter = null;
            this.tableAdapterManager.s_tipo_documentoTableAdapter = null;
            this.tableAdapterManager.s_tipo_estadoTableAdapter = null;
            this.tableAdapterManager.s_tipo_inmuebleTableAdapter = null;
            this.tableAdapterManager.s_tipo_regimenTableAdapter = null;
            this.tableAdapterManager.s_tipo_solicitudTableAdapter = this.s_tipo_solicitudTableAdapter;
            this.tableAdapterManager.UpdateOrder = SAMU_V1.SAMUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // s_tipo_solicitudBindingNavigator
            // 
            this.s_tipo_solicitudBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.s_tipo_solicitudBindingNavigator.BindingSource = this.s_tipo_solicitudBindingSource;
            this.s_tipo_solicitudBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.s_tipo_solicitudBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.s_tipo_solicitudBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.s_tipo_solicitudBindingNavigatorSaveItem});
            this.s_tipo_solicitudBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.s_tipo_solicitudBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.s_tipo_solicitudBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.s_tipo_solicitudBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.s_tipo_solicitudBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.s_tipo_solicitudBindingNavigator.Name = "s_tipo_solicitudBindingNavigator";
            this.s_tipo_solicitudBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.s_tipo_solicitudBindingNavigator.Size = new System.Drawing.Size(457, 25);
            this.s_tipo_solicitudBindingNavigator.TabIndex = 0;
            this.s_tipo_solicitudBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // s_tipo_solicitudBindingNavigatorSaveItem
            // 
            this.s_tipo_solicitudBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.s_tipo_solicitudBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("s_tipo_solicitudBindingNavigatorSaveItem.Image")));
            this.s_tipo_solicitudBindingNavigatorSaveItem.Name = "s_tipo_solicitudBindingNavigatorSaveItem";
            this.s_tipo_solicitudBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.s_tipo_solicitudBindingNavigatorSaveItem.Text = "Guardar datos";
            this.s_tipo_solicitudBindingNavigatorSaveItem.Click += new System.EventHandler(this.s_tipo_solicitudBindingNavigatorSaveItem_Click);
            // 
            // cod_tipo_solicitudLabel
            // 
            cod_tipo_solicitudLabel.AutoSize = true;
            cod_tipo_solicitudLabel.Location = new System.Drawing.Point(97, 80);
            cod_tipo_solicitudLabel.Name = "cod_tipo_solicitudLabel";
            cod_tipo_solicitudLabel.Size = new System.Drawing.Size(89, 13);
            cod_tipo_solicitudLabel.TabIndex = 1;
            cod_tipo_solicitudLabel.Text = "cod tipo solicitud:";
            // 
            // cod_tipo_solicitudTextBox
            // 
            this.cod_tipo_solicitudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.s_tipo_solicitudBindingSource, "cod_tipo_solicitud", true));
            this.cod_tipo_solicitudTextBox.Location = new System.Drawing.Point(228, 77);
            this.cod_tipo_solicitudTextBox.Name = "cod_tipo_solicitudTextBox";
            this.cod_tipo_solicitudTextBox.Size = new System.Drawing.Size(100, 20);
            this.cod_tipo_solicitudTextBox.TabIndex = 2;
            // 
            // descripcion_tipo_solicitudLabel
            // 
            descripcion_tipo_solicitudLabel.AutoSize = true;
            descripcion_tipo_solicitudLabel.Location = new System.Drawing.Point(97, 106);
            descripcion_tipo_solicitudLabel.Name = "descripcion_tipo_solicitudLabel";
            descripcion_tipo_solicitudLabel.Size = new System.Drawing.Size(125, 13);
            descripcion_tipo_solicitudLabel.TabIndex = 3;
            descripcion_tipo_solicitudLabel.Text = "descripcion tipo solicitud:";
            // 
            // descripcion_tipo_solicitudTextBox
            // 
            this.descripcion_tipo_solicitudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.s_tipo_solicitudBindingSource, "descripcion_tipo_solicitud", true));
            this.descripcion_tipo_solicitudTextBox.Location = new System.Drawing.Point(228, 103);
            this.descripcion_tipo_solicitudTextBox.Name = "descripcion_tipo_solicitudTextBox";
            this.descripcion_tipo_solicitudTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcion_tipo_solicitudTextBox.TabIndex = 4;
            // 
            // TipoSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 261);
            this.Controls.Add(cod_tipo_solicitudLabel);
            this.Controls.Add(this.cod_tipo_solicitudTextBox);
            this.Controls.Add(descripcion_tipo_solicitudLabel);
            this.Controls.Add(this.descripcion_tipo_solicitudTextBox);
            this.Controls.Add(this.s_tipo_solicitudBindingNavigator);
            this.Name = "TipoSolicitud";
            this.Text = "TipoSolicitud";
            this.Load += new System.EventHandler(this.TipoSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_tipo_solicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_tipo_solicitudBindingNavigator)).EndInit();
            this.s_tipo_solicitudBindingNavigator.ResumeLayout(false);
            this.s_tipo_solicitudBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SAMUDataSet sAMUDataSet;
        private System.Windows.Forms.BindingSource s_tipo_solicitudBindingSource;
        private SAMUDataSetTableAdapters.s_tipo_solicitudTableAdapter s_tipo_solicitudTableAdapter;
        private SAMUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator s_tipo_solicitudBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton s_tipo_solicitudBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_tipo_solicitudTextBox;
        private System.Windows.Forms.TextBox descripcion_tipo_solicitudTextBox;
    }
}