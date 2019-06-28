using vCardLib.Collections;

namespace Vcf2Xlsx.Services.Io
{
    public interface IVCardReader
    {
        vCardCollection Read(string filePath);
    }
}