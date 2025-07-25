namespace Northwind.Services.EntityFramework.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public float Discount { get; set; }

        public virtual Order Order { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;
    }
}
