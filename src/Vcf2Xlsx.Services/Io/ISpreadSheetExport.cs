using vCardLib.Collections;

namespace Vcf2Xlsx.Services.Io
{
    public interface ISpreadSheetExport
    {
        void Export(vCardCollection cards, string filePath);
    }
}