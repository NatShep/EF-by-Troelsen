using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDal_NetStandart.Models
{
    [Table("CreditRisks")]

    public class CreditRisk
    {
        [Key]
        public int CustId { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
    }
}