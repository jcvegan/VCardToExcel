using System.Collections.Generic;
using System.Linq;
using vCardLib;
using vCardLib.Collections;

namespace Vcf2Xlsx.Services.Io.Xlsx.Calculators {
    public class MailCalculator : IMailCalculator {
        public int CalculateMailColumns(vCardCollection cards)
        {
            List<int> numbersPerRecord = new List<int>();
            foreach (vCard card in cards)
            {
                numbersPerRecord.Add(card.EmailAddresses.Count);
            }
            return numbersPerRecord.Max();
        }
    }
}