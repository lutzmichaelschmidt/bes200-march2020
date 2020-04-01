﻿using LibraryApi.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
   
        public class OnCallDeveloperController : Controller
        {
            ILookupOnCallDevelopers OnCallLookup;
            public OnCallDeveloperController(ILookupOnCallDevelopers onCallLookup)
            {
                OnCallLookup = onCallLookup;
            }
            [HttpGet("oncalldeveloper")]
            public async Task<ActionResult<OnCallDeveloperResponse>> GetOnCallDeveloper()
            {
                // WTCYWYH (Write the code you wish you had)
                OnCallDeveloperResponse response = await OnCallLookup.GetOnCallDeveloper();
                return Ok(response);
            }
        }

}
