namespace pryTorres20260104
{
    partial class frmNegocio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNegocio));
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.mtbPrecio = new System.Windows.Forms.MaskedTextBox();
            this.mtbCantidad = new System.Windows.Forms.MaskedTextBox();
            this.tboNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.gbInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFondo
            // 
            this.pbFondo.Image = ((System.Drawing.Image)(resources.GetObject("pbFondo.Image")));
            this.pbFondo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFondo.InitialImage")));
            this.pbFondo.Location = new System.Drawing.Point(-4, 0);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(701, 387);
            this.pbFondo.TabIndex = 0;
            this.pbFondo.TabStop = false;
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.tboNombre);
            this.gbInventario.Controls.Add(this.mtbCantidad);
            this.gbInventario.Controls.Add(this.mtbPrecio);
            this.gbInventario.Controls.Add(this.tbCodigo);
            this.gbInventario.Controls.Add(this.btnAceptar);
            this.gbInventario.Controls.Add(this.cboCategoria);
            this.gbInventario.Controls.Add(this.lblCantidad);
            this.gbInventario.Controls.Add(this.lblCategoria);
            this.gbInventario.Controls.Add(this.lblPrecio);
            this.gbInventario.Controls.Add(this.lblNombre);
            this.gbInventario.Controls.Add(this.lblCodigo);
            this.gbInventario.Location = new System.Drawing.Point(183, 21);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(362, 340);
            this.gbInventario.TabIndex = 1;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "Inventario";
            this.gbInventario.Enter += new System.EventHandler(this.gbInventario_Enter);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(21, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(42, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(22, 113);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(39, 15);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(21, 194);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 15);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(21, 150);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(51, 15);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(111, 193);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(114, 286);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(110, 69);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(122, 20);
            this.tbCodigo.TabIndex = 8;
            // 
            // mtbPrecio
            // 
            this.mtbPrecio.Location = new System.Drawing.Point(111, 113);
            this.mtbPrecio.Name = "mtbPrecio";
            this.mtbPrecio.Size = new System.Drawing.Size(121, 20);
            this.mtbPrecio.TabIndex = 9;
            // 
            // mtbCantidad
            // 
            this.mtbCantidad.Location = new System.Drawing.Point(111, 150);
            this.mtbCantidad.Name = "mtbCantidad";
            this.mtbCantidad.Size = new System.Drawing.Size(121, 20);
            this.mtbCantidad.TabIndex = 10;
            // 
            // tboNombre
            // 
            this.tboNombre.Location = new System.Drawing.Point(111, 30);
            this.tboNombre.Name = "tboNombre";
            this.tboNombre.Size = new System.Drawing.Size(121, 20);
            this.tboNombre.TabIndex = 11;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 386);
            this.Controls.Add(this.gbInventario);
            this.Controls.Add(this.pbFondo);
            this.Name = "frmNegocio";
            this.Text = "Pequeño negocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tboNombre;
        private System.Windows.Forms.MaskedTextBox mtbCantidad;
        private System.Windows.Forms.MaskedTextBox mtbPrecio;
    }
}

