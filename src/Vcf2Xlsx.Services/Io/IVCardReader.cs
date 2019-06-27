using System.Collections.Generic;
using MixERP.Net.VCards;

namespace Vcf2Xlsx.Services.Io
{
    public interface IVCardReader
    {
        IEnumerable<VCard> Read(string filePath);
    }
}