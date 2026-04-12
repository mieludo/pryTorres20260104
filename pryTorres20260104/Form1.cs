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
            btnConfirmar_Click(sender, e, tboDescripcion);
        }

        private void btnConfirmar_Click(object sender, EventArgs e, TextBox tboDescripcion)
        {
            if (tboCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el codigo");
                tboCodigo.Focus();
            }
            else
            {
                if (tboNombre.Text == "")
                {
                    MessageBox.Show("Ingrese el nombre");
                    tboNombre.Focus();

                }
                else
                {
                    if (tboDescripcion.Text == "")
                    {
                        MessageBox.Show("Ingrese la descripcion");
                        tboDescripcion.Focus();
                    }
                    else
                    {
                        if (mtbPrecio.Text == "")
                        {
                            MessageBox.Show("Ingrese el precio");
                            mtbPrecio.Focus();
                        }
                        else
                        {
                            if (mtbCantidad.Text == "")
                            {
                                MessageBox.Show("Ingrese la cantidad deseada");
                                mtbCantidad.Focus();
                            }
                            else
                            {
                                if (mtbStock.Text == "")
                                {
                                    MessageBox.Show("Ingrese el stock");
                                    mtbStock.Focus();
                                }
                                else
                                {
                                    if (cboCategoria.Text == "")
                                    {
                                        MessageBox.Show("Ingrese la categoria");
                                        cboCategoria.Focus();
                                        //desde interfaz gráfica

                                        lblRegistro.Text = tboCodigo.Text + '┆' + tboNombre.Text + '┆' + mtbPrecio.Text + '┆' + mtbCantidad.Text + '┆' + mtbStock.Text + '┆' + cboCategoria.Text + '┆' + tboDescripcion.Text;

                                        //pasar los datos a variable y luego mostrarlo
                                        varCodigo = tboCodigo.Text;
                                        varNombre = tboNombre.Text;
                                        varDescripcion = tboDescripcion.Text;
                                        varCategoria = cboCategoria.Text;
                                        //usando el tipo de dato para parsear
                                        varPrecio = int.Parse(mtbPrecio.Text);
                                        varCantidad = mtbCantidad.Text;
                                        //usando .net para convertir
                                        varStock = Convert.ToInt32(mtbStock.Text);

                                        lblRegistroDos.Text = varCodigo + " " + varPrecio.ToString() + " " + varStock.ToString() + " " + varCantidad + " " + varCategoria + " " + varDescripcion;


                                        string datoAgregado = varCodigo + " " + varPrecio.ToString() + " " + varStock.ToString() + " " + varCantidad + " " + varCategoria + " " + varDescripcion;

                                        MessageBox.Show(datoAgregado);
                                        //cuando haga click en confirmar "limpiar" la pantalla para
                                        //registrar un nuevo producto



                                        {

                                        }
                                    }


                                }
                            }
                        }
                    }
                }
            }
        }
private void mtbCantidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }
    }
}



