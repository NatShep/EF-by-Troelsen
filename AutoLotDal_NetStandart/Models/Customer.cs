using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLotDal_NetStandart.Models.Base;

namespace AutoLotDal_NetStandart.Models
{
    [Table("Customers")]

    public class Customer: EntityBase
    {
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }

        [NotMapped] public string FullName => FirstName + " " + LastName;
        
        public virtual ICollection<Order> Orders { get; set; }=new HashSet<Order>();
        
    }
}