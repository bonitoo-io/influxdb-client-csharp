using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using InfluxDB.Client.Api.Domain;
using InfluxDB.Client.Core.Test;
using NUnit.Framework;
using Task = System.Threading.Tasks.Task;

namespace InfluxDB.Client.Test
{
    public class AbstractItClientTest : AbstractTest
    {
        protected InfluxDBClient Client;
        protected string InfluxDbUrl;

        [SetUp]
        public new void SetUp()
        {
            InfluxDbUrl = GetInfluxDb2Url();

            if (!TestContext.CurrentContext.Test.Properties.ContainsKey("basic_auth"))
            {
                Client = InfluxDBClientFactory.Create(InfluxDbUrl, "my-token".ToCharArray());
            }
            else
            {
                Client = InfluxDBClientFactory.Create(InfluxDbUrl, "my-user", "my-password".ToCharArray());
            }
        }

        [TearDown]
        protected void After()
        {
            Client.Dispose();
        }

        public static string GenerateName(string prefix)
        {
            Assert.IsNotEmpty(prefix);

            return prefix + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff",
                       CultureInfo.InvariantCulture) + "-IT";
        }

        protected async Task<Organization> FindMyOrg()
        {
            return (await Client.GetOrganizationsApi().FindOrganizationsAsync())
                .First(organization => organization.Name.Equals("my-org"));
        }
    }
}