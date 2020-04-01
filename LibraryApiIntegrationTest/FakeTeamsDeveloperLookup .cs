using LibraryApi.Controllers;
using LibraryApi.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApiIntegrationTest
{
    public class FakeTeamsDeveloperLookup : ILookupOnCallDevelopers
    {
        public Task<OnCallDeveloperResponse> GetOnCallDeveloper()
        {
            return Task.FromResult(new OnCallDeveloperResponse { Email = "testing@test.com" });
        }
    }
}
