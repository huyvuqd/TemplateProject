using System.Data.Entity.ModelConfiguration;
using TemplateProject.Model.Models;

namespace TemplateProject.Data.Configuration
{
    internal class UserLoginConfiguration : EntityTypeConfiguration<UserLogin>
    {
        public UserLoginConfiguration()
        {
            ToTable("UserLogins");
            HasKey(c => new
            {
                c.LoginProvider, c.ProviderKey, c.UserId
            });
        }
    }
}
