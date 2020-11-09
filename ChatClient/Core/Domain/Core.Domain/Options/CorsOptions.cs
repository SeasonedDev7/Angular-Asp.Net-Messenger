﻿namespace Core.Domain.Options
{
    public class CorsOptions
    {
        public string[] AllowedOrigins { get; set; }
        public string[] AllowedMethods { get; set; }
        public string[] AllowedHeaders { get; set; }
    }
}
