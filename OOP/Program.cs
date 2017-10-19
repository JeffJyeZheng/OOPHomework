using System;
using System.Reflection;
using Autofac;
using Autofac.Features.AttributeFilters;
using OOP.Services;

namespace OOP
{
    /// <summary>
    /// 程式 root
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// autofac 註冊
        /// </summary>
        /// <returns>Container</returns>
        private static IContainer AutofacRegister()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder
           .RegisterAssemblyTypes(Assembly.GetEntryAssembly())
           .AsImplementedInterfaces()
           .InstancePerLifetimeScope()
           .WithAttributeFiltering();

            return builder.Build();
        }

        /// <summary>
        /// 進入點
        /// </summary>
        /// <param name="args">args</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("applcation start..");

            var container = AutofacRegister();
            IApplication application = container.Resolve<IApplication>();
            application.Start();


            Console.WriteLine("applcation end..");
            Console.ReadLine();
        }
    }
}