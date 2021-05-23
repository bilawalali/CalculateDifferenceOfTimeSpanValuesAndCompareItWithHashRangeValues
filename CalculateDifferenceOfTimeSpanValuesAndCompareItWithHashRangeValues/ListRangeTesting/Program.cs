using System;
using System.Collections.Generic;

namespace ListRangeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            // initial time value.
            TimeSpan temp_initial = TimeSpan.Parse("00:02:34.964");
            //current time value. 
            TimeSpan temp_current = TimeSpan.Parse("00:02:36.972");
            //result  = current - initial
            TimeSpan result = temp_current.Subtract(temp_initial);
            
            // used the ToString to gave the desired representation in the format of HH.MM:SS.MS
            string output = result.ToString(@"hh\:mm\:ss\.fff");
            
            Console.WriteLine(string.Format("Audio is played for '{0}' seconds", output));
            
            // Created a new hashset with different string values.
            var RangeValueList = new HashSet<string>
                                {
                                    "00:00:01.997",
                                    "00:00:01.998",
                                    "00:00:01.999",
                                    "00:00:02.000",
                                    "00:00:02.001",
                                    "00:00:02.002",
                                    "00:00:02.003",
                                    "00:00:02.004",
                                    "00:00:02.005",
                                    "00:00:02.006",
                                    "00:00:02.007",
                                    "00:00:02.008",
                                    "00:00:02.009"
                                };
            // If list contains the out then print duration matched else not matched.
            if (RangeValueList.Contains(output))
            {
                Console.WriteLine("Duration Matched");
            }
            else
            {
                Console.WriteLine("Not matched");
            }


        }

    }
}
