﻿using System;
using TarkDDD.Domain.Interfaces;
using TarkDDD.Domain.Interfaces.Repositories;

namespace TarkDDD.Infra.RepositoryTark
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : IEntity
    {
        public void Add(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public void Remove(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}