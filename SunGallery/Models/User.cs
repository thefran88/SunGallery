using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunGallery.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public char Sex { get; set; }
        public string Email { get; set; }
        public Picture ProfilePicture { get; set; }
        public string PhoneNumber { get; set; }
        public List<int> Following { get; set; }
        public List<int> Followers { get; set; }


        public void AddToFavorite(File file)
        {

        }

        public void FolllowUser(int ID)
        {

        }
    }
}