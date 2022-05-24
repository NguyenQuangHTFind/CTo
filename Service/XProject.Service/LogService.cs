using Invedia.DI.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Contract.Repository.Infrastructure;
using XProject.Contract.Repository.Interface;
using XProject.Contract.Repository.Models;
using XProject.Contract.Service.Interface;
using XProject.Core.Constants;
using Microsoft.AspNetCore.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace XProject.Service
{
    [ScopedDependency(ServiceType = typeof(ILogService))]
    public class LogService : Base.Service, ILogService
    {
        private readonly ILogRepository _LogRepo;
        private readonly IUnitOfWork _uof;
        public LogService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _LogRepo = serviceProvider.GetRequiredService<ILogRepository>();
            _uof = serviceProvider.GetRequiredService<IUnitOfWork>();
        }

        public List<Log> Get()
        {
            _LogRepo.Get();
            _uof.SaveChanges();
            return _LogRepo.Get().ToList();
        }

        public void Create(List<IFormFile> files, Log log)
        {
            List<Contract.Repository.Models.Log> f = new List<Contract.Repository.Models.Log>();
            string path1 = "D:\\log";
            string path2 = Path.Combine(path1, log.Id.ToString());
            if (files.Count > 0)
            {
                Directory.CreateDirectory(path2);
                foreach (var file in files)
                {
                    string s = file.FileName;
                    var FilePath = path2 + "\\" + s;

                    using (var stream = System.IO.File.Create(FilePath))
                    {
                        file.CopyToAsync(stream);
                    }
                    Contract.Repository.Models.Log ff = new Contract.Repository.Models.Log();

                    log.FileName = Path.GetFileName(file.FileName).ToString();
                    f.Add(ff);
                }
            }
            _LogRepo.AddRange(log);
            _uof.SaveChanges();
        }

        public void Update(Log log, string id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Log log, string id)
        {
            throw new NotImplementedException();
        }

        public void Update(List<IFormFile> files, Log log)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<IFormFile> files, Log log)
        {
            throw new NotImplementedException();
        }
    }
}
