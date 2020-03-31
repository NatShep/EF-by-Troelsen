using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using AutoLotDal_NetStandart.Models;

namespace AutoLotDal_NetStandart.Repos
{
    public class InventoryRepo: BaseRepo<Inventory>
    {
        public override List<Inventory> GetAll() => Context.Inventory.OrderBy(x => x.PetName).ToList();
    }
}