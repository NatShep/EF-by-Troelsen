using System;
using System.Data.Entity;
using AutoLotDal_NetStandart.Models;
using AutoLotDal_NetStandart.EF;
using AutoLotDal_NetStandart.Repos;
using AutoLotTest.Properties;

namespace AutoLotTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         // Database.SetInitializer(new MyDataInitializer());
            Console.WriteLine("EF data");

            using (var repo = new InventoryRepo())
            {
                foreach (var inventory in repo.GetAll())
                {
                    Console.WriteLine(inventory);
                }
            }

            Console.ReadLine();
       //     TestMethod.Concurrency();
            Console.ReadLine();
        }
        
        
    }
}