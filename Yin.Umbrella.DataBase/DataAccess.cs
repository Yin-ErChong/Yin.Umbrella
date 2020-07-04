using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SpiderDataBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yin.Umbrella.DataBase;

namespace Snai.Mysql.DataAccess.Base
{
    public class DataAccess : DbContext
    {
        public DataAccess(DbContextOptions<DataAccess> options)
            : base(options)
        { }

        public UmbDbSet<User> User { get; set; }
    }
    public class UmbDbSet<TEntity> : DbSet<TEntity> where TEntity : EntityBase
    {
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
