using System;
using System.Collections.Generic;
using System.Text;

namespace Tempesta.Capstone
{
    class ValidateNumbers
    {
       // class ValidateNumbers
        
            public ValidateNumbers() { } //default constructor

            public bool canBeInt(String s)
            {
                try
                {
                    Convert.ToInt16(s);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public bool canBePossitiveInt(String s)
            {
                try
                {
                    if (Convert.ToInt16(s) > -1)
                        return true;
                    else
                        return false;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
