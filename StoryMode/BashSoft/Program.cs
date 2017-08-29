using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class Program
    {
       public static void Main(string[] args)
       {
           IOManager.TraverseDirectory(@"C:\Users\Iv Velichkova\Desktop\StoryMode\BashSoft");
            OutputWriter.DisplayException("bla bla");

       }
    }
}
