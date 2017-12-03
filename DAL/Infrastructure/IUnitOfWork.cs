using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure
{
    
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        /// <summary>
        /// Registers an action, which is executed if and only if commit is succesfull.
        /// </summary>
        void RegisterAction(Action action);
    }
    
}
