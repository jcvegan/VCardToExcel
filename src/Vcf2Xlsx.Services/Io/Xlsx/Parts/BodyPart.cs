using System.Collections.Generic;
using DocumentFormat.OpenXml.Spreadsheet;
using vCardLib;
using vCardLib.Collections;
using vCardLib.Models;
using Vcf2Xlsx.Services.Io.Xlsx.Converters;
using Vcf2Xlsx.Services.Io.Xlsx.Templates;

namespace Vcf2Xlsx.Services.Io.Xlsx.Parts {
    public class BodyPart : IBodyPart {
        private readonly ITextTemplate _textTemplate;
        private readonly IPhoneTypeToText _phoneTypeToText;

        public BodyPart(ITextTemplate textTemplate,IPhoneTypeToText phoneTypeToText)
        {
            _textTemplate = textTemplate;
            _phoneTypeToText = phoneTypeToText;
        }

        public IEnumerable<Row> CreateRows(vCardCollection cards)
        {
            List<Row> rows = new List<Row>(cards.Count);

            foreach (vCard card in cards)
            {
                Row row = new Row();

                row.AppendChild(_textTemplate.Create(card.GivenName));
                row.AppendChild(_textTemplate.Create(card.FamilyName));
                row.AppendChild(_textTemplate.Create(card.FormattedName));

                foreach (PhoneNumber phoneNumber in card.PhoneNumbers)
                {
                    row.AppendChild(_textTemplate.Create(_phoneTypeToText.Convert(phoneNumber.Type)));
                    row.AppendChild(_textTemplate.Create(phoneNumber.Number));
                }

                foreach (EmailAddress emailAddress in card.EmailAddresses)
                {
                    row.AppendChild(_textTemplate.Create(emailAddress.Email.Address));
                }

                rows.Add(row);
            }

            return rows;
        }
    }
}