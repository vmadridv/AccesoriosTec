using Accesorios.Entities;
using Accesorios.Entities.AppContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Accesorios.DataAccess
{
    public class ProductoDAL
    {
        private static ProductoDAL _instance;

        public static ProductoDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductoDAL();
                }
                return _instance;

            }


        }

        public bool Insert(Producto entity)
        {
            bool result = false;
            using (AppDBContext _context = new AppDBContext())
            {
                var query = _context.Productos
                    .FirstOrDefault(x => x.NombreProducto.Equals(entity.NombreProducto)
                    );
                if (query == null)
                {
                    _context.Productos.Add(entity);
                    result = _context.SaveChanges() > 0;
                    _context.Inventarios.Add(new Inventario { ProductoId = entity.ProductoId, cantidad = 0 });

                }

                return result;

            }

        }


        public List<Producto> SellectAll()
        {
            List<Producto> result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                result = _context.Productos.Include(x => x.Estado).Include(c => c.Categorias).ToList();
            }

            return result;


        }

        public Producto SellectById(int id)
        {
            Producto result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                result = _context.Productos
                    .FirstOrDefault(x => x.ProductoId == id);
            }

            return result;


        }

        public bool Update(Producto entity)
        {
            bool result = false;
            using (AppDBContext _context = new AppDBContext())
            {


                _context.Entry(entity).State = EntityState.Modified;
                result = _context.SaveChanges() > 0;


            }
            return result;

        }

        public bool Delete(int Id)
        {
            using (AppDBContext _context = new AppDBContext())
            {

                bool result = false;

                var query = _context.Productos.FirstOrDefault(x => x.ProductoId == Id);
                if (query != null)
                {
                    _context.Productos.Remove(query);
                    result = _context.SaveChanges() > 0;
                }

                return result;
            }

        }

    }
}
