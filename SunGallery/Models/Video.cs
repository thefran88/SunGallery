using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunGallery.Models
{
    public class Video : File
    {
        public Resolution Resolution { get; set; }
        public Duration Duration { get; set; }
    }
}