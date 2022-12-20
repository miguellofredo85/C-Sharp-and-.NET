using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; // Import for crypt
using System.Windows.Forms;

namespace HashMD5
{
    internal class CryptoMD5
    {
        public string MD5Return (string pass)
        {
            using (MD5 md5Hash = MD5.Create())
            { 
                return HashReturn(md5Hash, pass);
            }
        }
        private string HashReturn(MD5 md5hash, string input) // create hash md5 from an input string
        {
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input)); // array of byte from our string
            StringBuilder stringBuilder = new StringBuilder();
        
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("X2")); //transform array of bytes to hexadecimal string in uppercase
            }
            return stringBuilder.ToString();
        
        }
        public bool CompareMD5(string inPass, string md5Pass)
        {
            string pass = MD5Return(inPass);
                { 
                if (HashVerified(md5Pass, pass))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // comparate algoritm

        private bool HashVerified(string input, string hash)
        {
            StringComparer compare = StringComparer.OrdinalIgnoreCase;
            if(compare.Compare(input, hash) == 0) // 0 is equal 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
