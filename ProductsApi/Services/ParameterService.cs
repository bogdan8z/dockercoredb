using System.Linq;
using System.Threading.Tasks;
using Amazon.Extensions.NETCore.Setup;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace ProductsApi.Services
{
    internal class ParameterService
    {
        public async Task<object[]> RootParameters(string root)
        {
            using var client = new AWSOptions().CreateServiceClient<IAmazonSimpleSystemsManagement>();
            var result = await client.GetParametersByPathAsync(new GetParametersByPathRequest
            {
                Path = root,
                Recursive = true,
                WithDecryption = true
            }).ConfigureAwait(false);

            return result.Parameters.Select(pp => new
            {
                pp.Name,
                pp.Value
            }).ToArray<object>();
        }

        public async Task<string> GetParameter(string name)
        {
            var client = new AmazonSimpleSystemsManagementClient();

            var response = await client.GetParameterAsync(new GetParameterRequest()
            {
                Name = name,
                WithDecryption = true
            }).ConfigureAwait(false);
            return response.Parameter.Value;
        }
    }
}
