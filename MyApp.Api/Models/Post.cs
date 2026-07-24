namespace MyApp.Api.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

      
        public PostMetadata? PostMetadata { get; set; }
    }
}