using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DemoCalculatorTest
{
    public class Utilities
    {
        public string extractedDate;
        
        // This function gets the current date only (no time)
        public string GetCurrentDate()
        {
            return DateTime.Now.ToShortDateString();
        }
        
        public bool DoesFileExist(string loc)
        {
            return System.IO.File.Exists(loc);

        }
    }
}
