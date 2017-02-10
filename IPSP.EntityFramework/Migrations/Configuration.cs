using System.Data.Entity.Migrations;

namespace IPSP.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<IPSP.EntityFramework.IPSPDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "IPSP";
        }

        protected override void Seed(IPSP.EntityFramework.IPSPDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            var client = new Contact.Client.Client { s_Name = "ABC" };
            context.Clients.AddOrUpdate(client);
            context.BaseCases.AddOrUpdate(new Case.BaseCase { s_CaseName = "Case1", s_CaseSerial = "AAA1", TheClient = client });
            context.BaseCases.AddOrUpdate(new Case.BaseCase { s_CaseName = "Case2", s_CaseSerial = "AAA2", TheClient = client });
            context.SaveChanges();
        }
    }
}
