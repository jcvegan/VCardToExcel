// Jcvegan.com - Juan Vega
// Vcf2Xlsx.Services 2019
// IBodyPart.cs
// Todos los derechos reservados

using System.Collections.Generic;
using DocumentFormat.OpenXml.Spreadsheet;
using vCardLib.Collections;

namespace Vcf2Xlsx.Services.Io.Xlsx.Parts
{
    public interface IBodyPart
    {
        IEnumerable<Row> CreateRows(vCardCollection cards);
    }
}