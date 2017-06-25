using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunGallery.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Picture> Videos { get; set; }
        public List<Video> Pictures { get; set; }
        public List<Album> Albums { get; set; }

        public List<Object> GetAllFiles()
        {
            return null;
        }
    }
}