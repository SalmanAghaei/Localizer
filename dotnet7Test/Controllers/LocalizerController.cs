using Application;
using Microsoft.AspNetCore.Mvc;
using Resources.Resources;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocalizerController : ControllerBase
    {
        private readonly ServiceTest _serviceTest;
        public LocalizerController(ServiceTest serviceTest)
        {

            _serviceTest = serviceTest;
        }

        [HttpGet(Name = "GetLocalize")]
        public string Get()
        {

            return _serviceTest.GetLocaliz("City");
        }
    }
}