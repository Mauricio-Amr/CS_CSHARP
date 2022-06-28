using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using composition2.Entities;

namespace composition2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Comment C1 = new Comment("Have a nice day ");
            Comment C2 = new Comment("Wow that's awesome ");

            Post p1 = new Post(
                DateTime.Parse("21/6/2018 13:05:44 "),
                "Traveling to New Zealand",
                "i'm going to visit this wonderful country ",
                12);
                p1.AddComment(C1);
                p1.AddComment(C2);


            Comment C3 = new Comment("Good nigth  ");
            Comment C4 = new Comment("May the forcebe with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good nigth guys",
                "See you tomorrow",
                5
                );
            p2.AddComment(C3);  
            p2.AddComment(C4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
