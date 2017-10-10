using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure
{
    public interface IUnitOfWorkProvider
    {
        IUnitOfWork Create();
        IUnitOfWork GetUnitOfWorkInstance();
    }
}
