using Microsoft.AspNetCore.Http.HttpResults;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace photoShare.Models
{
    public class Photo
    {
        // Primary key
        public int PhotoId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string ImageFilename { get; set; } = string.Empty;
        public bool IsPublic { get; set; } = false;
        
        //navigation property
        public List<Photo>?Tag { get; set; } //nullable
    }
}
