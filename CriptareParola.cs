using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChatterinoApp
{
    internal class CriptareParola
    {
        /* Aceasta metoda de criptare este una mai rudimentara si simpla, nu o recomand
         * a se folosi pentru aplicatii mai complexe sau de o importanta mai mare. */

        /* Cheia folosita pentru criptare. Se poate modifica. */
        static String parolaEnc = "Random Encryption Password";

        private static byte[] generareCheie(String parolaEnc) {
            /* Generez un vector de octeti criptati MD5 pe baza cheii predefinite. */
            var keyBytes = Encoding.UTF8.GetBytes(parolaEnc);
            using (var md5 = MD5.Create())
                return md5.ComputeHash(keyBytes);
        }
        public static byte[] encryptParola(String parola) {
            var cheie = generareCheie(parolaEnc);

            /* Pe baza vectorului de octeti generat mai sus, criptez parola. */
            /* AES - Advanced Encryption Standard */
            using (var aes = Aes.Create())
            using (var encryptor = aes.CreateEncryptor(cheie, cheie)) {
                var plainText = Encoding.UTF8.GetBytes(parola);
                return encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
            }
        }

        public static String decryptParola(byte[] octetiEnc) {
            var cheie = generareCheie(parolaEnc);

            /* Functia de decriptare.
             * Momentan ea nu este folosita undeva in program, poate fi implementata pentru o functionalitate
             * de tipul "Am uitat parola". */

            using (var aes = Aes.Create())
            using (var encryptor = aes.CreateDecryptor(cheie, cheie)) {
                var decryptedBytes = encryptor.TransformFinalBlock(octetiEnc, 0, octetiEnc.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}