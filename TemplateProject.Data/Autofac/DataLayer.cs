﻿using Autofac;
using TemplateProject.Data.Identity;
using TemplateProject.Data.Infrastructure;

namespace TemplateProject.Data.Autofac
{
    public class DataLayer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<UserStore>().As<IUserStore>().InstancePerRequest();
            builder.RegisterType<RoleStore>().As<IRoleStore>().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(DataLayer).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
        }
    }
}
