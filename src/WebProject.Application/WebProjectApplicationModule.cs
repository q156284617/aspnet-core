using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WebProject.Authorization;

namespace WebProject
{
    [DependsOn(
        typeof(WebProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WebProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WebProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WebProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
