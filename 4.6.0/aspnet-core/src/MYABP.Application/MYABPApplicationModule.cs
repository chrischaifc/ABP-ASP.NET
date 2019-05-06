using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MYABP.Authorization;

namespace MYABP
{
    [DependsOn(
        typeof(MYABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MYABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MYABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MYABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
