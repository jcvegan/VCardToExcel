// Jcvegan.com - Juan Vega
// Vcf2Xlsx.Services 2019
// ISpreadSheetBuilder.cs
// Todos los derechos reservados

using DocumentFormat.OpenXml.Packaging;

namespace Vcf2Xlsx.Services.Io.Xlsx.Builders
{
    public interface ISpreadSheetBuilder
    {
        SpreadsheetDocument Create(string file);
    }
}