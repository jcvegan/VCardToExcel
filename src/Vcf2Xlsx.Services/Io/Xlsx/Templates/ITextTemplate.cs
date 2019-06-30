// Jcvegan.com - Juan Vega
// Vcf2Xlsx.Services 2019
// ITextTemplate.cs
// Todos los derechos reservados

using DocumentFormat.OpenXml.Spreadsheet;

namespace Vcf2Xlsx.Services.Io.Xlsx.Templates
{
    public interface ITextTemplate
    {
        Cell Create(string content);
    }
}