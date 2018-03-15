using System.Linq;
using AspNetDemo.EntityFramework;
using AspNetDemo.MultiTenancy;

namespace AspNetDemo.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AspNetDemoDbContext _context;

        public DefaultTenantCreator(AspNetDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
