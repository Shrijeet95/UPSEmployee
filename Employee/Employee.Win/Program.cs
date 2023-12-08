using Employee.Win.Forms;
using Employee.Win.Services.Base;
using Employee.Win.Services.Employee;
using Employee.Win.Services.Employee.Interface;
using Employee.Win.Utility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee.Win
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IConfiguration Configuration; 
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddTransient<EmployeeListForm>();
            services.AddTransient<Employee.Win.Forms.EmployeeForm>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.Configure<EmployeeConfig>(Configuration.GetSection("Employee"));
            services.AddScoped<IBaseService, BaseService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            using ServiceProvider serviceProvider= services.BuildServiceProvider();
            //var employeeList = serviceProvider.GetRequiredService<Employee.Win.Forms.Employee>();
            var employeeList = serviceProvider.GetRequiredService<EmployeeListForm>();
            //using ServiceProvider serviceProvider= services.BuildServiceProvider();

            Application.Run(employeeList);
            
            //Application.Run(new Form1());
        }
    }
}
