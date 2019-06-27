using System.Collections.Generic;
using MixERP.Net.VCards;

namespace Vcf2Xlsx.Services.Io
{
    public interface ISpreadSheetExport
    {
        void Export(IEnumerable<VCard> cards, string filePath);
    }
}