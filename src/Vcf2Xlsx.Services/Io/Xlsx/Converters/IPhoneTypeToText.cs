// Jcvegan.com - Juan Vega
// Vcf2Xlsx.Services 2019
// IPhoneTypeToText.cs
// Todos los derechos reservados

using vCardLib.Models;

namespace Vcf2Xlsx.Services.Io.Xlsx.Converters
{
    public interface IPhoneTypeToText
    {
        string Convert(PhoneNumberType type);
    }
}