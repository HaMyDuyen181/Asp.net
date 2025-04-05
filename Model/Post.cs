namespace HaMyDuyen_2122110528.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

}
