using System.Collections.Generic;
using System.Linq;
using vCardLib;
using vCardLib.Collections;

namespace Vcf2Xlsx.Services.Io.Xlsx.Calculators {
    public class TelephoneCalculator : ITelephoneCalculator {
        public int CalculatePhoneColumns(vCardCollection cards)
        {
            List<int> numbersPerRecord = new List<int>();
            foreach (vCard card in cards)
            {
                numbersPerRecord.Add(card.PhoneNumbers.Count);
            }
            return numbersPerRecord.Max();
        }
    }
}