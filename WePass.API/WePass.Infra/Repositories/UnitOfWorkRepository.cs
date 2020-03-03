using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Interfaces;
using WePass.Infra.Context;
using WePass.Infra.Entities;
using WePass.Infra.Interfaces;
using WePass.Infra.Repositories.Base;

namespace WePass.Infra.Repositories
{
    public class UnitOfWorkRepository : RepositoryBase<Domain.Model.UnitOfWork, UnitOfWork>, IRepositoryUnitOfWork
    {
        private readonly WePassContext _context;

        private UsuarioRepository usuarioRepository = null;
        private CompraRepository compraRepository = null;
        private EventoRepository eventoRepository = null;
        private PagamentoRepository pagamentoRepository = null;

        private bool disposed = false;

        public UnitOfWorkRepository(WePassContext context) : base(context) 
        {
            _context = context;
        }


        public IUsuarioRepository Usuario {
            get {
                if (usuarioRepository == null)
                {
                    usuarioRepository = new UsuarioRepository(_context);
                }
                return usuarioRepository;
            }
        }

        public ICompraRepository Compra {
            get {
                if (compraRepository == null)
                {
                    compraRepository = new CompraRepository(_context);
                }
                return compraRepository;
            }
        }

        public IEventoRepository Evento {
            get {
                if (eventoRepository == null)
                {
                    eventoRepository = new EventoRepository(_context);
                }
                return eventoRepository;
            }
        }

        public IPagamentoRepository Pagamento {
            get {
                if (pagamentoRepository == null)
                {
                    pagamentoRepository = new PagamentoRepository(_context);
                }
                return pagamentoRepository;
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
