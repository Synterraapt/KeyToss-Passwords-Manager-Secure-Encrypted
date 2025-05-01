using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PasswordManager.Format;
using Microsoft.VisualBasic;
using PasswordManager.Components;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars.ToastNotifications;

namespace PasswordManager.Helper
{
    class MasterPasswordHelper
    {
        private readonly string filePath;
        private readonly Pbkdf2 pbkdf2 = new Pbkdf2();

        public MasterPasswordHelper()
        {
            string folderPath = ConstantsCustom.FolderPath;

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            filePath = ConstantsCustom.MasterFilePath;
        }

        public void HashPassword(string masterpassword)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            if (new FileInfo(filePath).Length == 0)
            {
                if(string.IsNullOrWhiteSpace(masterpassword))
                {
                    return;
                }

                byte[] salt = new byte[16];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }
                string saltBase64 = Convert.ToBase64String(salt);
                 
                Pbkdf2 pbkdf2 = new Pbkdf2();
                string hashed = pbkdf2.Hash(masterpassword, salt); 

                string hashCombinesSalt = $"{saltBase64}:{hashed}";

                File.AppendAllText(filePath, hashCombinesSalt);
            }
        }

        public string Login()
        {
            MessageBox.Show("PASSWORD MANAGER");
            MessageBox.Show("Please login.");
            MessageBox.Show("Enter your master password:");

            AutoLockHelper.StartAutoLock(() => Login());

            string pwInput = Console.ReadLine();
            AutoLockHelper.ResetAutoLock();

            VerifyMasterPassword(pwInput);

            return pwInput;
        }


        public bool VerifyMasterPassword(string inputPassword)
        {
            if (string.IsNullOrWhiteSpace(inputPassword))
            {
                return false;
            }
            else
            {
                if (!File.Exists(filePath))
                {
                    Environment.Exit(0);
                    return false;
                }

                string[] parts = File.ReadAllText(filePath).Split(':');

                if (parts.Length != 2)
                {
                    Environment.Exit(0);
                    return false;
                }

                string storedSalt = parts[0];
                string storedHash = parts[1];
                string storedHashCombinedSalt = $"{storedSalt}:{storedHash}";
                byte[] convertedSalt = Convert.FromBase64String(storedSalt);
                string saltBase64 = Convert.ToBase64String(convertedSalt);

                Pbkdf2 pbkdf2 = new Pbkdf2();
                string hashed = pbkdf2.Hash(inputPassword, convertedSalt);

                string hashCombinedSalt = $"{saltBase64}:{hashed}";

                if (hashCombinedSalt != storedHashCombinedSalt)
                {
                    Environment.Exit(0);
                    return false;
                } else
                {
                    return true;
                }
            }
        }
    }
}
