﻿using System.Data.Entity;
using System.Threading.Tasks;
using TemplateProject.Data.Infrastructure;
using TemplateProject.Model.Models;

namespace TemplateProject.Data.Repositories
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {
        Task<bool> IsInRoleAsync(int userId, int roleId);
    }

    internal class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Task<bool> IsInRoleAsync(int userId, int roleId)
        {
            return dbSet.AnyAsync(ur => ur.UserId == userId && ur.RoleId == roleId);
        }
    }
}
