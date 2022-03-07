using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Quadrate.Controllers
{
    public abstract class QuadrateControllerBase: AbpController
    {
        protected QuadrateControllerBase()
        {
            LocalizationSourceName = QuadrateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
