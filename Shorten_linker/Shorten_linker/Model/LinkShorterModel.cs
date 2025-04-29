namespace Shorten_linker.Model
{
    public class LinkShorterModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ShorterCode { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
