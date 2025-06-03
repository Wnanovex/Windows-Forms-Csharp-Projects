using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Password_and_Key_Generator
{
    class PasswordKeyGenerator {
        public enum enCharType {SmallLetter = 1, CapitalLetter = 2, Digit = 3, SpecialCharacter = 4, MixChars = 5 };

        private static Random rng = new Random();

        private static int RandomNumbers(int From, int To) {
            return rng.Next(From, To + 1);
        }

        public static char GetRandomCharacter(enCharType CharType) {
            switch (CharType) {
                case enCharType.SmallLetter:
                    return (char)(RandomNumbers(97, 122));
                case enCharType.CapitalLetter:
                    return (char)(RandomNumbers(65, 90));
                case enCharType.Digit:
                    return (char)(RandomNumbers(48, 57));
                case enCharType.SpecialCharacter:
                    return (char)(RandomNumbers(33, 47));
                case enCharType.MixChars:
                    return GetRandomCharacter((enCharType)RandomNumbers(1, 4));
            }
            return '\0';
        }

        public static string GenerateWord(enCharType CharType, short Length) {
            string Word = "";
            for (int i = 1; i <= Length; i++)
                Word += GetRandomCharacter(CharType);
            return Word;
        }

        public static string GenerateKey(enCharType CharType = enCharType.CapitalLetter, short WordLength = 4) {
            string Key = "";
            for (int i = 1; i <= 4; i++) {
                Key += GenerateWord(CharType, WordLength) + "-";
            }
            return Key.Substring(0, Key.Length - 1);
        }

        public static string GenerateKeys(short NumberOfKeys, enCharType CharType) {
            string Keys = "";
            for (int i = 1; i <= NumberOfKeys; i++)
                Keys += "Key[" + i + "] : " + GenerateKey(CharType) + Environment.NewLine;
            return Keys;
        }

        public static string GeneratePassword(enCharType CharType, short Length) {
            string Word = "";
            for (int i = 1; i <= Length; i++)
                Word += GetRandomCharacter(CharType);
            return Word;
        }

        public static string GeneratePassword(enCharType CharType1, enCharType CharType2, short Length) {
            string Word = "";
            short m = 0;
            for (int i = 1; i <= Length; i++) {
                m = (short) RandomNumbers(1, 2);
                switch (m) {
                    case 1:
                        Word += GetRandomCharacter(CharType1);
                        break;
                    case 2:
                        Word += GetRandomCharacter(CharType2);
                        break;
                }
            }
            return Word;
        }

        public static string GeneratePassword(enCharType CharType1, enCharType CharType2, enCharType CharType3, short Length) {
            string Word = "";
            short m = 0;
            for (int i = 1; i <= Length; i++) {
                m = (short)RandomNumbers(1, 3);
                switch (m) {
                    case 1:
                        Word += GetRandomCharacter(CharType1);
                        break;
                    case 2:
                        Word += GetRandomCharacter(CharType2);
                        break;
                    case 3:
                        Word += GetRandomCharacter(CharType3);
                        break;
                }
            }
            return Word;
        }

    }
}
