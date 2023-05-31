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
    public partial class frmEstado : MetroForm
    {
        private List<Estado> _listado;
        public frmEstado()
        {
            InitializeComponent();
        }

        private void frmEstado_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _listado = EstadoBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.EstadoId,
                            Nombre = x.Nombre
                        };
            metroGrid1.DataSource = query.ToList();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmEstadoNuevo frm = new frmEstadoNuevo();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            _listado = EstadoBL.Instance.SellecALL();

            var busqueda = from x in _listado
                           select new
                           {
                               Id = x.EstadoId,
                               Nombre = x.Nombre
                           };
            var query = busqueda.Where(x => x.Nombre.ToLower().Contains(metroTextBox1.Text.ToLower())).ToList();
            metroGrid1.DataSource = query;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                int id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                string nombre = metroGrid1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                Estado entity = new Estado()
                {
                    EstadoId = id,
                    Nombre = nombre
                };

                //Editar
                frmEstadoNuevo frm = new frmEstadoNuevo(entity);
                frm.ShowDialog();
                UpdateGrid();


            }
            if (metroGrid1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                DialogResult dr = MessageBox.Show("Desea eliminar el registro actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (EstadoBL.Instance.Delete(id))
                    {
                        MessageBox.Show("Se elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                UpdateGrid();
            }
        }
    }
}
