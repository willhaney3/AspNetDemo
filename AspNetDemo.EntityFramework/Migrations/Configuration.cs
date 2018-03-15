using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using AspNetDemo.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace AspNetDemo.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<AspNetDemo.EntityFramework.AspNetDemoDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AspNetDemo";
        }

        protected override void Seed(AspNetDemo.EntityFramework.AspNetDemoDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
