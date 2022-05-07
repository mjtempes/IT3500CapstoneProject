using System;
using System.Collections.Generic;
using System.Text;

namespace Tempesta.Capstone
{
    class CreateMillionsThousandsHundredsCantsStrings
    {
        private String[] inputBrokenIntoPieces;
        //inputBrokenIntoPieces[0] = millions
        //inputBrokenIntoPieces[1] = thousands
        //inputBrokenIntoPieces[2] = hundreds
        //inputBrokenIntoPieces[4] = cents

        public CreateMillionsThousandsHundredsCantsStrings(String originalInput)
        {
            String workingString = originalInput;
            inputBrokenIntoPieces = new string[4];

            if (workingString.Contains("."))
                workingString = findCents(originalInput);

            if (workingString.Length > 6)
                workingString = findMillions(workingString);

            if (workingString.Length > 3)
                workingString = findThousands(workingString);

            if (workingString.Length > 0)
                workingString = findHundreds(workingString);
        }

        public String[] getInputBrokenIntoPieces()
        {
            return inputBrokenIntoPieces;
        }

  
        private String findHundreds(String workingString)
        {
            inputBrokenIntoPieces[2] = workingString;

            return "";
        }
    
        private String findThousands(String workingString)
        {
            if (workingString.Length < 6)
            {
                if (workingString.Length == 5)
                {
                    inputBrokenIntoPieces[1] = workingString.Substring(0, 2);
                    return workingString.Substring(2);
                }
                else
                {
                    inputBrokenIntoPieces[1] = workingString.Substring(0, 1);
                    return workingString.Substring(1);
                }
            }
            else
            {
                inputBrokenIntoPieces[1] = workingString.Substring(0, 3);
                return workingString.Substring(3);
            }
        }

        private String findMillions(String workingString)
        {
            if (workingString.Length < 9)
            {
                if (workingString.Length == 8)
                {
                    inputBrokenIntoPieces[0] = workingString.Substring(0, 2);
                    return workingString.Substring(2);
                }
                else
                {
                    inputBrokenIntoPieces[0] = workingString.Substring(0, 1);
                    return workingString.Substring(1);
                }
            }
            else 
            {
                inputBrokenIntoPieces[0] = workingString.Substring(0, 3);
                return workingString.Substring(3);
            }
        }

        private String findCents(string workingString)
        {
            int decimalPoint = workingString.IndexOf(".");

            while (workingString.Substring(decimalPoint).Length != 3)
                workingString = workingString + "0";

            inputBrokenIntoPieces[3] = workingString.Substring(decimalPoint + 1);

            return workingString.Substring(0, decimalPoint);
        }
    }
}
