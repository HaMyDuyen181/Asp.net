namespace HaMyDuyen_2122110528.Model
{
    public class Banner
    {
        public int Id { get; set; }
        public string Title { get; set; }     // Tiêu đề banner
        public string Image { get; set; }     // Đường dẫn ảnh
        public string Link { get; set; }      // Link khi click banner
        public string Position { get; set; }  // Vị trí hiển thị (Top, Bottom, Sidebar...)
        public bool IsActive { get; set; } = true; // Trạng thái hiển thị
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
