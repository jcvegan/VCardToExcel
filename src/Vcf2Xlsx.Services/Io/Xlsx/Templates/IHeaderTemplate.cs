// Jcvegan.com - Juan Vega
// Vcf2Xlsx.Services 2019
// IHeaderTemplate.cs
// Todos los derechos reservados

using DocumentFormat.OpenXml.Spreadsheet;

namespace Vcf2Xlsx.Services.Io.Xlsx.Templates
{
    public interface IHeaderTemplate
    {
        Cell AddHeader(string headerText);
    }
}