using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Presenters;
using WindowsFormsApp.Repositorys;
using WindowsFormsApp.Services;
using WindowsFormsApp.Views;

namespace WindowsFormsApp.Configurations
{
    public class AutofacConfigure
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CustomerForm>();

            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<CustomerXmlRepository>().As<ICustomerRepository>();
            builder.RegisterType<CustomerPresenter>().As<ICustomerPresenter>();

            return builder.Build();
        }

    }
}
