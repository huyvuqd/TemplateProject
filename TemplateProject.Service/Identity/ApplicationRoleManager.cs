using Microsoft.AspNet.Identity;
using TemplateProject.Data.Identity;
using TemplateProject.Model.Models;

namespace TemplateProject.Service.Identity
{
    public class ApplicationRoleManager : RoleManager<Role, int>
    {
        public ApplicationRoleManager(IRoleStore store) : base(store)
        {
        }
    }
}
