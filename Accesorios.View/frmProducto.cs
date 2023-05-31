using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accesorios.BusinessLogic;
using Accesorios.Entities;
using Accesorios.View;
using MetroFramework.Controls;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Accesorios.View
{
    public partial class frmProducto : MetroForm
    {
        private List<Producto> _listado;
        public frmProducto()
        {
            InitializeComponent();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _listado = ProductoBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.ProductoId,
                            Nombre = x.NombreProducto,
                            Descripcion = x.Descripcion,
                            PrecioUnitario = x.PrecioUnitario,
                            Categoria = x.Categorias.Nombre,
                            Estado = x.Estado.Nombre
                        };
            metroGrid1.DataSource = query.ToList();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            _listado = ProductoBL.Instance.SellecALL();
            var busqueda = from x in _listado
                           select new
                           {
                               Id = x.ProductoId,
                               Nombre = x.NombreProducto,
                               Descripcion = x.Descripcion,
                               PrecioUnitario = x.PrecioUnitario,
                               Categoria = x.Categorias.Nombre,
                               Estado = x.Estado.Nombre
                           };
            var query = busqueda.Where(x => x.Nombre.ToLower().StartsWith(metroTextBox1.Text.ToLower())).ToList();
            metroGrid1.DataSource = query;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmAgregarProducto frm = new frmAgregarProducto();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentRow.Cells["Editar"].Selected)
            {
                int id = (int)metroGrid1.CurrentRow.Cells[2].Value;
                string nombre = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                string descripcion = metroGrid1.CurrentRow.Cells[4].Value.ToString();
                decimal preciounitario = (decimal)metroGrid1.CurrentRow.Cells[5].Value;
                int categoriaId = _listado.FirstOrDefault(x => x.ProductoId.Equals(id)).CategoriaId;
                int estadoId = _listado.FirstOrDefault(x => x.ProductoId.Equals(id)).EstadoId;

                Producto entity = new Producto()
                {
                    ProductoId = id,
                    NombreProducto = nombre,
                    Descripcion = descripcion,
                    PrecioUnitario = preciounitario,
                    CategoriaId = categoriaId,
                    EstadoId = estadoId
                };

                //Editar
                frmAgregarProducto frm = new frmAgregarProducto(entity);
                frm.ShowDialog();
                UpdateGrid();


            }
            if (metroGrid1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                DialogResult dr = MessageBox.Show("Desea eliminar el registro actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (ProductoBL.Instance.Delete(id))
                    {
                        MessageBox.Show("Se elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                UpdateGrid();
            }
        }
    }
}
