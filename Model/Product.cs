namespace HaMyDuyen_2122110528.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Thêm trường Slug và CreatedDate
        public string Slug { get; set; }
        public int Price { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Mặc định là thời gian hiện tại

        // Thêm các khóa ngoại CategoryId và BrandId
        public int CategoryId { get; set; }
        public int BrandId { get; set; }

    }
}
