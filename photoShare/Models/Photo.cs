﻿using Microsoft.AspNetCore.Http.HttpResults;
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

        [Display(Name = "Created")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Filename")]
        public string ImageFilename { get; set; } = string.Empty;
        public bool isPublic { get; set; } = false;

    }
}
