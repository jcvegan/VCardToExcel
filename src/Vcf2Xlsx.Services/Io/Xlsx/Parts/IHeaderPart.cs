// Jcvegan.com - Juan Vega
// Vcf2Xlsx.Services 2019
// IHeaderPart.cs
// Todos los derechos reservados

using DocumentFormat.OpenXml.Spreadsheet;
using vCardLib.Collections;

namespace Vcf2Xlsx.Services.Io.Xlsx.Parts
{
    public interface IHeaderPart
    {
        Row CreateRowHeader(vCardCollection cards);
    }
}