namespace AdafyBlazorApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string? Logo { get; set; }
        public string LogoUrl { get; set; } = string.Empty;
        public int Ranking { get; set; }
        public string? Message {get;set;}
    }
}
