using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Quadrate.Authorization;

namespace Quadrate
{
    [DependsOn(
        typeof(QuadrateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QuadrateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QuadrateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QuadrateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
