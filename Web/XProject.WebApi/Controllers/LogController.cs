

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [Route(Endpoints.LogEndpoint.Getlog)]
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



        [HttpPost]
        [Route(Endpoints.LogEndpoint.UpdateLog)]
        public void UpdateLog(Log log, string id)
        {

            _logService.UpdateLog(log, id);

        }


        [HttpDelete]
        [Route(Endpoints.LogEndpoint.DeleteLog)]
        public void DeleteLog(Log log, string id)
        {
            _logService.Delete(log, id);
        }
    }
}
