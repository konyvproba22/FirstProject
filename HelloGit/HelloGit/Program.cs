using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "-help")
            {
                Console.WriteLine("This is the first app that demonstrates my skills with git and github.");
            }
            else
            {
                Console.WriteLine("Hello Git from SourceTree!");
            }
        }
    }
}
