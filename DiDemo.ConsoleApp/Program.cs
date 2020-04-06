using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DiDemo.Lib;
using DiDemo.Lib.Data;

namespace DiDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalendarServiceNoDependencyInjection service1 = new CalendarServiceNoDependencyInjection();
            Console.WriteLine($"Is Leap Year: {service1.IsLeapYear()}");
            Console.WriteLine(service1.GetData());





            // Console.WriteLine();
            // OtherDataServiceConfiguration config2 = new OtherDataServiceConfiguration("no IoC");
            // IDataFetchService fetch2 = new OtherDataFetchService(config2);
            // CalendarServiceDependencyInjection service2 = new CalendarServiceDependencyInjection(fetch2);
            // Console.WriteLine($"Is Leap Year: {service2.IsLeapYear(new DateTime(2021, 1, 1))}");
            // Console.WriteLine(service2.GetData());




            // Console.WriteLine();
            // using (var container = new WindsorContainer())
            // {
            //     container.Register(Component.For<SqlDataServiceConfiguration>()
            //                                 .Instance(new SqlDataServiceConfiguration("server using IoC")));
            //     container.Register(Component.For<OtherDataServiceConfiguration>()
            //                                 .Instance(new OtherDataServiceConfiguration("using IoC")));
            //     container.Register(Component.For<IDataFetchService>()
            //                                 .ImplementedBy<OtherDataFetchService>()
            //                                 .LifestyleTransient());
            //     container.Register(Component.For<CalendarServiceDependencyInjection>()
            //                                 .LifestyleTransient());

            //     CalendarServiceDependencyInjection service3 = container.Resolve<CalendarServiceDependencyInjection>();
            //     Console.WriteLine($"Is Leap Year: {service3.IsLeapYear(DateTime.Now)}");
            //     Console.WriteLine(service3.GetData());
            // }
        }
    }
}
