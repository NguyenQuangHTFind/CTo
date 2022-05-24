using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using XProject.Contract.Repository.Models;
using XProject.Contract.Service.Interface;
using XProject.Core.Constants;

namespace XProject.WebApi.Controllers
{
    public class LogController : Controller
    {
        private readonly ILogService _logService;
        public LogController(IServiceProvider serviceProvider)
        {
            _logService = serviceProvider.GetRequiredService<ILogService>();
        }

        [HttpGet]
        [Route(Endpoints.LogEndpoint.GetLog)]
        public List<Log> GetLog()
        {
            return _logService.Get().ToList();
        }


        [HttpPost]
        [Route(Endpoints.LogEndpoint.CreateLog)]

        public void CreateLog(List<IFormFile> files, Log log)
        {
            _logService.Create(files, log);
        }




        [HttpPut]
        [Route(Endpoints.LogEndpoint.UpdateLog)]
        public void UpdateLog(List<IFormFile> files, Log log)
        {
            _logService.Update(files, log);
        }


        [HttpDelete]
        [Route(Endpoints.LogEndpoint.DeleteLog)]
        public void DeleteLog(List<IFormFile> files, Log log)
        {
            _logService.Delete(files, log);
        }
    }
}
