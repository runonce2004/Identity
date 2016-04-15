using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace IdentityTemplate
{
    public class ClaimsPrincipalExtended : ClaimsPrincipal
    {
        public ClaimsPrincipalExtended(ClaimsPrincipal principal) : base(principal)
        {

        }
        public string Name
        {
            get
            {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }

        public string Country
        {
            get
            {
                return this.FindFirst(ClaimTypes.Country).Value;
            }
        }
    }
}