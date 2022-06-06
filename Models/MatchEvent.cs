namespace AdafyBlazorApp.Models
{
    public class MatchEvent
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int EventMinute { get; set; }
        public int ElapsedSeconds { get; set; }
        public int TeamId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? FullDescription { get; set; }
        public string EventTypeIcon { get; set; } = string.Empty;
        public string EventType { get; set; } = string.Empty;
        //TODO: muuta enumiksi
        public int EventTypeEnum { get; set; } 
        public int PlayerId { get; set; }
        public string Player { get; set; }
    }
}
