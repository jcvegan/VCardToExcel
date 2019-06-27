using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using MixERP.Net.VCards;

namespace Vcf2Xlsx.Services.Io
{
    public class VCardReader : IVCardReader
    {
        public IEnumerable<VCard> Read(string filePath)
        {
            var contents = File.ReadAllText(filePath);
            var vCardArray = Regex.Split(contents, @"(BEGIN:VCARD.*?END:VCARD)", RegexOptions.Singleline);

            List<string> cleanedCards = new List<string>();
            foreach (var text in vCardArray)
            {
                if (!String.IsNullOrWhiteSpace(text))
                {
                    cleanedCards.Add(text);
                }
            }
            var vCards = cleanedCards.Select(x => Deserializer.GetVCard(x));
            return vCards;
        }
    }
}