using System;
using Microsoft.Extensions.DependencyInjection;
using Vcf2Xlsx.Processors;
using Vcf2Xlsx.Services.Extensions;

namespace Vcf2Xlsx
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = BuildServices();
            var processor = serviceProvider.GetRequiredService<IVcfToXlsxProcessor>();
            processor.Process(args[0], args[1]);
        }

        private static IServiceProvider BuildServices()
        {
            var services = new ServiceCollection();
            services.AddFilesSupport();
            services.AddScoped<IVcfToXlsxProcessor, VcfToXlsxProcessor>();
            return services.BuildServiceProvider();
        }
    }
}
