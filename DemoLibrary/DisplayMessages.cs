using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DisplayMessages
    {
        public string Greeting(string firstName, int hourOfTheDay)
        {
            string output = string.Empty;
            if (hourOfTheDay < 12)
            {
                output = $"Good Morning { firstName } ";
            }
        }
    }
}
