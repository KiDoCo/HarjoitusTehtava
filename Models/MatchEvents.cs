namespace AdafyBlazorApp.Models
{
    public class MatchEvents
    {

        /// <summary>
        /// Events elapsed minutes
        /// </summary>
        public int EventMinute { get; set; }

        /// <summary>
        /// Url to the Event icon
        /// </summary>
        public string EventTypeIcon { get; set; } = string.Empty;

        /// <summary>
        /// Detailed description of the event
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Tooltip text for image (resolved in frontend)
        /// </summary>
        public string AltText { get; set; } = string.Empty;
    }
}
