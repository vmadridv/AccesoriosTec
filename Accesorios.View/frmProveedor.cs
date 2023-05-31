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
    public partial class frmProveedor : MetroForm
    {
        private List<Proveedor> _listado;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _listado = ProveedorBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.ProveedorId,
                            Nombre = x.Nombre,
                            Apellido = x.Apellido,
                            Telefono = x.Telefono,
                            Direccion = x.Direccion,
                            Estado = x.Estado.Nombre

                        };
            metroGrid1.DataSource = query.ToList();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor frm = new frmAgregarProveedor();
            frm.ShowDialog();
            UpdateGrid();
        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            _listado = ProveedorBL.Instance.SellecALL();
            var busqueda = from x in _listado
                           select new
                           {
                               Id = x.ProveedorId,
                               Nombre = x.Nombre,
                               Apellido = x.Apellido,
                               Telefono = x.Telefono,
                               Direccion = x.Direccion,
                               Estado = x.Estado.Nombre

                           };
            var query = busqueda.Where(x => x.Nombre.ToLower().Contains(metroTextBox1.Text.ToLower())
                        || x.Apellido.ToLower().Contains(metroTextBox1.Text.ToLower())).ToList();

            metroGrid1.DataSource = query.ToList();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentRow.Cells["Editar"].Selected)
            {

                int id = (int)metroGrid1.CurrentRow.Cells[2].Value;
                string nombre = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                string apellido = metroGrid1.CurrentRow.Cells[4].Value.ToString();
                string telefono = metroGrid1.CurrentRow.Cells[5].Value.ToString();
                string direccion = metroGrid1.CurrentRow.Cells[6].Value.ToString();
                int estadoId = _listado.FirstOrDefault(x => x.ProveedorId.Equals(id)).EstadoId;



                Proveedor entity = new Proveedor()
                {
                    ProveedorId = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Direccion = direccion,
                    EstadoId = estadoId


                };

                //Editar
                frmAgregarProveedor frm = new frmAgregarProveedor(entity);
                frm.ShowDialog();
                UpdateGrid();


            }
            if (metroGrid1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                DialogResult dr = MessageBox.Show("Desea eliminar el registro actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (ProveedorBL.Instance.Delete(id))
                    {
                        MessageBox.Show("Se elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                UpdateGrid();

            }
        }
    }
}
