using ASPNETCoreBlazorWithServerCalls.Codes;
using Forge.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreBlazorWithServerCalls.Data
{

    public class SesameServiceTestCalls
    {

        private static ILog LOGGER = LogManager.GetLogger(typeof(SesameServiceTestCalls));

        public Task<KeyAndValueItem[]> GetDatabasesAsync()
        {
            using (ComProxy proxy = new ComProxy())
            {
                // query database(s)
                return Task.FromResult(proxy.GetDatabases().Items.ToArray());
            }
        }

        public Task<SPDatabaseDetailsResponse> GetDatabaseDetailsAsync(string databaseId)
        {
            using (ComProxy proxy = new ComProxy())
            {
                return Task.FromResult(proxy.GetDatabaseDetails(new SPDatabaseDetailsRequest() { DatabaseId = databaseId }));
            }
        }

    }

}
