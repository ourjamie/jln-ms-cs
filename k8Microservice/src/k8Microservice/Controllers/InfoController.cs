using k8Microservice.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace k8Microservice.Controllers 
{
    [ApiVersionNeutral]
    [Produces("application/json")]
    [Route("info")]
    public class InfoController : Controller
    {
        private readonly string _version;

        public InfoController(IOptions<Configuration> config)
        {
            _version = config.Value.Version;
        }

        [HttpGet]
        public object Info()
        {
            return new
            {
                Name = "k8Microservice.API",
                Version = _version,
                ApiVersion = "v1.0"
            };
        }
    }
}