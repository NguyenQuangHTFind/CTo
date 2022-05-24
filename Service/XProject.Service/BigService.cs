using Invedia.DI.Attributes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Contract.Repository.Infrastructure;
using XProject.Contract.Repository.Interface;
using XProject.Contract.Repository.Models;
using XProject.Contract.Service.Interface;

namespace XProject.Service
{
    [ScopedDependency(ServiceType = typeof(IBigService))]
    public class BigService : Base.Service, IBigService
    {
        private readonly IBigRepository _BigRepo;
        private readonly IUnitOfWork _uof;
        public BigService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _BigRepo = serviceProvider.GetRequiredService<IBigRepository>();
            _uof = serviceProvider.GetRequiredService<IUnitOfWork>();
        }

        public void Create(Big model)
        {
            _BigRepo.Add(model);
            _uof.SaveChanges();
        }
    }
}
