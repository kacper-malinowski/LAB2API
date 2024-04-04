using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;

[assembly: InternalsVisibleTo("APIGUI")]

namespace APIGUI {
    public class Response {
        public string copyright { get; set; }
        public string date { get; set; }
        public string explanation { get; set; }
        public string hdurl { get; set; }
        public string media_type { get; set; }
        public string service_version { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public override string ToString() {
            return $"Title: {title} {Environment.NewLine}Date: {date} {Environment.NewLine}URL: {hdurl} {Environment.NewLine}";
        }
    }
    
}
