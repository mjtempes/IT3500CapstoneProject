using System;
using System.Collections.Generic;
using System.Text;

namespace Tempesta.Capstone
{
    public class moneyConvertWordsold
    {
        public string onesPlace(String Numbers)
        {
            int inputNumber = Convert.ToInt32(Numbers);
            String words = "";
            switch (inputNumber)
            {

                case 1:
                    words = "One";
                    break;
                case 2:
                    words = "Two";
                    break;
                case 3:
                    words = "Three";
                    break;
                case 4:
                    words = "Four";
                    break;
                case 5:
                    words = "Five";
                    break;
                case 6:
                    words = "Six";
                    break;
                case 7:
                    words = "Seven";
                    break;
                case 8:
                    words = "Eight";
                    break;
                case 9:
                    words = "Nine";
                    break;
            }
            return words;
        }

        private String tensPlace(String Numbers)
        {
            int inputNumber = Convert.ToInt32(Numbers);
            String words = null;
            switch (inputNumber)
            {
                case 10:
                    words = "Ten";
                    break;
                case 11:
                    words = "Eleven";
                    break;
                case 12:
                    words = "Twelve";
                    break;
                case 13:
                    words = "Thirteen";
                    break;
                case 14:
                    words = "Fourteen";
                    break;
                case 15:
                    words = "Fifteen";
                    break;
                case 16:
                    words = "Sixteen";
                    break;
                case 17:
                    words = "Seventeen";
                    break;
                case 18:
                    words = "Eighteen";
                    break;
                case 19:
                    words = "Nineteen";
                    break;
                case 20:
                    words = "Twenty";
                    break;
                case 30:
                    words = "Thirty";
                    break;
                case 40:
                    words = "Fourty";
                    break;
                case 50:
                    words = "Fifty";
                    break;
                case 60:
                    words = "Sixty";
                    break;
                case 70:
                    words = "Seventy";
                    break;
                case 80:
                    words = "Eighty";
                    break;
                case 90:
                    words = "Ninety";
                    break;
                default:
                    if (inputNumber > 0)
                    {
                        words = tensPlace(Numbers.Substring(0, 1) + "0") + " " + onesPlace(Numbers.Substring(1));
                    }
                    break;
            }
            return words;
        }

        private String ConvertWholeNumber(String Number)
        {
            string numToWord = "";
            try
            {
                bool beginsWithZero = false;//tests for 0XX  
                bool completed = false;//test if already translated  
                double dollarAmount = (Convert.ToDouble(Number));
              
                if (dollarAmount > 0)
                {//test for zero or digit zero in a nuemric  
                    beginsWithZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int placeHolder = 0;//store digit grouping  
                    String place = "";//digit grouping words:hundres,thousand,etc...  
                    switch (numDigits)
                    {
                        case 1://ones' range  

                            numToWord = onesPlace(Number);
                            completed = true;
                            break;
                        case 2://tens' range  
                            numToWord = tensPlace(Number);
                            completed = true;
                            break;
                        case 3://hundreds' range  
                            placeHolder = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4://thousands' range
                        case 5:
                        case 6:
                            placeHolder = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 7://millions' range
                        case 8:
                        case 9:
                            placeHolder = (numDigits % 7) + 1;
                            place = " Million ";
                            break;

                        case 10://Billions's range  
                            placeHolder = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;
                        
                        default:
                            completed = true;
                            break;
                    }
                    if (!completed)
                    {//if transalation is not done, continue 
                        if (Number.Substring(0, placeHolder) != "0" && Number.Substring(placeHolder) != "0")
                        {
                            try
                            {
                                numToWord = ConvertWholeNumber(Number.Substring(0, placeHolder)) + place + ConvertWholeNumber(Number.Substring(placeHolder));
                            }
                            catch { }
                        }
                        else
                        {
                            numToWord = ConvertWholeNumber(Number.Substring(0, placeHolder)) + ConvertWholeNumber(Number.Substring(placeHolder));
                        }

                    }
                    //ignore digit grouping wordss  
                    if (numToWord.Trim().Equals(place.Trim())) numToWord = "";
                }
            }
            catch { }
            return numToWord.Trim();
        }

        public String ConvertToWords(String moneyValue)
        {
            String value = "", wholeNumber = moneyValue, dollar = "", andCent = "", centChange = "";
            String endCent = "Dollors";
            try
            {
                int decimalPlace = moneyValue.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNumber = moneyValue.Substring(0, decimalPlace);
                    dollar = moneyValue.Substring(decimalPlace + 1);
                    if (Convert.ToInt32(dollar) > 0)
                    {
                        andCent = "and ";//  separate whole numbers from cents  
                        endCent = "Cents" + endCent;//Cents  
                        centChange = ConvertWholeNumber(dollar);
                    }
                }
                value = String.Format("{0} {1}{2} {3}", ConvertWholeNumber(wholeNumber).Trim(), andCent, centChange, endCent);
            }
            catch { }
            return value.ToUpper();
        }

        private String ConvertDecimals(String number)
        {
            String cd = "", digits = "", centOne = "";
            for (int i = 0; i < number.Length; i++)
            {
                digits = number[i].ToString();
                if (digits.Equals("0"))
                {
                    centOne = "Zero";
                }
                else
                {
                    centOne = onesPlace(digits);
                }
                cd += " " + centOne;
            }
            return cd;
        }
    }
}

