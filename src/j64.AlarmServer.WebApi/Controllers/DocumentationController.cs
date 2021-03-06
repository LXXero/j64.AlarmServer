using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using j64.AlarmServer.WebApi.Models;
using Microsoft.AspNet.Authorization;

namespace j64.AlarmServer.WebApi.Controllers
{
    [Authorize]
    public class DocumentationController : Controller
    {
        private AlarmSystem myAlarmSystem { get; set; }

        public DocumentationController(AlarmSystem alarmSystem)
        {
            myAlarmSystem = alarmSystem;
        }

        public IActionResult Index()
        {
            return View(new AlarmSystemInfo(myAlarmSystem));
        }
    }
}
