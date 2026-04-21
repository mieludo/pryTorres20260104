using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorres20260104
{
    public partial class frmNegocio : Form

    {
        //DECLARACION DE VARIABLES GLOBALES
        string varCodigo = "";
        string varNombre = "";
        string varCantidad = "";
        string varDescripcion = "";
        string varCategoria = "";
        int varPrecio = 0;
        int varStock = 0;



        public frmNegocio()
        {
            InitializeComponent();
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gbInventario_Enter(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (tboCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el código");
                tboCodigo.Focus();
                return;
            }

            if (tboNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre");
                tboNombre.Focus();
                return;
            }

            if (mtbPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el precio");
                mtbPrecio.Focus();
                return;
            }

            if (mtbCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la cantidad deseada");
                mtbCantidad.Focus();
                return;
            }

            if (mtbStock.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el stock");
                mtbStock.Focus();
                return;
            }

            if (cboCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la categoría");
                cboCategoria.Focus();
                return;
            }

            if (tboDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la descripción");
                tboDescripcion.Focus();
                return;
            }

            // Asignar variables
            varCodigo = tboCodigo.Text;
            varNombre = tboNombre.Text;
            varDescripcion = tboDescripcion.Text;
            varCategoria = cboCategoria.Text;
            int.TryParse(mtbPrecio.Text, out varPrecio);
            varCantidad = mtbCantidad.Text;
            int.TryParse(mtbStock.Text, out varStock);

            // Construir texto multilínea para mostrar debajo de la caja de descripción
            string salida =
                "Código: " + varCodigo + "\r\n" +
                "Nombre: " + varNombre + "\r\n" +
                "Precio: $" + varPrecio.ToString() + "\r\n" +
                "Cantidad: " + varCantidad + "\r\n" +
                "Stock: " + varStock.ToString() + "\r\n" +
                "Categoría: " + varCategoria + "\r\n" +
                "Descripción: " + varDescripcion;

            // Mostrar en la label que está debajo de la descripción
            lblRegistro.Text = salida;


            //limpiar para un nuevo registro
            tboCodigo.Clear();
            tboNombre.Clear();
            tboDescripcion.Clear();
            mtbPrecio.Clear();
            mtbCantidad.Clear();
            mtbStock.Clear();
            cboCategoria.SelectedIndex = -1;
            tboCodigo.Focus();
        }

private void mtbCantidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // No guardar: limpiar todos los controles y cancelar la operación
            tboCodigo.Clear();
            tboNombre.Clear();
            tboDescripcion.Clear();
            mtbPrecio.Clear();
            mtbCantidad.Clear();
            mtbStock.Clear();
            cboCategoria.SelectedIndex = -1;

            // Borrar cualquier texto de registro mostrado
            lblRegistro.Text = string.Empty;
            

            // Devolver foco al primer campo
            tboCodigo.Focus();
        }

        
        private void lblRegistro_Click(object sender, EventArgs e)
        {
        }
    }
}



