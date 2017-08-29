using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            int startIndex = text.IndexOf(openTag);
           

            while (startIndex!=-1)
            {
                int endIndex = text.IndexOf(closeTag);

                if (endIndex == -1)               
                    break;

                
                string uper = text.Substring(startIndex, endIndex - startIndex + closeTag.Length);
                    string replaceUper = uper.Replace(openTag, "").Replace(closeTag, "").ToUpper();

                    text = text.Replace(uper, replaceUper);
                    startIndex = text.IndexOf(openTag);
  
            }
            Console.WriteLine(text);

        }
    }
}
