using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace USB_Policy
{
    static class CommonMethods
    {

        public static string MD5Hash(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes( str );
            data = md5.ComputeHash(data);
            string md5Hash = System.Text.Encoding.ASCII.GetString(data);
            return md5Hash;
        }

        public static bool ConfirmPwd(string pwd)
        {
            string storedPwd, encryptedPwd;
            try
            {
                StreamReader fsPwdFile =
                            new StreamReader(
                                new FileStream(
                                    Program.strPwdFilePath, 
                                    FileMode.Open, 
                                    FileAccess.Read));
                storedPwd = fsPwdFile.ReadToEnd();
                fsPwdFile.Close();
            }
            catch
            { return false; 
            }

            encryptedPwd = MD5Hash(pwd);

            if (storedPwd != encryptedPwd)
                return false;

            return true;
        }
    }
}