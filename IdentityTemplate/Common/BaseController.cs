using IdentityTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace IdentityTemplate
{
    public class BaseController : Controller
    {
        public ClaimsPrincipalExtended CurrentUser
        {
            get
            {
                return new ClaimsPrincipalExtended(this.User as ClaimsPrincipal);
            }
        }
    }
}