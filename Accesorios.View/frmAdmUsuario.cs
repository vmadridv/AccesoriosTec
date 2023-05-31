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
    public partial class frmAdmUsuario : MetroForm
    {
        private List<Usuario> _listado;
        public frmAdmUsuario()
        {
            InitializeComponent();
        }
        private void frmAdmUsuario_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _listado = UsuarioBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.UsuarioId,
                            Correo = x.Email,
                            Clave = x.Password,
                            Rol = x.Roles.Nombre
                        };
            metroGrid1.DataSource = query.ToList();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmUsuarioNuevo frm = new frmUsuarioNuevo();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            _listado = UsuarioBL.Instance.SellecALL();

            var busqueda = from x in _listado
                           select new
                           {
                               Id = x.UsuarioId,
                               Correo = x.Email,
                               Clave = x.Password,
                               Rol = x.Roles.Nombre
                           };
            var query = busqueda.Where(x => x.Correo.ToLower().Contains(metroTextBox1.Text.ToLower())).ToList();
            metroGrid1.DataSource = query;
        }
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentRow.Cells["Editar"].Selected)
            {

                int id = (int)metroGrid1.CurrentRow.Cells[2].Value;
                string correo = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                string clave = metroGrid1.CurrentRow.Cells[4].Value.ToString();
                int rolid = _listado.FirstOrDefault(x => x.UsuarioId.Equals(id)).RolId;



                Usuario entity = new Usuario()
                {
                    UsuarioId = id,
                    Email = correo,
                    Password = clave,
                    RolId = rolid

                };

                //Editar
                frmUsuarioNuevo frm = new frmUsuarioNuevo(entity);
                frm.ShowDialog();
                UpdateGrid();


            }
            if (metroGrid1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                DialogResult dr = MessageBox.Show("Desea eliminar el registro actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (UsuarioBL.Instance.Delete(id))
                    {
                        MessageBox.Show("Se elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                UpdateGrid();

            }
        }
    }
}
