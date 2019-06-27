using Vcf2Xlsx.Services.Io;

namespace Vcf2Xlsx.Processors
{
    public interface IVcfToXlsxProcessor
    {
        void Process(string vcfFilePath, string xlsxFilePath);
    }

    public class VcfToXlsxProcessor : IVcfToXlsxProcessor
    {
        private readonly IVCardReader _reader;
        private readonly ISpreadSheetExport _export;

        public VcfToXlsxProcessor(IVCardReader reader,ISpreadSheetExport export)
        {
            _reader = reader;
            _export = export;
        }
        public void Process(string vcfFilePath, string xlsxFilePath)
        {
            var items = _reader.Read(vcfFilePath);
            _export.Export(items,xlsxFilePath);
        }
    }
}