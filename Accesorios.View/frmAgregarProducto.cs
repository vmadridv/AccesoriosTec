using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accesorios.BusinessLogic;
using Accesorios.Entities;
using MetroFramework.Forms;

namespace Accesorios.View
{
    public partial class frmAgregarProducto : MetroForm
    {
        int id = 0;
        public frmAgregarProducto()
        {
            InitializeComponent();
            UpdateComboCategoria();
            UpdateComboEstado();
        }
        public frmAgregarProducto(Producto entity)
        {
            InitializeComponent();
            id = entity.ProductoId;

            metroTexboxNombre.Text = entity.NombreProducto;
            metroTextDescripcion.Text = entity.Descripcion;
            metroTexPrecioUnitario.Text = Convert.ToDecimal(entity.PrecioUnitario).ToString();
            UpdateComboCategoria();
            metroComboCategoria.SelectedValue = entity.CategoriaId;
            UpdateComboEstado();
            metroComboEstado.SelectedValue = entity.EstadoId;


        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void UpdateComboEstado()
        {
            metroComboEstado.DisplayMember = "Nombre";
            metroComboEstado.ValueMember = "EstadoId";
            metroComboEstado.DataSource = EstadoBL.Instance.SellecALL();
        }
        private void UpdateComboCategoria()
        {
            metroComboCategoria.DisplayMember = "Nombre";
            metroComboCategoria.ValueMember = "CategoriaId";
            metroComboCategoria.DataSource = CategoriaBL.Instance.SellecALL();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Producto entity = new Producto()
            {
                NombreProducto = metroTexboxNombre.Text,
                Descripcion = metroTextDescripcion.Text,
                PrecioUnitario = decimal.Parse(metroTexPrecioUnitario.Text.ToString()),
                CategoriaId = (int)metroComboCategoria.SelectedValue,
                EstadoId = (int)metroComboEstado.SelectedValue


            };

            if (id == 0)
            {
                if (ProductoBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Registro se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (ProductoBL.Instance.Update(entity))
                {
                    MessageBox.Show("Registro se edito con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
