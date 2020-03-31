using System;
using System.Data.Entity;
using AutoLotDal_NetStandart.Models;
using AutoLotDal_NetStandart.EF;

namespace AutoLotTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         // Database.SetInitializer(new MyDataInitializer());
            Console.WriteLine("EF data");

            using (var context=new AutoLotEntities())
            {
                foreach (var inventory in context.Inventory)
                {
                    Console.WriteLine(inventory);
                }
            }

            Console.ReadLine();
        }
    }
}