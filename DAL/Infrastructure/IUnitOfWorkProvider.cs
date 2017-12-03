using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Infrastructure
{
    
    public interface IUnitOfWorkProvider
    {
        IUnitOfWork Create();
        IUnitOfWork GetUnitOfWorkInstance();
    }

    public abstract class UnitOfWorkProviderBase : IUnitOfWorkProvider
    {
        protected readonly AsyncLocal<IUnitOfWork> UowLocalInstance
            = new AsyncLocal<IUnitOfWork>();

        /// <summary>
        /// Creates a new unit of work.
        /// </summary>
        public abstract IUnitOfWork Create();

        /// <summary>
        /// Gets the unit of work in the current scope.
        /// </summary>
        public IUnitOfWork GetUnitOfWorkInstance()
        {
            return UowLocalInstance != null ? UowLocalInstance.Value : throw new InvalidOperationException("UoW not created");
        }

        public void Dispose()
        {
            UowLocalInstance.Value?.Dispose();
            UowLocalInstance.Value = null;
        }
    }
    
}
