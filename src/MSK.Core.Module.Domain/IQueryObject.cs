﻿using System;
using System.Linq.Expressions;

namespace MSK.Core.Module.Domain
{
    public interface IQueryObject<TEntity> where TEntity : IEntity
    {
        Expression<Func<TEntity, bool>> Query();
        Expression<Func<TEntity, bool>> And(Expression<Func<TEntity, bool>> query);
        Expression<Func<TEntity, bool>> Or(Expression<Func<TEntity, bool>> query);
        Expression<Func<TEntity, bool>> And(IQueryObject<TEntity> queryObject);
        Expression<Func<TEntity, bool>> Or(IQueryObject<TEntity> queryObject);
    }
}
