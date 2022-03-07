using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Quadrate.EntityFrameworkCore;
using Quadrate.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Quadrate.Web.Tests
{
    [DependsOn(
        typeof(QuadrateWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class QuadrateWebTestModule : AbpModule
    {
        public QuadrateWebTestModule(QuadrateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuadrateWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(QuadrateWebMvcModule).Assembly);
        }
    }
}