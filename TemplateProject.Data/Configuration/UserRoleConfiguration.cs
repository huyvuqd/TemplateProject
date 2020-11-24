using System.Data.Entity.ModelConfiguration;
using TemplateProject.Model.Models;

namespace TemplateProject.Data.Configuration
{
    internal class UserRoleConfiguration : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            ToTable("UserRoles");
            HasKey(c => new { c.UserId, c.RoleId });
        }
    }
}
