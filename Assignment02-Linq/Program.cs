using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using static Assignment02_Linq.ListGenerator;

namespace Assignment02_Linq
{
    class CustomComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
          return  Sort(x) == Sort(y);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
             return Sort(obj).GetHashCode();
        }
        string Sort(string obj)
        {
            var word = obj.ToCharArray();
            Array.Sort(word);
            return new string(word);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            #region Q1
            // var Result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            #endregion

            #region Q2
            //var Result = ProductsList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result?.ProductName ?? "Not Exsist");
            #endregion

            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(X => X > 5).ElementAt(1);
            #endregion
            //Console.WriteLine(Result);
            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LINQ - Aggregate Operators
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(X => X % 2 == 1);
            #endregion

            #region Q2
            //var Result = CustomersList.Select(X=> new
            //{
            //    X.CustomerName,
            //    Count=X.Orders.Count(),
            //});
            #endregion

            #region Q3
            //var Result = ProductsList.Select(X => new
            //{
            //    X.Category,
            //    numOfProduct = ProductsList.Count(P => P.Category == X.Category)
            //}).ToHashSet();
            #endregion

            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();
            #endregion

            #region Q5
            //var Words = File.ReadAllLines("dictionary_english.txt");
            //var Result=Words.Sum(w => w.Length);
            #endregion

            #region Q6
            //string[] Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.OrderBy(X => X.Length).FirstOrDefault();
            //Console.WriteLine(Result.Length);
            #endregion

            #region Q7
            //string[] Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.OrderByDescending(X => X.Length).FirstOrDefault().Length;
            #endregion

            #region Q8
            //string[] Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.Average(X => X.Length);
            #endregion

            #region Q9
            //var Result = ProductsList.GroupBy(P => P.Category).Select(P => new
            //{
            //    category = P.Key,
            //    total = P.Sum(X => X.UnitsInStock)

            //});
            #endregion

            #region Q10
            //var Result = ProductsList.GroupBy(X => X.Category).Select(P => new
            //{
            //    category = P.Key,
            //    cheapestProduct = P.OrderBy(X => X.UnitPrice).FirstOrDefault(),
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category={item.category}::Price={item.cheapestProduct}");
            // }
            #endregion

            #region Q11
            //var Result = from p in ProductsList
            //             group p by p.Category
            //             into pc
            //             let cheap = pc.Where(p => p.UnitPrice == pc.Min(p => p.UnitPrice))
            //             select cheap;
            #endregion

            #region Q12
            //var Result = from p in ProductsList
            //             group p by p.Category
            //           into pc
            //             let Expensive = pc.Where(p => p.UnitPrice == pc.Max(p => p.UnitPrice))
            //             select Expensive;
            #endregion


            #region Q14
            //var Result = from p in ProductsList
            //             group p by p.Category
            //           into pc
            //             let Expensive = pc.Average(p=>p.UnitPrice)
            //             select Expensive;
            #endregion



            //Console.WriteLine(Result);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item); 
            //}
            #endregion

            #region LINQ - Set Operators
            #region Q1
            //var Result = ProductsList.Select(X => X.Category).Distinct();
            #endregion

            #region Q2
            //var Result = ProductsList.Select(X => X.ProductName[0]).Union(CustomersList.Select(P => P.CustomerName[0]));
            #endregion

            #region Q3
            //var Result = ProductsList.Select(X => X.ProductName[0]).Intersect(CustomersList.Select(P => P.CustomerName[0]));
            #endregion

            #region Q4
            //var Result = ProductsList.Select(X => X.ProductName[0]).Except(CustomersList.Select(P => P.CustomerName[0]));
            #endregion

            #region Q5
            //var Result = ProductsList.Select(X => X.ProductName[^3..]).Concat(CustomersList.Select(P => P.CustomerName[^3..]));
            #endregion

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LINQ - Partitioning Operators

            #region Q1
            // var Result = CustomersList.Where(P => P.Region == "Washington").SelectMany(o => o.Orders).Take(3);
            #endregion

            #region Q2
            //var Result = CustomersList.Where(P => P.Region == "Washington").SelectMany(o => o.Orders).Skip(2);
            #endregion

            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.TakeWhile((n, i) => n > i);
            #endregion

            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile(P=>P%3!=0);
            #endregion

            #region Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile((n,i)=>n>i);
            #endregion

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LINQ - Quantifiers

            #region Q1
            // var words = File.ReadAllLines("dictionary_english.txt");
            //var Result = words.Any(W=>W.Contains("ei"));
            #endregion

            #region Q2
            //var Result = ProductsList.GroupBy(P => P.Category).Where(P => P.Any(P => P.UnitsInStock == 0)).Select(P => P);
            //foreach (var item in Result)
            //{
            //    foreach (var i in item)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region Q3
            //var Result = ProductsList.GroupBy(P => P.Category).Where(P => P.All(P => P.UnitsInStock > 0)).Select(P => P);
            //foreach (var item in Result)
            //{
            //    foreach (var i in item)
            //        Console.WriteLine(i);

            //}
            #endregion


            //Console.WriteLine(Result);

            //foreach (var item in Result)
            //{

            //        Console.WriteLine(item);     
            //}
            #endregion

            #region LINQ – Grouping Operators
            #region Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers.GroupBy(X => X % 5 );
            //foreach(var item in Result)
            //{
            //    Console.WriteLine($"Number With Reminder of {item.Key} when divided by 5");
            //    foreach(var i in item)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Q2
            //    var Words = File.ReadAllLines("dictionary_english.txt");
            //    var Result = Words.GroupBy(P => P[0]);

            //foreach(var item in Result)
            //    {
            //        Console.WriteLine(item.Key);
            //        foreach(var i in item)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            #endregion

            #region Q3
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var Result = Arr.GroupBy(X => X, new CustomComparer());

            //foreach (var item in Result)
            //{

            //     foreach(var i in item)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
          
            #endregion

            #endregion
        }
    }
}
