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
    public partial class frmAgregarProveedor : MetroForm
    {
        int id = 0;
        public frmAgregarProveedor()
        {
            InitializeComponent();
            UpdateComboEstado();
        }

        public frmAgregarProveedor(Proveedor entity)
        {
            InitializeComponent();
            id = entity.ProveedorId;
            metroTexboxNombre.Text = entity.Nombre;
            metroTextApellido.Text = entity.Apellido;
            metroTextTelefono.Text = entity.Telefono;
            metroTextDireccion.Text = entity.Direccion;
            UpdateComboEstado();
            metroComboEstado.SelectedValue = entity.EstadoId;


        }

        private void UpdateComboEstado()
        {
            metroComboEstado.DisplayMember = "Nombre";
            metroComboEstado.ValueMember = "EstadoId";
            metroComboEstado.DataSource = EstadoBL.Instance.SellecALL();
        }

        private void frmAgregarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (metroTexboxNombre.Text == "")
            {
                errorProvider1.SetError(metroTexboxNombre, "Campo obligatorio");
                return;
            }
            if (metroTextApellido.Text == "")
            {
                errorProvider1.SetError(metroTextApellido, "Campo obligatorio");
                return;
            }

            if (metroTextTelefono.Text == "")
            {
                errorProvider1.SetError(metroTextTelefono, "Campo obligatorio");
                return;
            }

            if (metroTextDireccion.Text == "")
            {
                errorProvider1.SetError(metroTextDireccion, "Campo obligatorio");
                return;
            }
            Proveedor entity = new Proveedor()
            {
                Nombre = metroTexboxNombre.Text.Trim(),
                Apellido = metroTextApellido.Text.Trim(),
                Telefono = metroTextTelefono.Text.Trim(),
                Direccion = metroTextDireccion.Text.Trim(),
                EstadoId = (int)metroComboEstado.SelectedValue

            };

            if (id == 0)
            {
                if (ProveedorBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Registro se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (ProveedorBL.Instance.Update(entity))
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
