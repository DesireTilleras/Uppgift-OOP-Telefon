using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftTelefon
{   
    class Display
    {
        public string DisplaySize { get; set; }
        public int DisplayNumOfColors { get; set; }


        public Display(string displaySize, int numberOfColors)
        {
            this.DisplaySize = displaySize;
            this.DisplayNumOfColors = numberOfColors;

        }
        public Display()
        {

        }

    }
}
