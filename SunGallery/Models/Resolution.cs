using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunGallery.Models
{
    public class Resolution
    {
        public int Width { get; set; } = 1;
        public int Height { get; set; } = 1;


        public float InMegaPixels()
        {
            return 1;
        }
    }
}