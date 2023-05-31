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
    public partial class frmAgregarCliente : MetroForm
    {
        int id = 0;
        public frmAgregarCliente()
        {
            InitializeComponent();
            UpdateComboEstado();
        }
        public frmAgregarCliente(Cliente entity)
        {
            InitializeComponent();
            id = entity.ClienteId;
            metroTextBoxNombre.Text = entity.Nombre;
            metroTextBoxApellido.Text = entity.Apellido;
            metroTextBoxtTelefono.Text = entity.Telefono;
            UpdateComboEstado();
            metroComboEstado.SelectedValue = entity.EstadoId;

        }
        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            UpdateComboEstado();
        }
        private void UpdateComboEstado()
        {
            metroComboEstado.DisplayMember = "Nombre";
            metroComboEstado.ValueMember = "EstadoId";
            metroComboEstado.DataSource = EstadoBL.Instance.SellecALL();
        }
        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (metroTextBoxNombre.Text == "")
            {
                errorProvider1.SetError(metroTextBoxNombre, "Campo obligatorio");
                return;
            }
            if (metroTextBoxApellido.Text == "")
            {
                errorProvider1.SetError(metroTextBoxApellido, "Campo obligatorio");
                return;
            }

            if (metroTextBoxtTelefono.Text == "")
            {
                errorProvider1.SetError(metroTextBoxtTelefono, "Campo obligatorio");
                return;
            }
            Cliente entity = new Cliente()
            {
                ClienteId = id,
                Nombre = metroTextBoxNombre.Text.Trim(),
                Apellido = metroTextBoxApellido.Text.Trim(),
                Telefono = metroTextBoxtTelefono.Text.Trim(),
                EstadoId = (int)metroComboEstado.SelectedValue




            };

            if (id == 0)
            {
                if (ClienteBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Registro se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (ClienteBL.Instance.Update(entity))
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
