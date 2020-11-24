using System.Data.Entity.ModelConfiguration;
using TemplateProject.Model.Models;

namespace TemplateProject.Data.Configuration
{
    internal class UserClaimConfiguration : EntityTypeConfiguration<UserClaim>
    {
        public UserClaimConfiguration()
        {
            ToTable("UserClaims");
        }
    }
}
