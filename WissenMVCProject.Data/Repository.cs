﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WissenMVCProject.Model;

namespace WissenMVCProject.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext db;
        private readonly DbSet<T> entities;
        public Repository(ApplicationDbContext context)
        {
            this.db = context;
            entities = db.Set<T>();
        }
        public void Delete(T entity)
        {
            entities.Remove(entity);
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return entities.Where(where).FirstOrDefault();
        }

        public T Find(int id)
        {
            return entities.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {
            return entities.Where(where).ToList();
        }

        public void Insert(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.CreatedBy = "username";
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = "username";
            entities.Add(entity);
        }

        public void Update(T entity)
        {
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = "username";
            db.Entry<T>(entity).State = EntityState.Modified;
        }
        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }
        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
