using vCardLib.Models;

namespace Vcf2Xlsx.Services.Io.Xlsx.Converters {
    public class PhoneTypeToText : IPhoneTypeToText {
        public string Convert(PhoneNumberType type)
        {
            var text = string.Empty;
            switch (type)
            {
                case PhoneNumberType.Work:
                    text = "Teléfono de trabajo";
                    break;
                default:
                    text = "Teléfono";
                    break;
            }
            return text;
        }
    }
}