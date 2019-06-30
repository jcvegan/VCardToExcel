namespace Vcf2Xlsx.Processors
{
    public interface IVcfToXlsxProcessor
    {
        void Process(string vcfFilePath, string xlsxFilePath);
    }
}