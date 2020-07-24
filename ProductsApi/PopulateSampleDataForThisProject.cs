using System.Threading.Tasks;
using Amazon;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace ProductsApi
{
    public static class PopulateSampleDataForThisProject
    {
        public static async Task PopulateAsync()
        {
            var awsOptions = new AWSOptions
            {
                Region = RegionEndpoint.EUWest1, 
                Credentials = new BasicAWSCredentials("id", "key")
            };

            var root = $"/dotnet-aws-samples/systems-manager-sample/common";
            var parameters = new[]
            {
                new {Name = "StringValue", Value = "string-value"},
                new {Name = "IntegerValue", Value = "10"},
                new {Name = "DateTimeValue", Value = "2000-01-01"},
                new {Name = "BooleanValue", Value = "True"},
                new {Name = "TimeSpanValue", Value = "00:05:00"},
            };

            using var client = awsOptions.CreateServiceClient<IAmazonSimpleSystemsManagement>();
            var result = await client.GetParametersByPathAsync(new GetParametersByPathRequest { Path = root, Recursive = true }).ConfigureAwait(false);
            if (result.Parameters.Count == parameters.Length) return;

            foreach (var parameter in parameters)
            {
                var name = $"{root}/settings/{parameter.Name}";
                await client.PutParameterAsync(new PutParameterRequest { Name = name, Value = parameter.Value, Type = ParameterType.String, Overwrite = true }).ConfigureAwait(false);
            }
        }
    }
}
