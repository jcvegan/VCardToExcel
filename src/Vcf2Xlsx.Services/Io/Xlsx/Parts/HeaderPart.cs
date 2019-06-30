using DocumentFormat.OpenXml.Spreadsheet;
using vCardLib.Collections;
using Vcf2Xlsx.Services.Io.Xlsx.Calculators;
using Vcf2Xlsx.Services.Io.Xlsx.Templates;

namespace Vcf2Xlsx.Services.Io.Xlsx.Parts {
    public class HeaderPart : IHeaderPart {
        private readonly IHeaderTemplate _headerTemplate;
        private readonly ITelephoneCalculator _telephoneCalculator;
        private readonly IMailCalculator _mailCalculator;

        public HeaderPart(IHeaderTemplate headerTemplate, ITelephoneCalculator telephoneCalculator, IMailCalculator mailCalculator)
        {
            _headerTemplate = headerTemplate;
            _telephoneCalculator = telephoneCalculator;
            _mailCalculator = mailCalculator;
        }

        public Row CreateRowHeader(vCardCollection cards)
        {
            var headerRow = new Row();

            headerRow.AppendChild(_headerTemplate.AddHeader("Nombres"));
            headerRow.AppendChild(_headerTemplate.AddHeader("Apellidos"));
            headerRow.AppendChild(_headerTemplate.AddHeader("Nombre Completo"));
            var telephones = _telephoneCalculator.CalculatePhoneColumns(cards);
            for (int i = 0; i < telephones; i++)
            {
                headerRow.AppendChild(_headerTemplate.AddHeader($"Tipo Teléfono {i + 1}"));
                headerRow.AppendChild(_headerTemplate.AddHeader($"Número Teléfono {i + 1}"));
            }

            var emails = _mailCalculator.CalculateMailColumns(cards);
            for (int i = 0; i < emails; i++)
            {
                headerRow.AppendChild(_headerTemplate.AddHeader($"Correo Electrónico {i + 1}"));
            }

            return headerRow;
        }
    }
}