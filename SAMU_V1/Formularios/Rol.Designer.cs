namespace SAMU_V1.Formularios
{
    partial class frmRol
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
            System.Windows.Forms.Label cod_rolLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRol));
            this.sAMUDataSet = new SAMU_V1.SAMUDataSet();
            this.u_rolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.u_rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.u_rolBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_rolTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.u_rolTableAdapter = new SAMU_V1.SAMUDataSetTableAdapters.u_rolTableAdapter();
            this.tableAdapterManager = new SAMU_V1.SAMUDataSetTableAdapters.TableAdapterManager();
            cod_rolLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u_rolBindingNavigator)).BeginInit();
            this.u_rolBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.u_rolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_rolLabel
            // 
            cod_rolLabel.AutoSize = true;
            cod_rolLabel.Location = new System.Drawing.Point(159, 80);
            cod_rolLabel.Name = "cod_rolLabel";
            cod_rolLabel.Size = new System.Drawing.Size(43, 13);
            cod_rolLabel.TabIndex = 1;
            cod_rolLabel.Text = "Código:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(159, 106);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripción:";
            // 
            // sAMUDataSet
            // 
            this.sAMUDataSet.DataSetName = "SAMUDataSet";
            this.sAMUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // u_rolBindingNavigator
            // 
            this.u_rolBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.u_rolBindingNavigator.BindingSource = this.u_rolBindingSource;
            this.u_rolBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.u_rolBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.u_rolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.u_rolBindingNavigatorSaveItem});
            this.u_rolBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.u_rolBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.u_rolBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.u_rolBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.u_rolBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.u_rolBindingNavigator.Name = "u_rolBindingNavigator";
            this.u_rolBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.u_rolBindingNavigator.Size = new System.Drawing.Size(504, 25);
            this.u_rolBindingNavigator.TabIndex = 0;
            this.u_rolBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // u_rolBindingSource
            // 
            this.u_rolBindingSource.DataMember = "u_rol";
            this.u_rolBindingSource.DataSource = this.sAMUDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // u_rolBindingNavigatorSaveItem
            // 
            this.u_rolBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.u_rolBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("u_rolBindingNavigatorSaveItem.Image")));
            this.u_rolBindingNavigatorSaveItem.Name = "u_rolBindingNavigatorSaveItem";
            this.u_rolBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.u_rolBindingNavigatorSaveItem.Text = "Guardar datos";
            this.u_rolBindingNavigatorSaveItem.Click += new System.EventHandler(this.u_rolBindingNavigatorSaveItem_Click);
            // 
            // cod_rolTextBox
            // 
            this.cod_rolTextBox.CausesValidation = false;
            this.cod_rolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.u_rolBindingSource, "cod_rol", true));
            this.cod_rolTextBox.Enabled = false;
            this.cod_rolTextBox.Location = new System.Drawing.Point(229, 77);
            this.cod_rolTextBox.Name = "cod_rolTextBox";
            this.cod_rolTextBox.Size = new System.Drawing.Size(100, 20);
            this.cod_rolTextBox.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.u_rolBindingSource, "descripcion", true));
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.u_rolBindingSource, "descripcion", true));
            this.descripcionTextBox.Enabled = false;
            this.descripcionTextBox.Location = new System.Drawing.Point(229, 103);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // u_rolTableAdapter
            // 
            this.u_rolTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.s_solicitud_cambio_nombreTableAdapter = null;
            this.tableAdapterManager.s_solicitud_conexionTableAdapter = null;
            this.tableAdapterManager.s_solicitud_desconexionTableAdapter = null;
            this.tableAdapterManager.s_tipo_documentoTableAdapter = null;
            this.tableAdapterManager.s_tipo_estadoTableAdapter = null;
            this.tableAdapterManager.s_tipo_inmuebleTableAdapter = null;
            this.tableAdapterManager.s_tipo_regimenTableAdapter = null;
            this.tableAdapterManager.s_tipo_solicitudTableAdapter = null;
            this.tableAdapterManager.u_lista_frmTableAdapter = null;
            this.tableAdapterManager.u_rol_frmTableAdapter = null;
            this.tableAdapterManager.u_rolTableAdapter = this.u_rolTableAdapter;
            this.tableAdapterManager.u_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SAMU_V1.SAMUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(cod_rolLabel);
            this.Controls.Add(this.cod_rolTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.u_rolBindingNavigator);
            this.Name = "frmRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u_rolBindingNavigator)).EndInit();
            this.u_rolBindingNavigator.ResumeLayout(false);
            this.u_rolBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.u_rolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SAMUDataSet sAMUDataSet;
        private System.Windows.Forms.BindingSource u_rolBindingSource;
        private SAMUDataSetTableAdapters.u_rolTableAdapter u_rolTableAdapter;
        private SAMUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator u_rolBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton u_rolBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_rolTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
    }
}