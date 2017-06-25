using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunGallery.Models
{
    public class Picture : File
    {
        public Resolution Resolution { get; set; }
    }
}