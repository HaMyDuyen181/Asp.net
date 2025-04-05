namespace HaMyDuyen_2122110528.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string Status { get; set; } // Pending, Completed, Cancelled
        public decimal TotalAmount { get; set; }
    }

}
