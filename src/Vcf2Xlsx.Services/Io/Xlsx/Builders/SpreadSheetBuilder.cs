using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Vcf2Xlsx.Services.Io.Xlsx.Builders {
    public class SpreadSheetBuilder : ISpreadSheetBuilder
    {
        public SpreadsheetDocument Create(string file)
        {
            SpreadsheetDocument document = SpreadsheetDocument.Create(file, SpreadsheetDocumentType.Workbook);

            var workbokPart = document.AddWorkbookPart();

            workbokPart.Workbook = new Workbook();

            return document;
        }
    }
}