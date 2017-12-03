using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Riganti.Utils.Infrastructure.Core;

namespace BussinessLayer.Services
{
    public abstract class ServiceBase
    {
        public IUnitOfWorkProvider UnitOfWorkProvider { get; set; }
        protected readonly IMapper Mapper;


        protected ServiceBase(IMapper mapper)
        {
            this.Mapper = mapper;
        }
    }
}
