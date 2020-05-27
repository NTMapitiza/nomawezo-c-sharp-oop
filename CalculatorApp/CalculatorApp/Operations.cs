using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    class Operations
    {

        public Operations()
        {
        }
        
        public double GetResults(double num1, string operation, double num2)
        {
            double results = 0D;
            if (operation == "+")
            {
                results = num1 + num2;
            }

            if (operation == "-")
            {
                results = num1 - num2;
            }
            if (operation == "*")
            {
                results = num1 * num2;
            }
            if (operation == "/")
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Division by Zero not allowed!");
                }
                else
                {
                    results = num1 / num2;
                }
            }
            return results;
        }
    }
}
