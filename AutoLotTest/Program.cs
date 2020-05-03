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
            Database.SetInitializer(new MyDataInitializer());
            Console.WriteLine("EF data");

            using (var repo = new InventoryRepo())
            {
                foreach (var inventory in repo.GetAll())
                {
                    Console.WriteLine(inventory);
                }
            }

            Console.ReadLine();
            TestMethod.AddNewRecord(new Inventory{Make = "BMW",Color = "Green",PetName = "NewHank"});
            Console.WriteLine("The new record has been created");
            Console.ReadLine();
            
            using (var repo = new InventoryRepo())
            {
                foreach (var inventory in repo.GetAll())
                {
                    Console.WriteLine(inventory);
                }
            }
            Console.ReadLine();

        }
        
        
    }
}