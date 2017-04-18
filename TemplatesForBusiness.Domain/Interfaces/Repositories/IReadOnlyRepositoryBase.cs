﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatesForBusiness.Domain.Interfaces.Repositories
{
    /// <summary>
    /// This repository is intended to be used on tables which are full ReadOnly over the application domain life cycle
    /// the kind of table that will be feeded only at the development of the Software
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IReadOnlyRepositoryBase<TEntity> where TEntity : class
    {
        void GetAll();

        void GetById(params object[] keys);
    }
}
