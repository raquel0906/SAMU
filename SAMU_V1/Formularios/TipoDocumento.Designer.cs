namespace SAMU_V1.Formularios
{
    partial class frmTipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoDocumento));
            this.lblcod_tipo_documento = new System.Windows.Forms.Label();
            this.lbltipo_doc_descripcion = new System.Windows.Forms.Label();
            this.txtcod_tipo_documento = new System.Windows.Forms.TextBox();
            this.stipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet1 = new SAMU_V1.SAMUDataSet1();
            this.txtdescripcion_tipo_doc = new System.Windows.Forms.TextBox();
            this.bdTipo_documento = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.tsbeditar = new System.Windows.Forms.ToolStripButton();
            this.tsbguardar = new System.Windows.Forms.ToolStripButton();
            this.tsbcancelar = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.s_tipo_documentoTableAdapter = new SAMU_V1.SAMUDataSet1TableAdapters.s_tipo_documentoTableAdapter();
            this.stipodocumentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTipo_documento)).BeginInit();
            this.bdTipo_documento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stipodocumentoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcod_tipo_documento
            // 
            this.lblcod_tipo_documento.AutoSize = true;
            this.lblcod_tipo_documento.Location = new System.Drawing.Point(169, 72);
            this.lblcod_tipo_documento.Name = "lblcod_tipo_documento";
            this.lblcod_tipo_documento.Size = new System.Drawing.Size(43, 13);
            this.lblcod_tipo_documento.TabIndex = 2;
            this.lblcod_tipo_documento.Text = "Código:";
            this.lblcod_tipo_documento.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbltipo_doc_descripcion
            // 
            this.lbltipo_doc_descripcion.AutoSize = true;
            this.lbltipo_doc_descripcion.Location = new System.Drawing.Point(169, 123);
            this.lbltipo_doc_descripcion.Name = "lbltipo_doc_descripcion";
            this.lbltipo_doc_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbltipo_doc_descripcion.TabIndex = 3;
            this.lbltipo_doc_descripcion.Text = "Descripcion:";
            // 
            // txtcod_tipo_documento
            // 
            this.txtcod_tipo_documento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stipodocumentoBindingSource, "cod_tipo_documento", true));
            this.txtcod_tipo_documento.Enabled = false;
            this.txtcod_tipo_documento.Location = new System.Drawing.Point(257, 69);
            this.txtcod_tipo_documento.Name = "txtcod_tipo_documento";
            this.txtcod_tipo_documento.Size = new System.Drawing.Size(136, 20);
            this.txtcod_tipo_documento.TabIndex = 4;
            // 
            // stipodocumentoBindingSource
            // 
            this.stipodocumentoBindingSource.DataMember = "s_tipo_documento";
            this.stipodocumentoBindingSource.DataSource = this.sAMUDataSet1;
            // 
            // sAMUDataSet1
            // 
            this.sAMUDataSet1.DataSetName = "SAMUDataSet1";
            this.sAMUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdescripcion_tipo_doc
            // 
            this.txtdescripcion_tipo_doc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stipodocumentoBindingSource, "descripcion_tipo_documento", true));
            this.txtdescripcion_tipo_doc.Enabled = false;
            this.txtdescripcion_tipo_doc.Location = new System.Drawing.Point(257, 120);
            this.txtdescripcion_tipo_doc.Name = "txtdescripcion_tipo_doc";
            this.txtdescripcion_tipo_doc.Size = new System.Drawing.Size(136, 20);
            this.txtdescripcion_tipo_doc.TabIndex = 5;
            // 
            // bdTipo_documento
            // 
            this.bdTipo_documento.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdTipo_documento.BindingSource = this.stipodocumentoBindingSource;
            this.bdTipo_documento.CountItem = this.bindingNavigatorCountItem;
            this.bdTipo_documento.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdTipo_documento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tsbeditar,
            this.tsbguardar,
            this.tsbcancelar,
            this.bindingNavigatorDeleteItem});
            this.bdTipo_documento.Location = new System.Drawing.Point(0, 0);
            this.bdTipo_documento.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdTipo_documento.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdTipo_documento.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdTipo_documento.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdTipo_documento.Name = "bdTipo_documento";
            this.bdTipo_documento.PositionItem = this.bindingNavigatorPositionItem;
            this.bdTipo_documento.Size = new System.Drawing.Size(635, 25);
            this.bdTipo_documento.TabIndex = 7;
            this.bdTipo_documento.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.MergeIndex = 0;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // tsbeditar
            // 
            this.tsbeditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbeditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbeditar.Image")));
            this.tsbeditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbeditar.Name = "tsbeditar";
            this.tsbeditar.Size = new System.Drawing.Size(23, 22);
            this.tsbeditar.Text = "toolStripButton2";
            // 
            // tsbguardar
            // 
            this.tsbguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbguardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbguardar.Image")));
            this.tsbguardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbguardar.Name = "tsbguardar";
            this.tsbguardar.Size = new System.Drawing.Size(23, 22);
            this.tsbguardar.Text = "toolStripButton1";
            this.tsbguardar.Click += new System.EventHandler(this.tsbguardar_Click);
            // 
            // tsbcancelar
            // 
            this.tsbcancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbcancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbcancelar.Image")));
            this.tsbcancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbcancelar.Name = "tsbcancelar";
            this.tsbcancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbcancelar.Text = "toolStripButton1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.sAMUDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // s_tipo_documentoTableAdapter
            // 
            this.s_tipo_documentoTableAdapter.ClearBeforeFill = true;
            // 
            // stipodocumentoBindingSource1
            // 
            this.stipodocumentoBindingSource1.DataMember = "s_tipo_documento";
            this.stipodocumentoBindingSource1.DataSource = this.sAMUDataSet1;
            // 
            // frmTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 301);
            this.Controls.Add(this.bdTipo_documento);
            this.Controls.Add(this.txtdescripcion_tipo_doc);
            this.Controls.Add(this.txtcod_tipo_documento);
            this.Controls.Add(this.lbltipo_doc_descripcion);
            this.Controls.Add(this.lblcod_tipo_documento);
            this.Name = "frmTipoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Documento";
            this.Load += new System.EventHandler(this.frmTipoDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTipo_documento)).EndInit();
            this.bdTipo_documento.ResumeLayout(false);
            this.bdTipo_documento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stipodocumentoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcod_tipo_documento;
        private System.Windows.Forms.Label lbltipo_doc_descripcion;
        private System.Windows.Forms.TextBox txtcod_tipo_documento;
        private System.Windows.Forms.TextBox txtdescripcion_tipo_doc;
        private System.Windows.Forms.BindingNavigator bdTipo_documento;
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
        private System.Windows.Forms.ToolStripButton tsbguardar;
        private System.Windows.Forms.ToolStripButton tsbcancelar;
        private System.Windows.Forms.ToolStripButton tsbeditar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SAMUDataSet1 sAMUDataSet1;
        private System.Windows.Forms.BindingSource stipodocumentoBindingSource;
        private SAMUDataSet1TableAdapters.s_tipo_documentoTableAdapter s_tipo_documentoTableAdapter;
        private System.Windows.Forms.BindingSource stipodocumentoBindingSource1;
     //   private SAMUDataSet3 samuDataSet31;
    }
}