namespace HumanitarianAPI.Models
{
    public class AIRecommendation
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public string SuggestedAction { get; set; } = string.Empty;
        public string MatchingResource { get; set; } = string.Empty;
        public double ConfidenceScore { get; set; }
    }
}
