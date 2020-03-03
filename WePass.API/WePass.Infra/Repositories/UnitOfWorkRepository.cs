using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Interfaces;
using WePass.Infra.Context;

namespace WePass.Infra.Repositories
{
    public class UnitOfWorkRepository
    {
        private readonly WePassContext _context;

        private UsuarioRepository usuarioRepository = null;

        public UnitOfWorkRepository(WePassContext context) : base(context)
        {
            _context = context;
        }


        public IUsuarioRepository Usuario {
            get {
                if (UsuarioRepository == null)
                {
                    usuarioRepository = new UsuarioRepository(_context);
                }
                return UsuarioRepository;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public new bool Commit()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
