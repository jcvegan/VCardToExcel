using Microsoft.Extensions.DependencyInjection;
using Vcf2Xlsx.Services.Io;

namespace Vcf2Xlsx.Services.Extensions
{
    public static class IoExtensions
    {
        public static IServiceCollection AddFilesSupport(this IServiceCollection services)
        {
            services.AddScoped<IVCardReader, VCardReader>();
            services.AddScoped<ISpreadSheetExport, SpreadSheetExport>();
            return services;
        }
    }
}
