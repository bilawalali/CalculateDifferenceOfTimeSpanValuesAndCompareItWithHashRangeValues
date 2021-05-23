using System;
using System.Collections.Generic;

namespace ListRangeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan temp_initial = TimeSpan.Parse("00:02:34.964");
            TimeSpan temp_current = TimeSpan.Parse("00:02:36.972");
            TimeSpan result = temp_current.Subtract(temp_initial);

            string output = result.ToString(@"hh\:mm\:ss\.fff");
            Console.WriteLine(string.Format("Audio is played for '{0}' seconds", output));

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
