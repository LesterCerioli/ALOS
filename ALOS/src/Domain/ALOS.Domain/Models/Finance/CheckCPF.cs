using ALOS.Domain.Models.HR;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Models.Finance
{
    public class Cpfx : CPF
    {
        public static bool Check(string CpfNumber)
        {
            if (string.IsNullOrWhiteSpace(CpfNumber) || (CpfNumber.Length != 11 && CpfNumber.Length != 14))
                return false;

            // if the length is 14 (number with mask) and the mask is incorrect it's invalid
            if (CpfNumber.Length == 14 && (CpfNumber[3] != '.' || CpfNumber[7] != '.' || CpfNumber[11] != '-'))
                return false;

            // striping off the mask
            var digits = new string(CpfNumber.Where(char.IsDigit).ToArray());

            // if the number of digits is different than 11 it's invalid
            if (digits.Length != 11)
                return false;

            // getting the verifies (last two digits)
            var verifiers = digits.Substring(9, 2);

            // getting the "actual" number to be verified (first nine digits)
            var actualNumber = digits.Substring(0, 9);

            // doing a mod11 check on the 9 length number
            var verifier1 = Mod11(actualNumber);

            // if doesn't match the first verifies it's invalid
            if (verifier1 != verifiers[0])
                return false;

            // now it's a 10 length number
            actualNumber += verifier1;

            // doing a mod11 check on the 10 length number
            var verifier2 = Mod11(actualNumber);

            // at this point if matches it means that is valid
            return verifier2 == verifiers[1];
        }

        private static char Mod11(string number)
        {
            var sum = 0;
            for (int i = number.Length -1, multiplier = 2; i >= 0; --i, ++multiplier)
                sum += int.Parse(number[i].ToString(), CultureInfo.InvariantCulture) * multiplier;
            var mod11 = sum % 11;
            return mod11 < 2 ? '0' : (11 - mod11).ToString(CultureInfo.InvariantCulture)[0];
        }
    }
}
