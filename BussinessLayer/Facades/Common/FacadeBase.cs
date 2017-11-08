using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riganti.Utils.Infrastructure.Core;


namespace BussinessLayer.Facades.Common
{
    public abstract class FacadeBase
    {
        protected readonly IUnitOfWorkProvider UnitOfWorkProvider;
        protected FacadeBase(IUnitOfWorkProvider unitOfWorkProvider)
        {
            UnitOfWorkProvider = unitOfWorkProvider;
        }

    }
}
