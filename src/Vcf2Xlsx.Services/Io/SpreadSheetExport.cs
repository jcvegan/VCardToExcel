using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using vCardLib.Collections;
using Vcf2Xlsx.Services.Io.Xlsx.Parts;

namespace Vcf2Xlsx.Services.Io
{
    public class SpreadSheetExport : ISpreadSheetExport
    {
        private readonly IHeaderPart _headerPart;
        private readonly IBodyPart _bodyPart;

        public SpreadSheetExport(IHeaderPart headerPart,IBodyPart bodyPart)
        {
            _headerPart = headerPart;
            _bodyPart = bodyPart;
        }

        public void Export(vCardCollection cards, string filePath, string fileName)
        {
            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.
                Create(filePath, SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            var sheetData = new SheetData();
            worksheetPart.Worksheet = new Worksheet(sheetData);

            // Add Sheets to the Workbook.
            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.
                AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.
                GetIdOfPart(worksheetPart), SheetId = 1, Name = fileName };
            sheets.Append(sheet);

            sheetData.AppendChild(_headerPart.CreateRowHeader(cards));

            var body = _bodyPart.CreateRows(cards);

            foreach (var row in body)
            {
                sheetData.AppendChild(row);
            }

            workbookpart.Workbook.Save();

            // Close the document.
            spreadsheetDocument.Close();
        }
    }
}