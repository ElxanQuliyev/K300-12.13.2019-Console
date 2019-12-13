using _12._11._2019.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zehmet olmasa teref uzunlugunu qeyd edin:");
            int trf = Convert.ToInt32(Console.ReadLine());
            DordBucaqli drd = new DordBucaqli(trf);
            Ucbucaq ucb = new Ucbucaq(trf);
            Console.WriteLine("Dordbucaqlinin sahesi:{0}",drd.Sahe()+"sm");
            Console.WriteLine("Ucbucaqlinin sahesi:{0}",ucb.Sahe()+"sm");
        }
    }
}

