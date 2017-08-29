﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal days = decimal.Parse(Console.ReadLine());  // 2 
            decimal runners = decimal.Parse(Console.ReadLine()); //50
            decimal average = decimal.Parse(Console.ReadLine()); //2
            decimal lapLength = decimal.Parse(Console.ReadLine()); //400
            decimal capacity = decimal.Parse(Console.ReadLine()); //30
            decimal moneyPerKm = decimal.Parse(Console.ReadLine()); //3
            decimal maxRuners = capacity*average;
            //The marathon runs for 2 days, with 50 runners that will make an average of 2 laps on a track that is long 400 meters. 
            //The capacity of the track is 30 runners per day. 
            //So a total of 30 * 2 = 60 maximum runners. But only 50 runners are listed, so 50 will run.
            //Total meters = 50 runners * 2 laps * 400 m = 40,000 m
            // Total kilometers = 40,000 m / 1,000 = 40 km
            //Money raised by kilometer = 3
            //Money raised for the marathon = 40 * 3 = 120
            


                if (maxRuners > runners)
                {
                    maxRuners = runners;
                }
                else

                    maxRuners = capacity*average;
                decimal totalMeters = maxRuners * days * lapLength;
                decimal totalKm = totalMeters / 1000;
                decimal moneyForRaise = moneyPerKm * totalKm;
                Console.WriteLine("Money raised: {0:f2}", moneyForRaise);


            
        }

        //1 50 10 400 1 2.5
    }
}

