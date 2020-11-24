using TemplateProject.Model.Models;
using System.Data.Entity.Migrations;
using System.Linq;

namespace TemplateProject.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EF.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TemplateProject.Data.EF.ApplicationContext";
        }

        protected override void Seed(EF.ApplicationContext context)
        {
            if (!context.Roles.Any())
            {
                context.Roles.Add(new Role { Name = "manager" });
                context.Roles.Add(new Role { Name = "admin" });
            }
        }
    }
}
