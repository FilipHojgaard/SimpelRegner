using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelRegner
{
    class Beregner
    {
        public int a;
        public int b;
        public int chooser;
        private int svar;

        public int Calculate()
        {
            switch (chooser)
            {
                case 1:
                    svar = a + b;
                    break;
                case 2:
                    svar = a - b;
                    break;
                case 3:
                    svar = a * b;
                    break;
                case 4:
                    svar = a / b;
                    break;
            }
            return svar;
        }
    }
}
