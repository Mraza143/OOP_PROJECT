using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using System.Drawing;
using System.IO;

namespace MOVIEFLIX_OOP
{
    public static class Utilities
    {
        public static string md5_generator(string plaintext)
        {
            Encoder enc = System.Text.Encoding.Unicode.GetEncoder();
            byte[] convertedText = new byte[plaintext.Length * 2];
            enc.GetBytes(plaintext.ToCharArray(), 0, plaintext.Length, convertedText, 0, true);

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textHash = md5.ComputeHash(convertedText);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < plaintext.Length; i++)
            {
                sb.Append(textHash[i].ToString("X2"));

            }
                return sb.ToString();
        }

        public static Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        public static byte[] ImageToBytes(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imgBytes = ms.ToArray();
                return imgBytes;
            }

        }

    }
}
