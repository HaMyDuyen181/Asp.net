namespace HaMyDuyen_2122110528.Model
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int? ParentId { get; set; } // Nếu có menu cha
        public int Order { get; set; } // Sắp xếp
        public bool IsActive { get; set; } = true;
    }

}
