﻿using System;
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
    public partial class frmAdminCategoria : MetroForm
    {
        private List<Categoria> _listado;
        public frmAdminCategoria()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _listado = CategoriaBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.CategoriaId,
                            Nombre = x.Nombre,
                            Estado = x.Estado.Nombre
                        };
            metroGrid1.DataSource = query.ToList();
        }

        private void frmAdminCategoria_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            _listado = CategoriaBL.Instance.SellecALL();

            var busqueda = from x in _listado
                           select new
                           {
                               Id = x.CategoriaId,
                               Nombre = x.Nombre,
                               Estado = x.Estado.Nombre
                           };
            var query = busqueda.Where(x => x.Nombre.ToLower().StartsWith(metroTextBox1.Text.ToLower())).ToList();
            metroGrid1.DataSource = query;
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmCategoriaNuevo frm = new frmCategoriaNuevo();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentRow.Cells["Editar"].Selected)
            {
                int id = (int)metroGrid1.CurrentRow.Cells[2].Value;
                string nombre = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                int estadoId = _listado.FirstOrDefault(x => x.CategoriaId.Equals(id)).EstadoId;

                Categoria entity = new Categoria()
                {
                    CategoriaId = id,
                    Nombre = nombre,
                    EstadoId = estadoId
                };

                //Editar
                frmCategoriaNuevo frm = new frmCategoriaNuevo(entity);
                frm.ShowDialog();
                UpdateGrid();


            }
            if (metroGrid1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                DialogResult dr = MessageBox.Show("Desea eliminar el registro actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (CategoriaBL.Instance.Delete(id))
                    {
                        MessageBox.Show("Se elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                UpdateGrid();
            }


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
