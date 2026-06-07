using System.Security.Cryptography;
using System.Text;

namespace DISCPrinting.Domain.Utils;

public static class Helper
{
    public static class ConstantKey
    {
        public const string ASSEMBLY_PREFIX = "DISCPrinting";
    }

    private const string EncryptKey = "e3427059-4745-475a-897f-630787ed8fb6";
    public static string Encrypt(string source)
    {
        using (TripleDES tripleDESCryptoService = TripleDES.Create())
        {
            using (MD5 hashMD5Provider = MD5.Create())
            {
                byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(EncryptKey));
                tripleDESCryptoService.Key = byteHash;
                tripleDESCryptoService.Mode = CipherMode.ECB;
                byte[] data = Encoding.UTF8.GetBytes(source);
                return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
            }
        }
    }

    public static string Decrypt(string encrypt)
    {
        using (TripleDES tripleDESCryptoService = TripleDES.Create())
        {
            using (MD5 hashMD5Provider = MD5.Create())
            {
                byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(EncryptKey));
                tripleDESCryptoService.Key = byteHash;
                tripleDESCryptoService.Mode = CipherMode.ECB;
                byte[] data = Convert.FromBase64String(encrypt);
                return Encoding.UTF8.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));
            }
        }
    }

    public static char ConvertMonthToChar(int month)
    {
        return (char)('A' + month);
    }
}
