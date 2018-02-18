using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YACSAAS.Infrastructure.Domain;

namespace YACSAAS.Infrastructure.UnitOfWork
{
    //UnitOfWork for db context
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        ///     Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        int Commit();
    }
}
