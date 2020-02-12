using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathamatics" };
            //var list = from word in words
            //           where word.Contains("th")
            //           select word;

            //foreach (string words1 in list)
            //{
            //    Console.WriteLine(words1);
            //}
            //Console.ReadKey();

            //2
            //List<string> namesList1 = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var namesList2 = namesList1.Distinct();
            //foreach (string name in namesList2)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();

            //3
            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

            //List<double> minsOfEach = new List<double>();
            var avg = classGrades.Select(
                g =>
                {
                    var parsedInts = g.Split(',').Select(x => int.Parse(x));  //spliting each element into lists of ints ex80,100,92,89,65
                    var avgRemovedMin = parsedInts.Where(x => x != parsedInts.Min()).Average(); //elements not equal to the min int and average the rest
                    return avgRemovedMin; //To return from Select() it is returning a list of doubles
                    //minsOfEach.Add(avgRemovedMin);                    
                }
            ).Average();

            //Console.WriteLine(minsOfEach.Average());
            Console.WriteLine(avg);
            Console.ReadKey();

            //4
            string name = "Terrill";

            var result = name.ToUpper().GroupBy(a => a).Select(b => $"{b.Key}{b.Count()}").OrderBy(b => b).ToList();
            
            result.ForEach(x => Console.Write(x));

            Console.ReadKey();
       
        }


    }
}
