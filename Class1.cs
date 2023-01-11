using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Class1
    {
        public int a1;
        public int a2;
        public int a3;
        public int masahat;
        public int mohit;
        public int b1;
        public int b2;

        public int Masahat()
        { 

                if (a2 == 0 && a3==0)
                {
                    masahat = a1 * a1;  
                }
                else if (a3 == 0)
                {
                    masahat = (a1 * a2) / 2;
                }
                else 
                {
                    masahat = ((a1 + a2) * a3) / 2;
                }
                return masahat;
        }
        public int Mohit()
        {
            if (b1==0 && b2==0)
            {
                mohit = a1 * 4;
            }
            else if (a3 == 0)
            {
                mohit = a1 + b1 + b2;
            }
            else
            {
                mohit = a1 + a2 + b1 + b2;
            }

            return mohit;
        }



    }
}

