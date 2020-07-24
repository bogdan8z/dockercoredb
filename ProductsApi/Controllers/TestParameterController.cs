using System.Linq;
using System.Threading.Tasks;
using Amazon.Extensions.NETCore.Setup;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Services;

namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestParameterController : ControllerBase
    {
        [HttpGet("1")]
        public async Task<ActionResult> GetOneParameter()
        {
            return Ok(await new ParameterService().GetParameter("/dotnet-aws-samples/systems-manager-sample/common/settings/StringValue"));
        }

        [HttpGet("2")]
        public async Task<ActionResult> GetMultipleParameters()
        {
            return Ok(await new ParameterService().RootParameters("/prod/test-aws/databases/products-api"));
        }
    }
}
