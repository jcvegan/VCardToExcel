using System.IO;
using Vcf2Xlsx.Services.Io;

namespace Vcf2Xlsx.Processors {
    public class VcfToXlsxProcessor : IVcfToXlsxProcessor
    {
        private readonly IVCardReader _reader;
        private readonly ISpreadSheetExport _export;

        public VcfToXlsxProcessor(IVCardReader reader, ISpreadSheetExport export)
        {
            _reader = reader;
            _export = export;
        }
        public void Process(string vcfFilePath, string xlsxFilePath)
        {
            var items = _reader.Read(vcfFilePath);
            var fileName = Path.GetFileNameWithoutExtension(vcfFilePath);
            _export.Export(items, xlsxFilePath, fileName);
        }
    }
}