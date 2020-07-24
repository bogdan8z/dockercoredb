using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SettingsController : ControllerBase
    {
        private readonly IOptions<Settings> _settings;

        public SettingsController(IOptions<Settings> settings)
        {
            _settings = settings;
        }
        
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new
            {
                Settings = _settings.Value
            });
        }
    }
}
