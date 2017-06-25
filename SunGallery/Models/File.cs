using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunGallery.Models
{
    public class File
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public float Size { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Extension { get; set; }


        public bool CopyFileTo(string path)
        {
            return false;
        }

        public bool MoveFileTo(string path)
        {
            return false;
        }

        public bool DeleteFileTo(string path)
        {
            return false;
        }
    }
}