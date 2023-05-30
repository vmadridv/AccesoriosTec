using Accesorios.Entities.AppContext;
using Accesorios.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesorios.DataAccess
{
    public class UsuarioDAL
    {
        private static UsuarioDAL _instance;

        public static UsuarioDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsuarioDAL();
                }
                return _instance;

            }


        }

        public List<Usuario> SellectAll()
        {
            List<Usuario> result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                result = _context.Usuarios.Include(x => x.Roles).ToList();
            }

            return result;


        }

        public Usuario SellectById(int id)
        {
            Usuario result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                result = _context.Usuarios
                    .FirstOrDefault(x => x.UsuarioId == id);
            }

            return result;


        }
        public bool Insert(Usuario entity)
        {
            bool result = false;
            using (AppDBContext _context = new AppDBContext())
            {
                var query = _context.Usuarios.FirstOrDefault(x => x.Email.Equals(entity.Email));
                if (query == null)
                {
                    _context.Usuarios.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }

        }

        public bool Update(Usuario entity)
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

                var query = _context.Usuarios.FirstOrDefault(x => x.UsuarioId == Id);
                if (query != null)
                {
                    _context.Usuarios.Remove(query);
                    result = _context.SaveChanges() > 0;
                }

                return result;
            }

        }

        //public Usuario Login(string email, string password)
        //{

        //    using (AppDBContext _context = new AppDBContext())
        //    {
        //        return _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Password == password);
        //    }

        //}
        public Usuario Login(string email, string password)
        {
            Usuario _entity = new Usuario();

            using (AppDBContext _context = new AppDBContext())
            {

                _entity = _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Password == password);
            }
            return _entity;
        }
    }
}
