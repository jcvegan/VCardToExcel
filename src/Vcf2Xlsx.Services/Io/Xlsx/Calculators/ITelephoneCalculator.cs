// Jcvegan.com - Juan Vega
// Vcf2Xlsx.Services 2019
// ITelephoneCalculator.cs
// Todos los derechos reservados

using vCardLib.Collections;

namespace Vcf2Xlsx.Services.Io.Xlsx.Calculators
{
    public interface ITelephoneCalculator
    {
        int CalculatePhoneColumns(vCardCollection cards);
    }
}