using System.Text.Json.Serialization;

namespace Axial.Thunderstore.Models
{
    public class PackageListing
    {
#pragma warning disable CS8618
        
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
        
        [JsonPropertyName("owner")]
        public string Owner { get; set; }
        
        [JsonPropertyName("package_url")]
        public string PackageUrl { get; set; }
        
        [JsonPropertyName("donation_link")]
        public string? DonationLink { get; set; }

        [JsonPropertyName("date_created")]
        public string DateCreated { get; set; }
        
        [JsonPropertyName("date_updated")]
        public string DateUpdated { get; set; }
        
        [JsonPropertyName("uuid4")]
        public string Uuid4 { get; set; }
        
        [JsonPropertyName("rating_score")]
        public int RatingScore { get; set; }
        
        [JsonPropertyName("is_pinned")]
        public bool IsPinned { get; set; }
        
        [JsonPropertyName("is_deprecated")]
        public bool IsDeprecated { get; set; }
        
        [JsonPropertyName("has_nsfw_content")]
        public bool HasNsfwContent { get; set; }

        [JsonPropertyName("categories")]
        public string[] Catagories { get; set; }
        
        [JsonPropertyName("versions")]
        public PackageVersionListing[] Versions { get; set; }

#pragma warning enable CS8618
    }
}
