﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SecretGarden.Models.Abstraction
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params string[] includedProps);

        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
    }
}
