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
            this.tboNombre = new System.Windows.Forms.TextBox();
            this.mtbCantidad = new System.Windows.Forms.MaskedTextBox();
            this.mtbPrecio = new System.Windows.Forms.MaskedTextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.mtbStock = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.btnCancelar);
            this.gbInventario.Controls.Add(this.mtbStock);
            this.gbInventario.Controls.Add(this.lblStock);
            this.gbInventario.Controls.Add(this.tboNombre);
            this.gbInventario.Controls.Add(this.mtbCantidad);
            this.gbInventario.Controls.Add(this.mtbPrecio);
            this.gbInventario.Controls.Add(this.tbCodigo);
            this.gbInventario.Controls.Add(this.btnConfirmar);
            this.gbInventario.Controls.Add(this.cboCategoria);
            this.gbInventario.Controls.Add(this.lblCantidad);
            this.gbInventario.Controls.Add(this.lblCategoria);
            this.gbInventario.Controls.Add(this.lblPrecio);
            this.gbInventario.Controls.Add(this.lblNombre);
            this.gbInventario.Controls.Add(this.lblCodigo);
            this.gbInventario.Location = new System.Drawing.Point(183, 21);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(379, 458);
            this.gbInventario.TabIndex = 1;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "Inventario";
            this.gbInventario.Enter += new System.EventHandler(this.gbInventario_Enter);
            // 
            // tboNombre
            // 
            this.tboNombre.Location = new System.Drawing.Point(111, 90);
            this.tboNombre.Name = "tboNombre";
            this.tboNombre.Size = new System.Drawing.Size(121, 20);
            this.tboNombre.TabIndex = 1;
            // 
            // mtbCantidad
            // 
            this.mtbCantidad.Location = new System.Drawing.Point(111, 194);
            this.mtbCantidad.Name = "mtbCantidad";
            this.mtbCantidad.Size = new System.Drawing.Size(121, 20);
            this.mtbCantidad.TabIndex = 3;
            // 
            // mtbPrecio
            // 
            this.mtbPrecio.Location = new System.Drawing.Point(110, 137);
            this.mtbPrecio.Name = "mtbPrecio";
            this.mtbPrecio.Size = new System.Drawing.Size(121, 20);
            this.mtbPrecio.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(110, 29);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(122, 20);
            this.tbCodigo.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(206, 413);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 23);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
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
            this.cboCategoria.Location = new System.Drawing.Point(111, 303);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 5;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(20, 191);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(20, 304);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 20);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(20, 137);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(75, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:    $";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(21, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(20, 244);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 20);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            // 
            // mtbStock
            // 
            this.mtbStock.Location = new System.Drawing.Point(111, 247);
            this.mtbStock.Name = "mtbStock";
            this.mtbStock.Size = new System.Drawing.Size(121, 20);
            this.mtbStock.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(68, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(739, 524);
            this.Controls.Add(this.gbInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNegocio";
            this.Text = "Pequeño negocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox tboNombre;
        private System.Windows.Forms.MaskedTextBox mtbCantidad;
        private System.Windows.Forms.MaskedTextBox mtbPrecio;
        private System.Windows.Forms.MaskedTextBox mtbStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnCancelar;
    }
}

