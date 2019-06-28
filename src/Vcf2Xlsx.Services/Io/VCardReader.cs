using vCardLib.Collections;
using vCardLib.Deserializers;

namespace Vcf2Xlsx.Services.Io
{
    public class VCardReader : IVCardReader
    {
        public vCardCollection Read(string filePath)
        {
            //var contents = File.ReadAllText(filePath);
            //var vCardArray = Regex.Split(contents, @"(BEGIN:VCARD.*?END:VCARD)", RegexOptions.Singleline);

            //List<string> cleanedCards = new List<string>();
            //foreach (var text in vCardArray)
            //{
            //    if (!String.IsNullOrWhiteSpace(text))
            //    {
            //        cleanedCards.Add(text);
            //    }
            //}
            //var vCards = cleanedCards.Select(x => Deserializer.GetVCard(x));
            //return vCards;
            vCardCollection contacts = Deserializer.FromFile(filePath);
            return contacts;
        }
    }
}