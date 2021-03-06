﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Api
{
    public class DesenC
    {
        public static void DESCIFRAR(ref StringBuilder Mensaje, string Key)
        {
            string spanishAlphabet = "AÁBCDEÉFGHIÍJKLMNÑOÓPQRSTUÚÜVWXYZ";

            for (int i = 0; i < Mensaje.Length; i++) Mensaje[i] = Char.ToUpper(Mensaje[i]);
            Key = Key.ToUpper();
            int j = 0;
            for (int i = 0; i < Mensaje.Length; i++)
            {
                if (spanishAlphabet.Contains(Mensaje[i]))
                {
                    Mensaje[i] = spanishAlphabet[(spanishAlphabet.IndexOf(Mensaje[i]) - spanishAlphabet.IndexOf(Key[j]) + spanishAlphabet.Length) % spanishAlphabet.Length];
                    j = (j + 1) % Key.Length;
                }
            }
        }
        public static void DESCIFRARIngles(ref StringBuilder Mensaje, string Key)
        {
            string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < Mensaje.Length; i++) Mensaje[i] = Char.ToUpper(Mensaje[i]);
            Key = Key.ToUpper();
            int j = 0;
            for (int i = 0; i < Mensaje.Length; i++)
            {
                if (englishAlphabet.Contains(Mensaje[i]))
                {
                    Mensaje[i] = englishAlphabet[(englishAlphabet.IndexOf(Mensaje[i]) - englishAlphabet.IndexOf(Key[j]) + englishAlphabet.Length) % englishAlphabet.Length];
                    j = (j + 1) % Key.Length;
                }
            }
        }
    }
}
