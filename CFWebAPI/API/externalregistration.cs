using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CFWebAPI.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class externalregistration : ControllerBase
    {
        public externalregistration() { }
        [HttpGet]
        [Route("details")]
        public async Task<String> DetailsAsync([FromQuery] string name)
        {
            return name;
        }
    }
}
