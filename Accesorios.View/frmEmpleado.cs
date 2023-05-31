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
    public partial class frmEmpleado : MetroForm
    {
        private List<Empleado> _listado;
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _listado = EmpleadoBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.EmpleadoId,
                            Nombre = x.Nombre,
                            Apellido = x.Apellido,
                            Direccion = x.Direccion,
                            Dui = x.DUi,
                            Telefono = x.Telefono,
                            Cargo = x.Cargos.Nombre,
                            Estado = x.Estado.Nombre,
                            Usuario = x.Usuario.Email
                        };
            metroGrid1.DataSource = query.ToList();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            frmAgregarEmpleado frm = new frmAgregarEmpleado();
            frm.ShowDialog();
            UpdateGrid();
        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {

            _listado = EmpleadoBL.Instance.SellecALL();
            var busqueda = from x in _listado
                           select new
                           {
                               Id = x.EmpleadoId,
                               Nombre = x.Nombre,
                               Apellido = x.Apellido,
                               Direccion = x.Direccion,
                               Dui = x.DUi,
                               Telefono = x.Telefono,
                               Cargo = x.Cargos.Nombre,
                               Estado = x.Estado.Nombre,
                               Usuario = x.Usuario.Email
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
                string direccion = metroGrid1.CurrentRow.Cells[5].Value.ToString();
                string dui = metroGrid1.CurrentRow.Cells[6].Value.ToString();
                string telefono = metroGrid1.CurrentRow.Cells[7].Value.ToString();
                int cargoid = _listado.FirstOrDefault(x => x.EmpleadoId.Equals(id)).CargoId;
                int estadoId = _listado.FirstOrDefault(x => x.EmpleadoId.Equals(id)).EstadoId;
                int usuarioid = _listado.FirstOrDefault(x => x.EmpleadoId.Equals(id)).UsuarioId;



                Empleado entity = new Empleado()
                {
                    EmpleadoId = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Direccion = direccion,
                    DUi = dui,
                    CargoId = cargoid,
                    EstadoId = estadoId,
                    UsuarioId = usuarioid
                };

                //Editar
                frmAgregarEmpleado frm = new frmAgregarEmpleado(entity);
                frm.ShowDialog();
                UpdateGrid();


            }
            if (metroGrid1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                DialogResult dr = MessageBox.Show("Desea eliminar el registro actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (EmpleadoBL.Instance.Delete(id))
                    {
                        MessageBox.Show("Se elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                UpdateGrid();

            }
        }
    }
}
