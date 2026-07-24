namespace MyApp.Api.Models
{
    public class PostMetadata
    {
        public int Id { get; set; }
        public string SeoDescription { get; set; } = string.Empty;
        public int ViewsCount { get; set; }

        // Внешний ключ на Post (1-to-1)
        public int PostId { get; set; }
        public Post? Post { get; set; }
    }
}