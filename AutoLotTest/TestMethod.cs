using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using AutoLotDal_NetStandart.Models;
using AutoLotDal_NetStandart.Repos;

namespace AutoLotTest.Properties
{
    public static class TestMethod
    {
        public static void AddNewRecord(Inventory car)
        {
            using (var repo = new InventoryRepo())
            {
                repo.Add(car);
            }
        }

        public static void UpdateAndRecord(int CarId)
        {
            using (var repo = new InventoryRepo())
            {
                var carToUpdate = repo.GetOne(CarId);
                if (carToUpdate==null) return;
                carToUpdate.Color = "Blue";
                repo.Save(carToUpdate);
            }
        }

        public static void RemoveRecordByCar(Inventory carToDelete)
        {
            using (var repo = new InventoryRepo())
            {
                repo.Delete(carToDelete);
            }
        }

        public static void RemoveRecordById(int carId, byte[] timeStamp)
        {
            using (var repo = new InventoryRepo())
            {
                repo.Delete(carId,timeStamp);
             }
        }

        public static void Concurrency()
        {
            var repo1 = new InventoryRepo();
            var repo2 = new InventoryRepo();

            var car1 = repo1.GetOne(1);
            var car2 = repo2.GetOne(1);

            car1.PetName = "NewName";
            repo1.Save(car1);
            car2.PetName = "OtherName";
            try
            {
                repo2.Save(car2);
            }
            catch (DbUpdateConcurrencyException e)
            {
                var entry = e.Entries.Single();
                var currenValues = entry.CurrentValues;
                var originalValues = entry.OriginalValues;
                var dbValues = entry.GetDatabaseValues();
                
                Console.WriteLine("****** Parallelism error******");
                Console.WriteLine($"Current:\t{currenValues[nameof(Inventory.PetName)]}");
                Console.WriteLine($"Orig:\t{originalValues[nameof(Inventory.PetName)]}");
                Console.WriteLine($"Db:\t{dbValues[nameof(Inventory.PetName)]}");                
            }

        }
        
    }
}