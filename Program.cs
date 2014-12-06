using System;
using System.Collections.Generic;
using System.Linq;

namespace MyClass
{
    struct FromToStuct
    {
        public decimal From;
        public decimal To;

        public FromToStuct(decimal from, decimal to)
            : this()
        {
            From = from;
            To = to;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var input = Console.ReadLine(); //Read number of testcases
                if (string.IsNullOrEmpty(input))
                    throw new Exception("invalid input");

                var numberOfTestCases = Int32.Parse(input.Trim());
                if (numberOfTestCases <= 0 || numberOfTestCases >= 100)
                    throw new Exception("invalid number of testcases");


                for (var testCase = 0; testCase < numberOfTestCases; testCase++)
                {
                    var userAndStoreTimes = new List<decimal>();
                    var frindsTimes = new List<FromToStuct>();

                    input = Console.ReadLine(); //read number of friends

                    if (string.IsNullOrEmpty(input))
                        throw new Exception("invalid input");

                    var numberOfFriends = Int32.Parse(input.Trim());
                    if (numberOfFriends <= 0 || numberOfFriends >= 200)
                        throw new Exception("invalid number of friends");

                    for (var index = 0; index < numberOfFriends + 5; index++)
                    {
                        input = Console.ReadLine();
                        if (string.IsNullOrEmpty(input)) //If enter is pressed accedentally
                        {
                            index--;
                            continue;
                        }

                        if (index < 3)
                        {
                            userAndStoreTimes.Add(input.IsTime());
                        }
                        else if (index < 5)
                        {
                            userAndStoreTimes.Add(input.IsMinutes());
                        }
                        else
                        {
                            var value = new FromToStuct(input.Split(' ')[0].IsTime(),
                                input.Split(' ')[1].IsTime());

                            if (value.From > value.To)
                                throw new Exception("invalid time");

                            frindsTimes.Add(value);
                        }
                    }
                    var timeToBuy = userAndStoreTimes[3] + userAndStoreTimes[4];
                    //Friend available time should be greater than user & store times
                    var match = frindsTimes.Where(a => a.From > userAndStoreTimes[1] && a.From > userAndStoreTimes[2]).
                        Where(a => a.To < userAndStoreTimes[0] && a.To > userAndStoreTimes[2]);
                    // friend end time should be less than hostel close time
                    var fromToStucts = match as FromToStuct[] ?? match.ToArray();
                    if (fromToStucts.Any())
                    {
                        for (var i = 0; i < frindsTimes.Count; i++)
                        {
                            if (fromToStucts.FirstOrDefault().From == frindsTimes[i].From &&
                                fromToStucts.FirstOrDefault().To == frindsTimes[i].To)
                            {
                                Console.WriteLine(string.Format("Case {0}: {1}", (testCase + 1), (i + 1)));
                                break;
                            }
                        }

                    }
                    else
                    {

                        Console.Write("-1");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();
        }
    }

    public static class Extentions
    {
        public static int IsMinutes(this String input)
        {
            var minute = Int32.Parse(input.Trim());

            if (minute > 0 && minute < 60)
                return minute;

            throw new Exception();
        }

        public static decimal IsTime(this String str)
        {
            var hours =
                decimal.Parse((string.Format("{0}.{1}", Int32.Parse(str.Split(':')[0]), Int32.Parse(str.Split(':')[1]))));
            if (hours > 0 || hours < 24)
                return hours;

            throw new Exception();
        }
    }
}
