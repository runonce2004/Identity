using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace IdentityTemplate
{
    public abstract class BaseWebViewPage<TModel> : WebViewPage<TModel>
    {
        protected ClaimsPrincipalExtended CurrentUser
        {
            get
            {
                return new ClaimsPrincipalExtended(this.User as ClaimsPrincipal);
            }
        }
    }

    public abstract class BaseWebViewPage : BaseWebViewPage<dynamic>
    {

    }
}

