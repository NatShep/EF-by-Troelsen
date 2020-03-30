namespace AutoLotDal_NetStandart.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustId { get; set; }
        public int CarId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Inventory Inventory { get; set; }
        
    }
}