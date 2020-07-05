using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SpiderDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Yin.Umbrella.DataBase;

namespace Snai.Mysql.DataAccess.Base
{
    public class DataAccess : DbContext
    {
        public DataAccess(DbContextOptions<DataAccess> options)
            : base(options)
        { }
        public override EntityEntry Add(object entity)
        {
            return base.Add(entity);
        }
        public override int SaveChanges()
        {
            SetSystemField();
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            SetSystemField();
            return  base.SaveChangesAsync();
        }
        /// <summary>
        /// 系统字段赋值
        /// </summary>
        private void SetSystemField()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is EntityBase)
                {
                    var entity = (EntityBase)item.Entity;
                    //添加操作
                    if (item.State == EntityState.Added)
                    {                       
                        if (entity.Id == Guid.Empty)
                        {
                            entity.Id = Guid.NewGuid();
                        }
                        entity.CreateTime = DateTime.Now;
                        entity.ModifiedTime = DateTime.Now;
                    }
                    //修改操作
                    else if (item.State == EntityState.Modified)
                    {
                        entity.ModifiedTime = DateTime.Now;
                    }
                }

            }           
        }
        public DbSet<User> User { get; set; }
    }
    public static class DbSetExtension
    {
        public  static EntityEntry<TEntity> UpdateX<TEntity>( this DbSet<TEntity> dbSet, TEntity entity)where TEntity: EntityBase
        {
            entity.ModifiedTime = DateTime.Now;
            return dbSet.Update(entity);
        }
        public static void UpdateRangeX<TEntity>(this DbSet<TEntity> dbSet, params TEntity[] entities) where TEntity : EntityBase
        {
            foreach (var entity in entities)
            {
                entity.ModifiedTime = DateTime.Now;
            }
            dbSet.UpdateRange(entities);
        }
        public static void AddRangeX<TEntity>(this DbSet<TEntity> dbSet, IEnumerable<TEntity> entities) where TEntity : EntityBase
        {
            foreach (var entity in entities)
            {
                if (entity.Id == Guid.Empty)
                {
                    entity.Id = Guid.NewGuid();
                }
                entity.CreateTime = DateTime.Now;
                entity.ModifiedTime= DateTime.Now;
            }
            dbSet.AddRange(entities);
        }
        public static EntityEntry<TEntity> AddX<TEntity>(this DbSet<TEntity> dbSet, TEntity entity) where TEntity : EntityBase
        {
            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }
            entity.CreateTime = DateTime.Now;
            entity.ModifiedTime = DateTime.Now;
            return dbSet.Add(entity);
        }
    }
    public class UmbDbSet<TEntity> : DbSet<TEntity> where TEntity : EntityBase
    {
        public UmbDbSet():base()
        {

        }
        public override EntityEntry<TEntity> Update(TEntity entity)
        {
            entity.ModifiedTime = DateTime.Now;
            return base.Update(entity);
        }
        public override void UpdateRange(params TEntity[] entities)
        {
            foreach (var entity in entities)
            {
                entity.ModifiedTime = DateTime.Now;
            }
            base.UpdateRange(entities); 
        }
        public override void AddRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                if (entity.Id == Guid.Empty)
                {
                    entity.Id = Guid.NewGuid();
                }
                entity.CreateTime = DateTime.Now;
            }
            base.AddRange(entities);
        }
        public override EntityEntry<TEntity> Add(TEntity entity)
        {
            if (entity.Id==Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }
            entity.CreateTime = DateTime.Now;
            return base.Add(entity);
        }

    }
}
