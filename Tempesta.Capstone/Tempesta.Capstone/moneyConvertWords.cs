using System;
using System.Collections.Generic;
using System.Text;

namespace Tempesta.Capstone
{
    class moneyConvertWords
    {
        private String wordsConversion = "";
        private String toConvert;
        //int digitNumberInput;

        public moneyConvertWords(String s)
        {
            if (s.Length > 0)
            {
                toConvert = s;

                tensDigit();

            }
        }
        public String getWordsConversion()
        {
            return wordsConversion;
        }
        public void tensDigit()
        {
            if (toConvert.Length != 0)
            {
                if (toConvert.Length == 3)
                {
                    // decode ones by calling decodeDigit
                    decodeDigit(toConvert[0]);
                    decodeTens(toConvert[1]);
                    if (toConvert[1] != 1)
                        decodeDigit(toConvert[2]);
                }
                else if (toConvert.Length == 2)
                {
                    decodeTens(toConvert[1]);
                    if (toConvert[0] != 1)
                        decodeDigit(toConvert[1]);
                }
                else
                {
                    decodeDigit(toConvert[0]);
                }
            }
        }

        public void decodeDigit(char aNumber)
        {
            // using switch statment

            switch (aNumber)
            {
                case '1':
                    wordsConversion += " One ";
                    break;
                case '2':
                    wordsConversion += " Two ";
                    break;
                case '3':
                    wordsConversion += " Three ";
                    break;
                case '4':
                    wordsConversion += " Four ";
                    break;
                case '5':
                    wordsConversion += " Five ";
                    break;
                case '6':
                    wordsConversion += " Six ";
                    break;
                case '7':
                    wordsConversion += " Seven ";
                    break;
                case '8':
                    wordsConversion += " Eight ";
                    break;
                case '9':
                    wordsConversion += " Nine ";
                    break;
                default:
                    return;

            }
        }
        public void decodeTens(char aNumber)
        {
            // using switch statment

            switch (aNumber)
            {
                case '1':
                    decodeTeens();
                    break;
                case '2':
                    wordsConversion += " Twenty ";
                    break;
                case '3':
                    wordsConversion += " Thirty ";
                    break;
                case '4':
                    wordsConversion += " Fourty ";
                    break;
                case '5':
                    wordsConversion += " Fifty ";
                    break;
                case '6':
                    wordsConversion += " Sixty ";
                    break;
                case '7':
                    wordsConversion += " Seventy ";
                    break;
                case '8':
                    wordsConversion += " Eighty ";
                    break;
                case '9':
                    wordsConversion += " Niney ";
                    break;
                default:
                    return;
            }

        }
        public void decodeTeens()
        {
            // using switch statment

            switch (toConvert[2])
            {
                case '0':
                    wordsConversion += " Ten ";
                    break;
                case '1':
                    wordsConversion += " Eleven ";
                    break;
                case '2':
                    wordsConversion += " Twelve ";
                    break;
                case '3':
                    wordsConversion += " Thirteen ";
                    break;
                case '4':
                    wordsConversion += " Fourteen ";
                    break;
                case '5':
                    wordsConversion += " Fifteen ";
                    break;
                case '6':
                    wordsConversion += " Sixteen ";
                    break;
                case '7':
                    wordsConversion += " Seventeen ";
                    break;
                case '8':
                    wordsConversion += " Eighteen ";
                    break;
                case '9':
                    wordsConversion += " Nineteen ";
                    break;
                default:
                    return;
            }

        }
    }
}