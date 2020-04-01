using LibraryApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    public interface ILookupOnCallDevelopers
    {
        Task<OnCallDeveloperResponse> GetOnCallDeveloper();
    }
}
