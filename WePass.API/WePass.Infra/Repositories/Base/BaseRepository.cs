using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using WePass.Domain.Interfaces.Base;
using WePass.Infra.Context;

namespace WePass.Infra.Repositories.Base
{
    public class BaseRepository<T, K> : IRepositoryBase<T> where T : class where K : class
    {
        protected readonly WePassContext _db;
        private IMapper _mapper;

        public BaseRepository(WePassContext context)
        {
            _db = context;
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile(typeof(MapperProfile));
            });
            _mapper = config.CreateMapper();
        }

        public List<T> List(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            var query = _db.Set<K>().ProjectTo<T>(_mapper.ConfigurationProvider);

            if (include != null)
            {
                query = include(query);
            }

            return query.AsNoTracking().ToList();
        }

        public List<T> Find(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            var query = _db.Set<K>().ProjectTo<T>(_mapper.ConfigurationProvider).Where(where);

            if (include != null)
            {
                query = include(query);
            }

            return query.AsNoTracking().ToList();
        }

        public T Query(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            var query = _db.Set<K>().ProjectTo<T>(_mapper.ConfigurationProvider).Where(where);

            if (include != null)
            {
                query = include(query);
            }

            return query.AsNoTracking().FirstOrDefault();
        }

        public void Add(T entity)
        {
            var model = _mapper.Map<K>(entity);
            _db.Set<K>().Add(model);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            var model = _mapper.Map<K>(entity);
            _db.Set<K>().Remove(model);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            var models = _db.Set<K>().ProjectTo<T>(_mapper.ConfigurationProvider).Where(where);
            if (models.Any())
            {
                var entities = _mapper.Map<List<K>>(models);
                _db.Set<K>().RemoveRange(entities);
            }
        }

        public T FindBy(Expression<Func<T, bool>> where)
        {
            var model = _db.Set<K>().ProjectTo<T>(_mapper.ConfigurationProvider)
                .Where(where).FirstOrDefault();
            return model;
        }

        public void Update(T entity)
        {
            var model = _mapper.Map<K>(entity);
            _db.Entry(model).State = EntityState.Modified;
        }

        public Guid Incluir(T entity)
        {
            throw new NotImplementedException();
        }

        public T Buscar(T entity)
        {
            throw new NotImplementedException();
        }

        public T Alterar(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
