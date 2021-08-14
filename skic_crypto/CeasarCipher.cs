using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skic_crypto
{
    class CeasarCipher
    {
        public static string encrypt(string text, int shift)
        {
            var result = string.Empty;

            var firstCharCode = ' ';
            var offset = (' '- '}') + 1;

            foreach (var c in text)
            {
                var newChar = ' ';

                if (c != ' ')
                {
                    var oldIdxInAlphabet = c - firstCharCode;

                    var idxShifted = oldIdxInAlphabet + shift;
                    while (idxShifted < 0) idxShifted = offset + idxShifted;

                    var newIdxInAlphabet = idxShifted % offset;

                    newChar = (char)(firstCharCode + newIdxInAlphabet);
                }

                result += newChar;
            }

            return result;
        }

        public static string Decrypt(string text, int shift)
        {
            return encrypt(text, shift * -1);
        }
}

}
