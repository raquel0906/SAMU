namespace SAMU_V1
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblContrasenha = new System.Windows.Forms.Label();
            this.txtContrasenha = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet = new SAMU_V1.SAMUDataSet();
            this.usuariosTableAdapter = new SAMU_V1.SAMUDataSetTableAdapters.usuariosTableAdapter();
            this.s_tipo_documentoTableAdapter = new SAMU_V1.SAMUDataSetTableAdapters.s_tipo_documentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContrasenha
            // 
            this.lblContrasenha.AutoSize = true;
            this.lblContrasenha.Location = new System.Drawing.Point(87, 98);
            this.lblContrasenha.Name = "lblContrasenha";
            this.lblContrasenha.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenha.TabIndex = 1;
            this.lblContrasenha.Text = "Contraseña:";
            // 
            // txtContrasenha
            // 
            this.txtContrasenha.Location = new System.Drawing.Point(186, 91);
            this.txtContrasenha.Name = "txtContrasenha";
            this.txtContrasenha.PasswordChar = '*';
            this.txtContrasenha.Size = new System.Drawing.Size(95, 20);
            this.txtContrasenha.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(86, 59);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(186, 52);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(94, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(89, 145);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(88, 27);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnIngresar_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(211, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BindingSource1
            // 
            this.BindingSource1.DataMember = "s_tipo_documento";
            this.BindingSource1.DataSource = this.sAMUDataSet;
            // 
            // sAMUDataSet
            // 
            this.sAMUDataSet.DataSetName = "SAMUDataSet";
            this.sAMUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // s_tipo_documentoTableAdapter
            // 
            this.s_tipo_documentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContrasenha);
            this.Controls.Add(this.lblContrasenha);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContrasenha;
        private System.Windows.Forms.TextBox txtContrasenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;
        //private SAMUDataSet samuDataSet1;
        private System.Windows.Forms.Button btnCancelar;
        private SAMUDataSet sAMUDataSet;
        private System.Windows.Forms.BindingSource BindingSource1;
        private SAMUDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private SAMUDataSetTableAdapters.s_tipo_documentoTableAdapter s_tipo_documentoTableAdapter;
    }
}

