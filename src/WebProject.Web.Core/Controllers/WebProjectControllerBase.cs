using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace WebProject.Controllers
{
    public abstract class WebProjectControllerBase: AbpController
    {
        protected WebProjectControllerBase()
        {
            LocalizationSourceName = WebProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
