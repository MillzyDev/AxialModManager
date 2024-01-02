﻿using System.Text.Json.Serialization;

namespace Axial.Thunderstore.Models
{
    public class PackageVersionListing
    {
#pragma warning disable CS8618
        
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        
        [JsonPropertyName("version_number")]
        public string VersionNumber { get; set; }
        
        [JsonPropertyName("dependencies")]
        public string[] Dependencies { get; set; }
        
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }
        
        [JsonPropertyName("downloads")]
        public int Downloads { get; set; }
        
        [JsonPropertyName("date_created")]
        public string DateCreated { get; set; }

        [JsonPropertyName("website_url")]
        public string WebsiteUrl { get; set; }
        
        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }
        
        [JsonPropertyName("uuid4")]
        public string Uuid4 { get; set; }
        
        [JsonPropertyName("file_size")]
        public int FileSize { get; set; }
        
#pragma warning enable CS8618
    }
}
