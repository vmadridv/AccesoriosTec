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
    public partial class frmAgregarCargo : MetroForm
    {
        int id = 0;
        public frmAgregarCargo()
        {
            InitializeComponent();
            UpdateCombo();
        }
        public frmAgregarCargo(Cargo entity)
        {
            InitializeComponent();
            id = entity.CargoId;
            metroTextBox1.Text = entity.Nombre;
            UpdateCombo();
            metroComboBox1.SelectedValue = entity.EstadoId;


        }

        private void frmAgregarCargo_Load(object sender, EventArgs e)
        {
            UpdateCombo();
        }
        private void UpdateCombo()
        {
            metroComboBox1.DisplayMember = "Nombre";
            metroComboBox1.ValueMember = "EstadoId";
            metroComboBox1.DataSource = EstadoBL.Instance.SellecALL();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (metroTextBox1.Text == "")
            {
                errorProvider1.SetError(metroTextBox1, "Campo obligatorio");
                return;
            }


            Cargo entity = new Cargo()
            {
                CargoId = id,
                Nombre = metroTextBox1.Text.Trim(),
                EstadoId = (int)metroComboBox1.SelectedValue

            };
            if (id == 0)
            {
                if (CargoBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Registro se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (CargoBL.Instance.Update(entity))
                {
                    MessageBox.Show("Registro se edito con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            this.Close();

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
