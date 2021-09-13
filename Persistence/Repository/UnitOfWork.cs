using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IServicesRepository serviceRepository) => Services = serviceRepository;
  
        public IServicesRepository Services { get; }
    }
}
