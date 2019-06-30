// Jcvegan.com - Juan Vega
// Vcf2Xlsx.Services 2019
// IMailCalculator.cs
// Todos los derechos reservados

using vCardLib.Collections;

namespace Vcf2Xlsx.Services.Io.Xlsx.Calculators
{
    public interface IMailCalculator
    {
        int CalculateMailColumns(vCardCollection cards);
    }
}