using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Models.Finance
{
    public static partial class Cpf
    {
        public static string Format(string s)
        {
            return s == null || s.Length != 11 || s.Any(c => !char.IsDigit(c)) ? s :
                new string(new[] { s[0], s[1], s[2], '.', s[3], s[4], s[5], '.', s[6], s[7], s[8], '-', s[9], s[10], });
        }

    }
}
