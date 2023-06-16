using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);//Referansı yakala
                addedEntity.State = EntityState.Added;//ekle
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);//Referansı yakala
                deletedEntity.State = EntityState.Deleted;//sil
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
#pragma warning disable CS8603 // Possible null reference return.
                return context.Set<TEntity>().SingleOrDefault(filter);
#pragma warning restore CS8603 // Possible null reference return.
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null //Filtre null mı?
                    ? context.Set<TEntity>().ToList() //Evetse bu satır çalışır
                    : context.Set<TEntity>().Where(filter).ToList();//Değilse bu satır çalışır
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);//Referansı yakala
                updatedEntity.State = EntityState.Modified;//güncelle
                context.SaveChanges();
            }
        }
    }
}
