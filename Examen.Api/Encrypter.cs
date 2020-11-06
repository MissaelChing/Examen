using System;
using System.Text;

namespace TeamEncrypter.Api
{
    public static class Encrypter
    {
        public static void Encrypt(ref StringBuilder text, string clave)
        {
            for (int i = 0; i<text.Length; i++) text[i] = char.ToUpper(text[i]) ;
            clave = clave.ToUpper();
            int J = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    text[i] = (char)(text[i] + clave[J] - 'A');
                    if (text[i] > 'Z') text[i] = (char)(text[i] - 'Z' + 'A' - 1);
                }
                J = J + 1 == clave.Length ? 0 : J + 1;
            }

        }
    }
}
