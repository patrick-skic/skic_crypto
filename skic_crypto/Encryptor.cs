using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skic_crypto
{
    class Encryptor
    {
        public static string IV = "1a1a1a1a1a1a1a1a";
        public static string Key = "1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a13";

        public static string Encrypt(string decrypted)
        {
            byte[] textBytes = ASCIIEncoding.ASCII.GetBytes(decrypted);
            AesCryptoServiceProvider endec = new AesCryptoServiceProvider(); ;
            endec.BlockSize = 128;
            endec.KeySize = 256;
            endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            endec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            endec.Padding = PaddingMode.PKCS7;
            endec.Mode = CipherMode.CBC;
            ICryptoTransform icrypt = endec.CreateEncryptor(endec.Key, endec.IV);
            byte[] enc = icrypt.TransformFinalBlock(textBytes, 0, textBytes.Length);
            icrypt.Dispose();
            return Convert.ToBase64String(enc);
        }

        public static string Decrypted(string encrypted)
        {
            var check = Form1.verify;
            string password = Form1.password;

            if (check == password)
            {
                byte[] textbytes = Convert.FromBase64String(encrypted);
                AesCryptoServiceProvider endec = new AesCryptoServiceProvider();
                endec.BlockSize = 128;
                endec.KeySize = 256;
                endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                endec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
                endec.Padding = PaddingMode.PKCS7;
                endec.Mode = CipherMode.CBC;
                ICryptoTransform icrypt = endec.CreateDecryptor(endec.Key, endec.IV);
                byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
                icrypt.Dispose();



                if (Form1.verify == password)
                {
                    return System.Text.ASCIIEncoding.ASCII.GetString(enc);

                }
                else if (Form1.verify != password)
                {
                    MessageBox.Show("Please use the original key file.");
                }
            }
            return encrypted;
        }
    }
}

  
