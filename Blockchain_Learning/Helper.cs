using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace Blockchain_Learning
{
    public class Helper
    {
        #region Public methods
        public static string GetSha256Hash(object obj)
        {
            var sha256 = new SHA256Managed();
            var hashBuilder = new StringBuilder();

            //zmiana obiektu na tablice bajtów
            byte[] bytes = ObjectToByteArray(obj);
            //obliczanie hasza
            byte[] hash = sha256.ComputeHash(bytes);

            //konwersja tab bajtów na łańcóch znaków hexadecymalnych
            foreach (byte x in hash)
            {
                hashBuilder.Append($"{x:x2}");
            }
            return hashBuilder.ToString();
        }
        #endregion

        #region Private methods
        private static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }
        #endregion
    }
}
