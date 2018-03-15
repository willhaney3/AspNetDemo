using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using AspNetDemo.EntityFramework;

namespace AspNetDemo.Migrator
{
    [DependsOn(typeof(AspNetDemoDataModule))]
    public class AspNetDemoMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AspNetDemoDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}