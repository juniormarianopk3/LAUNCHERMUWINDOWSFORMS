using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LAUNCHERMUWINDOWSFORMS.Classes
{
     class Common
    {
        public static string rootArq = string.Empty;
        public static string subpastas = string.Empty;

        public static Int64 iSize;
        public static Int64 iRunningByteTotal;



        public static string GetHash(string Name)
        {
            if (Name == string.Empty)
                return string.Empty;

            var sha = new SHA1CryptoServiceProvider();

            string Hash = string.Empty;

            using (FileStream fileStream = File.Open(Name, FileMode.Open))
            {
                foreach (byte b in sha.ComputeHash(fileStream))
                {
                    byte[] data = File.ReadAllBytes(Name);
                    var DataCrip = sha.ComputeHash(data);
                    Hash = BitConverter.ToString(DataCrip).Replace("-", string.Empty).ToLower();
                }
            }

            return Hash;
        }

       public static bool DeleteFile(string f)
        {
            try
            {
                File.Delete(f);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

    }
}
