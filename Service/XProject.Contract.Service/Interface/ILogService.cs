using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Contract.Repository.Models;
using XProject.Contract.Repository.Infrastructure;

namespace XProject.Contract.Service.Interface
{
    public interface ILogService
    {
        void Create(List<IFormFile> files, Log log);

        void UpdateLog(Log log, string id);
        void Delete(Log log, string id);

        List<Log> Get();
        
       
    }
}