﻿using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using MyNameSpace;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            var s = new Subject<int>();
            var o1 = s.Where(_ => true);
            var o2 = s.Where(_ => false);

            using (o1.MergeEx(o2).Subscribe(x => Console.WriteLine(x)))
            {
                foreach (var x in Enumerable.Range(0, 100)) s.OnNext(x);
            }
        }
    }
}
