using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skic_crypto
{
    class ceasar
    {
         public static string encrypt(string text, int key)
            {
                string result = " ";
               
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].CompareTo(' ') != 0)
                {
                    if (char.IsUpper(text[i]))
                    {

                        result += Convert.ToChar(Convert.ToInt32(text[i] + key - 255) % 255 + 255);

                    }
                    else
                    {
                        result += Convert.ToChar(Convert.ToInt32(text[i] + key - 255) % 255 + 255);
                    }

                }
            }
                return result;
            }
        public static string decrypt(string text, int key)
        {
            string result = " ";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].CompareTo(' ')!=0)
                {
                    if (char.IsUpper(text[i]))
                    {

                        result += Convert.ToChar(Convert.ToInt32(text[i] - key -255 ) % 255 + 255);

                    }
                    else
                    {
                        result += Convert.ToChar(Convert.ToInt32(text[i] - key - 255) % 255 + 255);
                    }
                }
                

            }
            return result;
        }
    }
}
