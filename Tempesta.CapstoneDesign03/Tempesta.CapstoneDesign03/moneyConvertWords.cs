using System;
using System.Collections.Generic;
using System.Text;

namespace Tempesta.CapstoneDesign03
{
    public class moneyConvertWords
    {
        public moneyConvertWords()
        {
            // calling the the methods for the ones, tens, teens, hundards, and thousands
            //convert the input number into words while adding dollors at the end of the converstion.
        }

        public int numbersOnePlace()
        {
            // use switch statment for the ones place
            // if the number is between 1 and 9
            // convert the ones place number to words
        }

        public int numbersTenPlace()
        {
            // use switch statment for the tens place
            // if the number is a multiple of ten but only two digits
            //convert the tens place for a number to words
        }

        public int numbersHundradsPlace()
        {
            // use switch statment for the hundrads place
            // if the number is between 100 and 900 and a multiple of 100 but only three digits
            // convert the number in the hurdrads place to words
        }

        public int numbersTeensPlace()
        {
            // use a switch statment for the teens
            // within the tens place if the number is between 10 and 19 convert to words
        }

        public int numbersThousandsPlace()
        {
            // use a switch statment for the thousands
            // if the number is between 1000 and 9000 and a multiple of 1000 but only four digits
            //convert the number in the thousands place to words
        }
    }
}