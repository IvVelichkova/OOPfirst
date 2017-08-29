using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StudentsResults
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CAdv - first result, align right with precision of 2
          //  COOP - second result, align right with precision of 2
             //   AdvOOP - third result, align right with precision of 2
               // Average – average result with precision of 4
            int n = int.Parse(Console.ReadLine());

            var list = new List<string>();
           
                
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine().Trim());

            }
            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average"));


            foreach (var item in list)
            {
                var student = item
                    .Split(new[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string studenName = student[0];
                double studentCAdv = double.Parse(student[1]);
                double studenCOCP = double.Parse(student[2]);
                double studentAdvOOP = double.Parse(student[3]);
                double avg = (studenCOCP + studentAdvOOP + studentCAdv) / 3;

                Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", studenName, studentCAdv,
                    studenCOCP, studentAdvOOP, avg));
            }
           

            
        }
    }
}
