using Microsoft.Extensions.DependencyInjection;
using Vcf2Xlsx.Services.Io;
using Vcf2Xlsx.Services.Io.Xlsx.Builders;
using Vcf2Xlsx.Services.Io.Xlsx.Calculators;
using Vcf2Xlsx.Services.Io.Xlsx.Converters;
using Vcf2Xlsx.Services.Io.Xlsx.Parts;
using Vcf2Xlsx.Services.Io.Xlsx.Templates;

namespace Vcf2Xlsx.Services.Extensions
{
    public static class IoExtensions
    {
        public static IServiceCollection AddFilesSupport(this IServiceCollection services)
        {
            services.AddScoped<IVCardReader, VCardReader>();
            services.AddScoped<ISpreadSheetBuilder, SpreadSheetBuilder>();
            services.AddScoped<IHeaderTemplate, HeaderTemplate>();
            services.AddScoped<ITextTemplate, TextTemplate>();
            services.AddScoped<IPhoneTypeToText, PhoneTypeToText>();
            services.AddScoped<ITelephoneCalculator, TelephoneCalculator>();
            services.AddScoped<IMailCalculator, MailCalculator>();

            services.AddScoped<IHeaderPart, HeaderPart>();
            services.AddScoped<IBodyPart, BodyPart>();

            services.AddScoped<ISpreadSheetExport, SpreadSheetExport>();
            return services;
        }
    }
}
