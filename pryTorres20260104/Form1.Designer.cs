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
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.tboDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblRegistroDos = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mtbStock = new System.Windows.Forms.MaskedTextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.tboNombre = new System.Windows.Forms.TextBox();
            this.mtbCantidad = new System.Windows.Forms.MaskedTextBox();
            this.mtbPrecio = new System.Windows.Forms.MaskedTextBox();
            this.tboCodigo = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.gbInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.tboDescripcion);
            this.gbInventario.Controls.Add(this.lblDescripción);
            this.gbInventario.Controls.Add(this.lblRegistroDos);
            this.gbInventario.Controls.Add(this.lblRegistro);
            this.gbInventario.Controls.Add(this.btnCancelar);
            this.gbInventario.Controls.Add(this.mtbStock);
            this.gbInventario.Controls.Add(this.lblStock);
            this.gbInventario.Controls.Add(this.tboNombre);
            this.gbInventario.Controls.Add(this.mtbCantidad);
            this.gbInventario.Controls.Add(this.mtbPrecio);
            this.gbInventario.Controls.Add(this.tboCodigo);
            this.gbInventario.Controls.Add(this.btnConfirmar);
            this.gbInventario.Controls.Add(this.cboCategoria);
            this.gbInventario.Controls.Add(this.lblCantidad);
            this.gbInventario.Controls.Add(this.lblCategoria);
            this.gbInventario.Controls.Add(this.lblPrecio);
            this.gbInventario.Controls.Add(this.lblNombre);
            this.gbInventario.Controls.Add(this.lblCodigo);
            this.gbInventario.Location = new System.Drawing.Point(71, 32);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(440, 527);
            this.gbInventario.TabIndex = 1;
            this.gbInventario.TabStop = false;
            this.gbInventario.Enter += new System.EventHandler(this.gbInventario_Enter);
            // 
            // tboDescripcion
            // 
            this.tboDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboDescripcion.Location = new System.Drawing.Point(201, 290);
            this.tboDescripcion.Multiline = true;
            this.tboDescripcion.Name = "tboDescripcion";
            this.tboDescripcion.Size = new System.Drawing.Size(120, 74);
            this.tboDescripcion.TabIndex = 6;
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(96, 291);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(91, 20);
            this.lblDescripción.TabIndex = 9;
            this.lblDescripción.Text = "Descripción:";
            // 
            // lblRegistroDos
            // 
            this.lblRegistroDos.AutoSize = true;
            this.lblRegistroDos.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDos.Location = new System.Drawing.Point(84, 428);
            this.lblRegistroDos.Name = "lblRegistroDos";
            this.lblRegistroDos.Size = new System.Drawing.Size(0, 17);
            this.lblRegistroDos.TabIndex = 8;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(73, 386);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(0, 17);
            this.lblRegistro.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(100, 489);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // mtbStock
            // 
            this.mtbStock.Location = new System.Drawing.Point(200, 202);
            this.mtbStock.Mask = "9999";
            this.mtbStock.Name = "mtbStock";
            this.mtbStock.Size = new System.Drawing.Size(121, 20);
            this.mtbStock.TabIndex = 4;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(96, 202);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 20);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            // 
            // tboNombre
            // 
            this.tboNombre.Location = new System.Drawing.Point(200, 68);
            this.tboNombre.Name = "tboNombre";
            this.tboNombre.Size = new System.Drawing.Size(121, 20);
            this.tboNombre.TabIndex = 1;
            // 
            // mtbCantidad
            // 
            this.mtbCantidad.Location = new System.Drawing.Point(200, 157);
            this.mtbCantidad.Name = "mtbCantidad";
            this.mtbCantidad.Size = new System.Drawing.Size(121, 20);
            this.mtbCantidad.TabIndex = 3;
            this.mtbCantidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCantidad_MaskInputRejected);
            // 
            // mtbPrecio
            // 
            this.mtbPrecio.Location = new System.Drawing.Point(200, 114);
            this.mtbPrecio.Mask = "9999999";
            this.mtbPrecio.Name = "mtbPrecio";
            this.mtbPrecio.Size = new System.Drawing.Size(121, 20);
            this.mtbPrecio.TabIndex = 2;
            // 
            // tboCodigo
            // 
            this.tboCodigo.Location = new System.Drawing.Point(201, 25);
            this.tboCodigo.Name = "tboCodigo";
            this.tboCodigo.Size = new System.Drawing.Size(122, 20);
            this.tboCodigo.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(238, 489);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 23);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Monitor",
            "Mouse",
            "Teclado",
            "Mousepad",
            "Gabinete",
            "Ram"});
            this.cboCategoria.Location = new System.Drawing.Point(200, 242);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 5;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(96, 157);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(96, 243);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 20);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(96, 114);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(75, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:    $";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(96, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(96, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInventario.Location = new System.Drawing.Point(230, 9);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(131, 26);
            this.lblInventario.TabIndex = 2;
            this.lblInventario.Text = "Inventario 📝";
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(583, 581);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.gbInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNegocio";
            this.Text = "Pequeño negocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox tboCodigo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox tboNombre;
        private System.Windows.Forms.MaskedTextBox mtbCantidad;
        private System.Windows.Forms.MaskedTextBox mtbPrecio;
        private System.Windows.Forms.MaskedTextBox mtbStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblRegistroDos;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.TextBox tboDescripcion;
    }
}

