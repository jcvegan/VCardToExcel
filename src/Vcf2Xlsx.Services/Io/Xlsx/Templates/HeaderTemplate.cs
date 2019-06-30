using DocumentFormat.OpenXml.Spreadsheet;

namespace Vcf2Xlsx.Services.Io.Xlsx.Templates {
    public class HeaderTemplate : IHeaderTemplate {
        public Cell AddHeader(string headerText)
        {
            var headerCell = new Cell(new InlineString(new Text(headerText)))
            {
                DataType = CellValues.InlineString
            };
            return headerCell;
        }
    }
}