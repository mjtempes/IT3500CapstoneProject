using System;
using System.Collections.Generic;
using System.Text;

namespace Tempesta.Capstone
{
    class InputOutput
    {
        public InputOutput() { } //default constructor

        public void showMessageToUser(String message)
        {
            Console.WriteLine(message);
        }

        public String reciveDataFromUser(String message)
        {
            Console.Write(message + " ");
            return Console.ReadLine();
        }
    }
}

