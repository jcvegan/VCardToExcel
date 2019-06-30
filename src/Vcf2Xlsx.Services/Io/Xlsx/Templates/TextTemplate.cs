using DocumentFormat.OpenXml.Spreadsheet;

namespace Vcf2Xlsx.Services.Io.Xlsx.Templates {
    public class TextTemplate : ITextTemplate {
        public Cell Create(string content)
        {
            var cell = new Cell(new InlineString(new Text(content)))
            {
                DataType = CellValues.InlineString
            };
            return cell;
        }
    }
}