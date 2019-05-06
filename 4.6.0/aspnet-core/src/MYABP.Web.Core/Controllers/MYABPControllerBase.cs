using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MYABP.Controllers
{
    public abstract class MYABPControllerBase: AbpController
    {
        protected MYABPControllerBase()
        {
            LocalizationSourceName = MYABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
