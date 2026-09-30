namespace PresseMots.Models
{
    public class StoryTag
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int StoryId { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual Story Story { get; set; }
    }
}
